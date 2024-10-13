using System.Runtime.Serialization;

namespace Terminal_WinForms_App.Services {
    [DataContract]
    public class APIRequestBase {
        [DataMember(Name = "terminalIdEncrypted")]
        public string TerminalIdEncrypted { get; set; }
    }

    [DataContract]
    public class APIResponseBase {
        [DataMember(Name = "success")]
        public bool Success { get; set; }
    }

    [DataContract]
    public class CheckDestinationRequest : APIRequestBase {        
        [DataMember(Name = "serviceKey")]
        public string ServiceKey { get; set; }

        [DataMember(Name = "msisdnEncrypted")]
        public string MsisdnEncrypted { get; set; }

        public string Msisdn { get; set; }
    }

    [DataContract]
    public class ForceAddRequest : APIRequestBase {
        [DataMember(Name = "serviceKey")]
        public  string ServiceKey { get; set; }

        [DataMember(Name = "amount")]
        public int Amount { get; set; }

        [DataMember(Name = "msisdnEncrypted")]
        public  string MsisdnEncrypted { get; set; }

        public string Msisdn { get; set; }        
    }

    [DataContract]
    public class CreateEncashementRequest : APIRequestBase {
        [DataMember(Name = "checkSum")]
        public string CheckSum { get; set; }
        [DataMember(Name = "checkSumEncrypted")]
        public string CheckSumEncrypted { get; set; }
        [DataMember(Name = "encashmentPasscode")]
        public int EncashmentPasscode { get; set; }
        [DataMember(Name = "sum")]
        public int Sum { get; set; }
    }

    [DataContract]
    public class RegisterTerminalRequest {
        [DataMember(Name = "terminalId")]
        public string TerminalId { get; set; }

        [DataMember(Name = "motherboardId")]
        public string MotherboardId { get; set; }

        [DataMember(Name = "cpuId")]
        public string CpuId { get; set; }
    }

    [DataContract]
    public class CheckDestinationAPIResponse : APIResponseBase { }

    [DataContract]
    public class ForceAddAPIResponse : APIResponseBase { }

    [DataContract]
    public class AddEnchargementAPIResponse : APIResponseBase { }

    [DataContract]
    public class RegisterTerminalResponse : APIResponseBase { }

}
