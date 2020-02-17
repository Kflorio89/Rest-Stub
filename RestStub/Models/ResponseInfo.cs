using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestStub.Models
{
    [DataContract]
    public class OACResponse
    {
        [DataMember]
        public int EsetNumber { get; set; }

        [DataMember]
        public string OrderNumber { get; set; }

        [DataMember]
        public string OrganizationCode { get; set; }

        [DataMember]
        public string JobNumber { get; set; }

        [DataMember]
        public string SerialNumber { get; set; }

        [DataMember]
        public string MACAddress { get; set; }

        [DataMember]
        public string SoftwareExtension { get; set; }

        [DataMember]
        public string OperatorName { get; set; }

        [DataMember]
        public string ClientName { get; set; }

        [DataMember]
        public string ClientType { get; set; }

        [DataMember]
        public string OrderType { get; set; }

        [DataMember]
        public string TransactionType { get; set; }

        [DataMember]
        public string ForkliftSerialNumber { get; set; }

        [DataMember]
        public string ReportTypes { get; set; }

        [DataMember]
        public Rreports Reports { get; set; }

        [DataMember]
        public RerrorDetails ErrorDetails { get; set; }

        [DataMember]
        public RresponseDetails ResponseDetails { get; set; }

        public OACResponse()
        {
            EsetNumber = 69;
            OrderNumber = null;
            OrganizationCode = "HEL";
            JobNumber = "J16997582";
            SerialNumber = "SJ419030011WA";
            MACAddress = null;
            SoftwareExtension = null;
            OperatorName = "eDelivery";
            ClientName = "eDelivery";
            ClientType = "eDelivery";
            OrderType = null;
            TransactionType = "Upgrade";
            ForkliftSerialNumber = null;
            ReportTypes = "xml";
            Reports = new Rreports
            {
                Report = new List<Rreport>
                    {
                        new Rreport
                        {
                            FileExtensionName = "xml",
                            FileName = "SJ419030011WA_OAC.xml",
                            FileContent = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iSVNPLTg4NTktMSI/PjxPcHRhY3RSZXNwb25zZT48SVRFTV9ERVRBSUxTPjxJVEVNX05VTUJFUj4yMDQxMzkwLTAwMjwvSVRFTV9OVU1CRVI+PExJQ0VOU0VfVFlQRT5Ob24tbGljZW5zZWQ8L0xJQ0VOU0VfVFlQRT48T1BUSU9OX0NPREU+TkVMTENPUjwvT1BUSU9OX0NPREU+PE9QVElPTl9OQU1FPkFUTyBPSSBORUxMQ09SIEFTU0VNQkxZPC9PUFRJT05fTkFNRT48WE1MX1RBRz5TUE8yPC9YTUxfVEFHPjxBQ1RJVkFUSU9OX0NPREU+Ti9BPC9BQ1RJVkFUSU9OX0NPREU+PExJQ0VOU0VfUVRZPjE8L0xJQ0VOU0VfUVRZPjxFWFBJUkFUSU9OX0RBVEU+bnVsbDwvRVhQSVJBVElPTl9EQVRFPjwvSVRFTV9ERVRBSUxTPg0KPElURU1fREVUQUlMUz48SVRFTV9OVU1CRVI+MjA0MTU3NS0wMDI8L0lURU1fTlVNQkVSPjxMSUNFTlNFX1RZUEU+Tm9uLWxpY2Vuc2VkPC9MSUNFTlNFX1RZUEU+PE9QVElPTl9DT0RFPjYwPC9PUFRJT05fQ09ERT48T1BUSU9OX05BTUU+U1cgT1BUIDYwSFogUE9XRVIgTElORSBGUkVRVUVOQ1kgUERNPC9PUFRJT05fTkFNRT48WE1MX1RBRz5MSU5FX0ZSRVFVRU5DWTwvWE1MX1RBRz48QUNUSVZBVElPTl9DT0RFPk4vQTwvQUNUSVZBVElPTl9DT0RFPjxMSUNFTlNFX1FUWT4xPC9MSUNFTlNFX1FUWT48RVhQSVJBVElPTl9EQVRFPm51bGw8L0VYUElSQVRJT05fREFURT48L0lURU1fREVUQUlMUz4NCjxJVEVNX0RFVEFJTFM+PElURU1fTlVNQkVSPjIwNDE1NzUtMDAzPC9JVEVNX05VTUJFUj48TElDRU5TRV9UWVBFPk5vcm1hbDwvTElDRU5TRV9UWVBFPjxPUFRJT05fQ09ERT4xNDE8L09QVElPTl9DT0RFPjxPUFRJT05fTkFNRT5TVyBPUFQgRU5BQkxFIElOVkFTSVZFIEJQPC9PUFRJT05fTkFNRT48WE1MX1RBRz5TV09QVDwvWE1MX1RBRz48QUNUSVZBVElPTl9DT0RFPkY5QTE4RDU0PC9BQ1RJVkFUSU9OX0NPREU+PExJQ0VOU0VfUVRZPjE8L0xJQ0VOU0VfUVRZPjxFWFBJUkFUSU9OX0RBVEU+bnVsbDwvRVhQSVJBVElPTl9EQVRFPjwvSVRFTV9ERVRBSUxTPg0KPFNQTzI+TkVMTENPUg0KPC9TUE8yPjxMSU5FX0ZSRVFVRU5DWT42MA0KPC9MSU5FX0ZSRVFVRU5DWT48U0VSSUFMX05VTUJFUj5TUFgxOTMwMDE0N1NBPC9TRVJJQUxfTlVNQkVSPjxEQVRFX0NPTkZJR1VSRUQ+MDcvMzEvMjAxOSAxMTo1NDoyOSBQTTwvREFURV9DT05GSUdVUkVEPjxDVVNUT01FUl9BRERSRVNTPjEwNTAwIFFVSVZJUkEgUkQsT1ZFUkxBTkQgUEFSSyxKT0hOU09OLEtTLDY2MjE1LTIzMDYsVVM8L0NVU1RPTUVSX0FERFJFU1M+PE1PREVMX05BTUU+UERNPC9NT0RFTF9OQU1FPjxPUkdBTklaQVRJT05fQ09ERT5CT1A8L09SR0FOSVpBVElPTl9DT0RFPjxDVVNUT01FUl9OVU1CRVI+MjAyMTE5PC9DVVNUT01FUl9OVU1CRVI+PENVU1RPTUVSX05BTUU+T1ZFUkxBTkQgUEFSSyBSRUdJT05BTCBNRURJQ0FMPC9DVVNUT01FUl9OQU1FPjxFUlBfSU5TVEFOQ0U+RzwvRVJQX0lOU1RBTkNFPjxKT0JfTlVNQkVSPkJPUDE4MDc4NjEzPC9KT0JfTlVNQkVSPjxPUkRFUl9OVU1CRVI+NDc4MjE1ODwvT1JERVJfTlVNQkVSPjxQQVJFTlRfSVRFTV9OVU1CRVI+MjA0MjA4NC0wMDEtMDUwNDc1PC9QQVJFTlRfSVRFTV9OVU1CRVI+PC9PcHRhY3RSZXNwb25zZT4="
                        }
                    }
                };
            ErrorDetails = new RerrorDetails
                {
                    ErrorCode = null,
                    ErrorMessage = null
                };
            ResponseDetails = new RresponseDetails
                {
                    ResponseCode = 200,
                    ResponseMessage = "Success"
                };
        }
        public class Rreports
        {
            public List<Rreport> Report { get; set; }
        }

        public class Rreport
        {
            public string FileExtensionName { get; set; }
            public string FileName { get; set; }
            public string FileContent { get; set; }
        }

        public class RerrorDetails
        {
            public string ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class RresponseDetails
        {
            public int ResponseCode { get; set; }
            public string ResponseMessage { get; set; }
        }
        /*
        {
            "EsetNumber": "1",
            "OrderNumber": null,
            "OrganizationCode": "HEL",
            "JobNumber": "J16997582",
            "SerialNumber": "SJ419030011WA",
            "MACAddress": null,
            "SoftwareExtension": null,
            "OperatorName": "eDelivery",
            "ClientName": "eDelivery",
            "ClientType": "eDelivery",
            "OrderType": null,
            "TransactionType": "Upgrade",
            "ForkliftSerialNumber": null,
            "ReportTypes": "xml",
            "Reports": 
            {
                "Report": 
                [{
                    "FileExtensionName": "xml",
                    "FileName": "SJ419030011WA_OAC.xml",
                    "FileContent": ****** 
                }]
            },
            "ErrorDetails":    
            {
                "ErrorCode": null,
                "ErrorMessage": null
            },   
            "ResponseDetails":    
            {
                "ResponseCode": 200,
                "ResponseMessage": "Success"
            }
        }
        */
    }

    [DataContract]
    public class TokenResponse
    {
        [DataMember]
        public string AccessToken { get; set; }

        [DataMember]
        public string TokenType { get; set; }

        [DataMember]
        public int ExpiresIn { get; set; }

        public TokenResponse()
        {
            AccessToken = "m6xKHwEAOvsNDhMiKgTCBzjbTcaS";
            TokenType = "Bearer";
            ExpiresIn = 7199;
        }
    }


}