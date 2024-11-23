using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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

        private const int WM_DEVICECHANGE = 0x0219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);

            if(m.Msg == WM_DEVICECHANGE) {
                if((int)m.WParam == DBT_DEVICEARRIVAL) {
                    string usbDriveLetter = GetUsbDriveLetter();
                    if(!string.IsNullOrEmpty(usbDriveLetter)) {
                        SearchFileOnUsb(usbDriveLetter);
                    }
                } else if((int)m.WParam == DBT_DEVICEREMOVECOMPLETE) {
                }
            }
        }

        private string GetUsbDriveLetter() {
            DriveInfo[] drives = DriveInfo.GetDrives();
            DriveInfo usbDrive = drives.FirstOrDefault(d => d.DriveType == DriveType.Removable && d.IsReady);

            if(usbDrive != null) {
                return usbDrive.RootDirectory.FullName;
            }

            return null;
        }

        private void SearchFileOnUsb(string driveLetter) {
            try {
                string[] files = Directory.GetFiles(driveLetter, "*.txt");
                if(files.Length > 0) {
                    foreach(string file in files) {
                        string fileContent = File.ReadAllText(file);

                        string terminalIdPattern = @"TerminalId:\s*([a-zA-Z0-9-]+)";
                        string terminalKeyPattern = @"TerminalKey:\s*([a-zA-Z0-9\+/=]+)";
                        string encashmentCodePattern = @"Encashment Code:\s*(\d+)";
                        Match terminalIdMatch = Regex.Match(fileContent, terminalIdPattern);
                        Match terminalKeyMatch = Regex.Match(fileContent, terminalKeyPattern);
                        Match encashmentCodeMatch = Regex.Match(fileContent, encashmentCodePattern);

                        if(terminalIdMatch.Success && terminalKeyMatch.Success && encashmentCodeMatch.Success) {
                            string terminalId = terminalIdMatch.Groups[1].Value;
                            string terminalKey = terminalKeyMatch.Groups[1].Value;
                            string encashmentCode = encashmentCodeMatch.Groups[1].Value;
                            if(this.terminal_Id == terminalId && this.terminal_Key == terminalKey) {
                                Form2 form2 = new Form2(backEndRequestService);
                                form2.SetEncashmentCode(encashmentCode);
                                form2.ShowDialog();
                            }

                        }
                    }
                }
            } catch(Exception ex) {
            }
        }

        public Form1(string terminalId, string terminalKey, string baseUri, string comPort) {
            this.terminal_Id = terminalId;
            this.terminal_Key = terminalKey;
            this.baseUri = baseUri;
            backEndRequestService = new BackEndRequestService(baseUri, terminalId, terminalKey);
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
            timer2.Stop();
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
                    button_confirm_phone_number.Enabled = true;
                    button_confirm_phone_number.Text = "Подтвердить";
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
                    button_confirm_phone_number.Enabled = true;
                    button_confirm_phone_number.Text = "Подтвердить";
                    UpdateLabelText(this.cashCodeValidatorService.CollectedMoneySum.ToString() + "  TMT");
                    this.cashCodeValidatorService.ResetCollectedMoneySumCommand();
                    break;
                case Panels.Success:
                    panel_success.Visible = true;
                    panel_success.BringToFront();
                    currentPanel = Panels.AcceptPayment;
                    //Thread.Sleep(5000);
                    button_accept_bill_pay.Enabled = true;
                    button_accept_bill_pay.Text = "Оплатить";
                    button2.Enabled = true;
                    success_hide_timer.Start();
                    //switchToPanel(Panels.Main);
                    break;
            }
            timer2.Start();
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

        private async void pictureBox1_Click(object sender, EventArgs e) {
            if(await this.cashCodeValidatorService.ConnectCommand())
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

        private async void button_confirm_phone_number_Click(object sender, EventArgs e) {
            button_confirm_phone_number.Enabled = false;
            button_confirm_phone_number.Text = "Загружается...";
            UpdateLabelText(this.cashCodeValidatorService.CollectedMoneySum.ToString() + "  TMT");
            string phoneNumber = label_confirm_phone_number.Text.Replace("+993", "993");
            phoneNumber = phoneNumber.Replace("-", "");
            phoneNumber = phoneNumber.Replace("_", "");
            phoneNumber = phoneNumber.Replace(" ", "");
            bool checkPhoneValidity = await backEndRequestService.CheckPhoneNumberRequest(phoneNumber);
            if(checkPhoneValidity && (await cashCodeValidatorService.ConnectCommand()) && (await cashCodeValidatorService.EnableBillValidatorCommand()) && CurrentState.DealerTotal > 0) {
                await loggingService.Repaired();
                label_accept_bill_phone.Text = label_confirm_phone_number.Text;
                switchToPanel(Panels.AcceptPayment);
            } else {
                switchToPanel(Panels.PhoneInput);
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

        private async void button2_Click(object sender, EventArgs e) {
            if(this.cashCodeValidatorService.CollectedMoneySum <= 0) {
                await this.cashCodeValidatorService.DisableBillValidatorCommand();
                switchToPanel(Panels.Main);
            }
        }

        private async void button_accept_bill_pay_ClickAsync(object sender, EventArgs e) {
            button_accept_bill_pay.Enabled = false;
            button_accept_bill_pay.Text = "Обрабатывается...";
            button2.Enabled = false;
            await this.cashCodeValidatorService.DisableBillValidatorCommand();
            if(this.cashCodeValidatorService.CollectedMoneySum <= 0) {
                switchToPanel(Panels.Main);
            } else {
                string phoneNumber = label_accept_bill_phone.Text.Replace("+993", "993");
                phoneNumber = phoneNumber.Replace("-", "");
                phoneNumber = phoneNumber.Replace("_", "");
                phoneNumber = phoneNumber.Replace(" ", "");
                var result = await backEndRequestService.MakePaymentRequest(phoneNumber, this.cashCodeValidatorService.CollectedMoneySum * 100);
                // TODO 
                // Check result.Success and take appropriate measures to tackle fail situation 
                this.cashCodeValidatorService.ResetCollectedMoneySumCommand();
                switchToPanel(Panels.Success);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
        }

        private async void timer2_Tick(object sender, EventArgs e) {
            if(this.cashCodeValidatorService.CollectedMoneySum <= 0) {
                await this.cashCodeValidatorService.DisableBillValidatorCommand();
                switchToPanel(Panels.Main);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            if(e.Alt && e.Control && e.KeyCode == Keys.A) {
                Form2 form2 = new Form2(backEndRequestService);
                form2.ShowDialog();
            }
        }

        private void success_hide_timer_Tick(object sender, EventArgs e) {
            switchToPanel(Panels.Main);
            success_hide_timer.Stop();
        }
    }
}
