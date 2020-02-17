using Newtonsoft.Json;
using RestStub.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace RestStub.Controllers
{
    public class ResponseController : ApiController
    {
        // GET: api/Response
        public TokenResponse Get()
        {
            var token = new TokenResponse();
            var respond = JsonConvert.SerializeObject(token);
            var rslt = JsonConvert.DeserializeObject<TokenResponse>(respond);
            return rslt;
        }

        // GET: api/Response/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Response
        public object Post([FromUri]string value)
        {
            var headers = Request.Headers;
            if (value != null && value.ToLower() == "token")
            {
                var token = new TokenResponse();
                var trespond = JsonConvert.SerializeObject(token);
                var trslt = JsonConvert.DeserializeObject<TokenResponse>(trespond);
                return trslt;
            }
            var res = new OACResponse();
            
            var respond = JsonConvert.SerializeObject(res);
            var rslt = JsonConvert.DeserializeObject<OACResponse>(respond);
            return rslt;
            //return "Response controller response message";
        }

        // PUT: api/Response/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Response/5
        public void Delete(int id)
        {
        }
    }
}

/*
             var responseInfo = new OACResponse
            {
                EsetNumber = 1,
                OrderNumber = "null",
                OrganizationCode = "HEL",
                JobNumber = "J16997582",
                SerialNumber = "SJ419030011WA",
                MACAddress = "null",
                SoftwareExtension = "null",
                OperatorName = "eDelivery",
                ClientName = "eDelivery",
                ClientType = "eDelivery",
                OrderType = "null",
                TransactionType = "Upgrade",
                ForkliftSerialNumber = "null",
                ReportTypes = "xml",
                Reports = new Rreports
                {
                    Report = new List<Rreport>
                    {
                        new Rreport
                        {
                            FileExtensionName = "xml",
                            FileName = "SJ419030011WA_OAC.xml",
                            FileContent = "******"
                        }
                    }
                },
                ErrorDetails = new RerrorDetails
                {
                    ErrorCode = "null",
                    ErrorMessage = "null"
                },
                ResponseDetails = new RresponseDetails
                {
                    ResponseCode = 200,
                    ResponseMessage = "Success"
                }
            };
     
     */
