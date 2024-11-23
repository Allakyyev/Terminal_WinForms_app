using System;
using System.Windows.Forms;
using Terminal_WinForms_App.Services;

namespace Terminal_WinForms_App {
    public partial class Form2 : Form {
        BackEndRequestService backEndRequestService;
        public Form2(BackEndRequestService _backEndRequestService) {
            InitializeComponent();
            this.currentTotal.Text = CurrentState.CurrentSum.ToString();
            this.backEndRequestService = _backEndRequestService;
        }

        private void Cancel_Encashment_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void Submit_Encashment_Click(object sender, EventArgs e) {
            try {
                encashmentErrorLabel.Visible = false;
                bool success = await backEndRequestService.AddEnchargement(int.Parse(encashmentPasscodeTextBox.Text), int.Parse(currentTotal.Text));
                if(success) {
                    encashmentErrorLabel.Text = "";
                    CurrentState.CurrentSum = 0;
                    this.Close();
                } else {
                    encashmentErrorLabel.Visible = true;
                    encashmentErrorLabel.Text = "Неверный ключ или ошибка сервера";
                }
            } catch {
                encashmentErrorLabel.Visible = true;
                encashmentErrorLabel.Text = "Неверный ключ или ошибка системы";
            }
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void encashmentPasscodeTextBox_TextChanged(object sender, EventArgs e) {

        }

        public void SetEncashmentCode(string code) {
            this.encashmentPasscodeTextBox.Text = code;
        }
    }
}
