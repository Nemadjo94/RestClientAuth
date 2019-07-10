using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace restClient
{
    public enum httpverb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public enum authenticationType
    {
        Basic,
        NTLM
    }

    public enum authenticationTechnique
    {
        RollYourOwn,
        NetworkCredential
    }

    class RestClient
    {
        public string endPoint { get; set; }
        public httpverb httpMethod { get; set; }
        public authenticationType authType { get; set; }
        public authenticationTechnique authTech { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpverb.GET;
        }

        public string makeRequest()
        {
            
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            String authHeader = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(userName + ":" + userPassword));

            request.Headers.Add("Authorization", authType.ToString() + " " + authHeader)

            HttpWebResponse response = null;
            try{
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("Error code: " + response.StatusCode.ToString());
                }
                //Process the response stream... (could be JSON, XML, HTML etc...)
                using(Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }//End of StreamReader
                    }
                }//End of using ResponseStream

            }//End of using response
            catch(Exception exc)
            {
                strResponseValue = "{\"errorMessages\":[\"" + exc.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if(response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }
    }
}
