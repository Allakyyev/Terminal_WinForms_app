using System;
using System.Threading;
using System.Windows.Forms;
using Terminal_WinForms_App.Services;

namespace Terminal_WinForms_App {
    public enum Panels {
        Main,
        PhoneInput,
        AcceptPayment,
        ConfirmNumber,
        Success,
    }
    public partial class Form1 : Form {
        const string PHONENUMBERINITIALTEXT = "+993-_ _-_ _ _ _ _ _";
        private string terminal_Id;
        private string terminal_Key;
        private string baseUri;
        private BackEndRequestService backEndRequestService;
        private CashCodeValidatorService cashCodeValidatorService;
        private LoggingService loggingService;
        public Form1(string terminalId, string terminalKey, string baseUri, string comPort) {
            this.terminal_Id = terminalId;
            this.terminal_Key = terminalKey;
            this.baseUri = baseUri;
            backEndRequestService = new BackEndRequestService(baseUri);
            this.loggingService = new LoggingService(backEndRequestService);
            this.cashCodeValidatorService = new CashCodeValidatorService(comPort, loggingService); ;
            InitializeComponent();
            this.cashCodeValidatorService.ConnectCommand();
        }
        public void AddPhoneNumberChar(char numberChar) {
            if(label_phone_number.Text.Length == 20) {
                int replace_index = label_phone_number.Text.IndexOf('_');
                if(replace_index < 0) { return; }

                string phone_part1 = label_phone_number.Text.Substring(0, replace_index);
                string phone_part2 = label_phone_number.Text.Substring(replace_index + 1, label_phone_number.Text.Length - (replace_index + 1));
                label_phone_number.Text = phone_part1 + numberChar + phone_part2;
            }
        }
        public string Reverse(string text) {
            if(text == null) return null;

            // this was posted by petebob as well 
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        public Panels currentPanel = Panels.Main;
        public void switchToPanel(Panels panelName) {
            panelInputPhoneNumber.Visible = false;
            panelMain.Visible = false;
            panel_actions.Visible = false;
            panel_confirm_number.Visible = false;
            panel_accept_payment.Visible = false;
            panel_success.Visible = false;
            switch(panelName) {
                case Panels.Main:
                    panelMain.Visible = true;
                    panelMain.BringToFront();
                    currentPanel = Panels.Main;
                    break;
                case Panels.PhoneInput:
                    label_phone_number.Text = PHONENUMBERINITIALTEXT;
                    panelInputPhoneNumber.Visible = true;
                    panelInputPhoneNumber.BringToFront();
                    panel_actions.Visible = true;
                    panel_actions.BringToFront();
                    currentPanel = Panels.PhoneInput;
                    break;
                case Panels.ConfirmNumber:
                    panel_confirm_number.Visible = true;
                    panel_confirm_number.BringToFront();
                    label_confirm_phone_number.Text = label_phone_number.Text;
                    currentPanel = Panels.ConfirmNumber;
                    break;
                case Panels.AcceptPayment:
                    panel_accept_payment.Visible = true;
                    panel_accept_payment.BringToFront();
                    currentPanel = Panels.AcceptPayment;
                    break;
                case Panels.Success:
                    panel_success.Visible = true;
                    panel_success.BringToFront();
                    Thread.Sleep(5000);
                    switchToPanel(Panels.Main);
                    break;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            time.Text = DateTime.Now.ToString("g");
        }

        private void button_number_1_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('1');
        }

        private void button_number_2_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('2');
        }

        private void button_number_3_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('3');
        }

        private void button_number_4_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('4');
        }

        private void button_number_5_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('5');
        }

        private void button_number_6_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('6');
        }

        private void button_number_7_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('7');
        }

        private void button_number_8_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('8');
        }

        private void button_number_9_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('9');
        }

        private void button_number_0_Click(object sender, EventArgs e) {
            AddPhoneNumberChar('0');
        }

        private void button_number_del_Click(object sender, EventArgs e) {
            label_phone_number.Text = PHONENUMBERINITIALTEXT;
        }

        private void button_number_back_Click(object sender, EventArgs e) {
            string s = "";
            bool removed = false;
            for(int i = 19; i >= 4; i--) {
                if(removed) {
                    s = s + label_phone_number.Text[i];
                    continue;
                }
                if(Char.IsDigit(label_phone_number.Text[i])) {
                    removed = true;
                    s = s + "_";
                } else {
                    s = s + label_phone_number.Text[i];
                }
            }
            s += "399+";
            label_phone_number.Text = Reverse(s);
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            if(this.cashCodeValidatorService.ConnectCommand())
                switchToPanel(Panels.PhoneInput);
        }

        private void Form1_Load(object sender, EventArgs e) {
            switchToPanel(Panels.Main);
        }

        private void button1_Click(object sender, EventArgs e) {
            // Phone Input continue button
            if(label_phone_number.Text.IndexOf('_') == -1) {
                switchToPanel(Panels.ConfirmNumber);
            }
        }

        private void button_decline_phone_number_Click(object sender, EventArgs e) {
            switchToPanel(Panels.PhoneInput);
        }

        private void button_to_main_Click(object sender, EventArgs e) {
            switchToPanel(Panels.Main);
        }

        private void button_confirm_phone_number_Click(object sender, EventArgs e) {
            string phoneNumber = label_confirm_phone_number.Text.Replace("+993", "");
            phoneNumber = phoneNumber.Replace("-", "");
            phoneNumber = phoneNumber.Replace("_", "");
            phoneNumber = phoneNumber.Replace(" ", "");
            if(cashCodeValidatorService.ConnectCommand() && cashCodeValidatorService.EnableBillValidatorCommand()) {
                bool checkPhoneValidity = backEndRequestService.CheckPhoneNumberRequest(phoneNumber);
                if(checkPhoneValidity) {
                    label_accept_bill_phone.Text = label_confirm_phone_number.Text;
                    switchToPanel(Panels.AcceptPayment);
                } else {
                    switchToPanel(Panels.PhoneInput);
                }
            }
        }

        private void UpdateLabelText(string newText) {
            if(label_accept_bill_total.InvokeRequired) {
                // If called from a different thread, invoke it on the UI thread
                label_accept_bill_total.Invoke(new Action<string>(UpdateLabelText), new object[] { $"{newText}" });
            } else {
                // Update the label text directly
                label_accept_bill_total.Text = newText;
            }
        }

        private void panel_accept_payment_Paint(object sender, PaintEventArgs e) {
            this.cashCodeValidatorService.RegisterAction((int x) => {
                UpdateLabelText(this.cashCodeValidatorService.CollectedMoneySum.ToString() + "  TMT");
            });
        }

        private void button2_Click(object sender, EventArgs e) {
            if(this.cashCodeValidatorService.CollectedMoneySum <= 0) {
                this.cashCodeValidatorService.DisableBillValidatorCommand();
                switchToPanel(Panels.Main);
            }
        }

        private void button_accept_bill_pay_Click(object sender, EventArgs e) {
            this.cashCodeValidatorService.DisableBillValidatorCommand();
            if(this.cashCodeValidatorService.CollectedMoneySum <= 0) {
                switchToPanel(Panels.Main);
            } else {
                string phoneNumber = label_accept_bill_phone.Text.Replace("+993", "");
                phoneNumber = phoneNumber.Replace("-", "");
                phoneNumber = phoneNumber.Replace("_", "");
                phoneNumber = phoneNumber.Replace(" ", "");
                backEndRequestService.MakePaymentRequest(phoneNumber, this.cashCodeValidatorService.CollectedMoneySum * 100);
                switchToPanel(Panels.Success);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
        }
    }
}
