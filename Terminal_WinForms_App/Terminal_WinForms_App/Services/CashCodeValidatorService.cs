﻿using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BillValidator.CashCode.Driver;
using BillValidator.CashCode.Driver.BillsDefinition;
using BillValidator.CashCode.Driver.Models;

namespace Terminal_WinForms_App.Services {
    public class CashCodeValidatorService {
        CashCodeBillValidator _cacheCodeValidator = new CashCodeBillValidator();
        Action<int> onBillAccepted;
        LoggingService logginService;
        public CashCodeValidatorService(string port, LoggingService loggingService) {
            BillValidatorPort = port;
            IsAutoAcceptBill = true;

            _cacheCodeValidator.BillReceived += HandleBillReceived;
            _cacheCodeValidator.BillStacking += HandleBillStacking;
            _cacheCodeValidator.BillCassetteStatusEvent += HandleBillCassetteStatusEvent;
            this.logginService = loggingService;
        }

        private string _billValidatorPort;
        public string BillValidatorPort {
            get => _billValidatorPort;
            set { _billValidatorPort = value; }
        }

        private bool _isAutoAcceptBill;
        public bool IsAutoAcceptBill {
            get => _isAutoAcceptBill;
            set { _isAutoAcceptBill = value; }
        }

        private int _collectedMoneySum;
        public int CollectedMoneySum {
            get => _collectedMoneySum;
            set { _collectedMoneySum = value; }
        }
        private void HandleBillReceived(object sender, BillReceivedEventArgs e) {
            if(e.Status == BillRecievedStatus.Rejected) {

            } else if(e.Status == BillRecievedStatus.Accepted) {
                CollectedMoneySum += e.Bill.MoneyValue;
                if(this.onBillAccepted != null)
                    this.onBillAccepted(e.Bill.MoneyValue);
            }

        }

        private async Task HandleBillStacking(object sender, BillStackedEventArgs e) {
            if(IsAutoAcceptBill) {
                e.HasToRejectBill = false;
                //LogOperation($"Auto-accepted bill {e.Bill.Description}");
            } else {
                /*
                LogOperation("Choose if accept bill or not");
                var answer = await NavigationService.PopUpMessage("Question", $"Do you accept {e.Bill.Description}?", MessageDialogStyle.AffirmativeAndNegative);
                e.HasToRejectBill = answer == MessageDialogResult.Negative;
                */
            }
        }

        private void HandleBillCassetteStatusEvent(object sender, BillCassetteEventArgs e) {
            //LogOperation($"Bill casette status changed to {e.Status}");
        }
        public void DisconnectCommand() {
            try {
                _cacheCodeValidator.Dispose();
            } catch(Exception e) {
                logginService.LogError(e.Message);
            }

        }

        public bool EnableBillValidatorCommand() {
            try {
                _cacheCodeValidator.Enable();
                return true;
            } catch(Exception e) {
                logginService.LogError($"Error: {e.Message}");
                return false;
            }
        }

        public bool DisableBillValidatorCommand() {
            try {
                _cacheCodeValidator.Disable();
                return true;
            } catch(Exception e) {
                logginService.LogError($"Error: {e.Message}");
                return false;
            }

        }

        public void ResetCollectedMoneySumCommand() {
            CollectedMoneySum = 0;
        }

        public bool ConnectCommand() {
            if(_cacheCodeValidator.IsConnected)
                return true;
            try {
                _cacheCodeValidator.Connect(BillValidatorPort, new TurkmenBillsDefinition());
            } catch(Exception e) {
                logginService.LogError($"Error: {e.Message}");
                return false;
            }
            if(_cacheCodeValidator.IsConnected) {
                _cacheCodeValidator.PowerUp();
                _cacheCodeValidator.StartListening();
                return true;
            } else {
                logginService.LogWarning($"Could not connect to Cache Validator with port {BillValidatorPort}");
                return false; 
            }
        }

        public void RegisterAction(Action<int> onBillAccepted) {
            this.onBillAccepted = onBillAccepted;
        }
    }
}
