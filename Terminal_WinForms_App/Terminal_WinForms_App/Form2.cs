using System;
using System.Windows.Forms;
using Terminal_WinForms_App.Services;

namespace Terminal_WinForms_App {
    public partial class Form2 : Form {
        BackEndRequestService backEndRequestService;
        public Form2(BackEndRequestService _backEndRequestService) {
            InitializeComponent();
            this.backEndRequestService = _backEndRequestService;
        }

        private void Cancel_Encashment_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void Submit_Encashment_Click(object sender, EventArgs e) {
            try {
                encashmentErrorLabel.Visible = false;
                bool success = await backEndRequestService.AddEnchargement(int.Parse(encashmentPasscodeTextBox.Text));
                if(success) {
                    encashmentErrorLabel.Text = "";
                    this.Close();
                } else {
                    encashmentErrorLabel.Visible = true;
                    encashmentErrorLabel.Text = "Неверный ключ";
                }
            } catch {
                encashmentErrorLabel.Visible = true;
                encashmentErrorLabel.Text = "Неверный ключ";
            }
        }
    }
}
