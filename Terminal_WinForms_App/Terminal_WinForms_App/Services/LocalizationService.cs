namespace Terminal_WinForms_App.Services {
    public enum Language {
        Turkmen,
        Russian
    }

    public enum LocalizationKeys {
        Cancel,
        Loading,
        Pay,
        Confirm,
        Processing,
        Continue,
        Home
    }

    public class LocalizationService {
        public static Language CurrentLanguage = Language.Turkmen;
        public static string GetLocalizationText(LocalizationKeys key) {
            switch(key) {
                case LocalizationKeys.Cancel:
                    return CurrentLanguage == Language.Turkmen ? "Ýatyrmak" : "Отменить";
                case LocalizationKeys.Loading:
                    return CurrentLanguage == Language.Turkmen ? "Ýüklenýär..." : "Загружается...";
                case LocalizationKeys.Pay:
                    return CurrentLanguage == Language.Turkmen ? "Töleg et" : "Оплатить";
                case LocalizationKeys.Confirm:
                    return CurrentLanguage == Language.Turkmen ? "Tassykla" : "Подтвердить";
                case LocalizationKeys.Processing:
                    return CurrentLanguage == Language.Turkmen ? "Tölenýär..." : "Обрабатывается...";
                case LocalizationKeys.Continue:
                    return CurrentLanguage == Language.Turkmen ? "Dowam et" : "Продолжить";
                case LocalizationKeys.Home:
                    return CurrentLanguage == Language.Turkmen ? "Essasy sahypa" : "Главная";
                default: return "";
            }
        }

        public static void switchLanguage(Form1 form, Language language) {
            CurrentLanguage = language;
            form.button_confirm_phone_number.Text = GetLocalizationText(LocalizationKeys.Confirm);            
            form.button_decline_phone_number.Text = GetLocalizationText(LocalizationKeys.Cancel);
            form.button_continue.Text = GetLocalizationText(LocalizationKeys.Continue);
            form.button_to_main.Text = GetLocalizationText(LocalizationKeys.Home);
            form.confirmTextLabel.Text = CurrentLanguage == Language.Turkmen ? "Telefon belgiňiziň dogrulygyny tassyklaň" : "Пожалуйста, подтвердите номер телефона";
            form.terminalNumberTextLabel.Text = CurrentLanguage == Language.Turkmen ? "Terminalyň belgisi" : "Номер Терминала";
            form.successLabel1.Text = CurrentLanguage == Language.Turkmen ? "Töleg amala aşyryldy," : "Операция успешно завершена,";
            form.successLabel2.Text = CurrentLanguage == Language.Turkmen ? "Biziň hyzmatymyzy ulananyňyz üçin Sag Boluň!" : "Cпасибо за использование нашего сервиса!";
            form.button_accept_bill_pay.Text = GetLocalizationText(LocalizationKeys.Pay);
            form.button_payPanal_home.Text = GetLocalizationText(LocalizationKeys.Home);

        }
    }
}
