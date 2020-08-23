using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace RBGE.Source.Http
{
    class Request
    {
        private string _url;
        private HttpWebRequest _httpRequest;
        private string _responseString;
        private bool _loaded = false;

        public Request(string url)
        {
            this._url = url;
            this._httpRequest = (HttpWebRequest)HttpWebRequest.CreateHttp(url);

            this._httpRequest.Method = WebRequestMethods.Http.Get;
            this._httpRequest.ContentType = "application/json; charset=utf-8";
            this._httpRequest.BeginGetResponse(GetResponseCallback, this._httpRequest);
        }

        public void GetResponseCallback(IAsyncResult asyncResult)
        {
            WebResponse resp = this._httpRequest.EndGetResponse(asyncResult);
            HttpWebResponse response = (HttpWebResponse)resp;
            Stream streamResponse = response.GetResponseStream();
            StreamReader streamRead = new StreamReader(streamResponse);
            this._responseString = streamRead.ReadToEnd();
            //CLose the stream object
            streamResponse.Close();
            streamRead.Close();
            // Release the HttpWebResponse
            response.Close();
            this._loaded = true;
        }

        public List<string[]> Response()
        {
            while (!this._loaded) { continue; }
            List<string[]> returnedData = JsonConvert.DeserializeObject<List<string[]>>(this._responseString);

            return returnedData;
        }

        public static bool UrlExist(string file)
        {
            bool exist = false;
            HttpWebResponse response = null;
            var request = (HttpWebRequest)WebRequest.Create(file);
            request.Method = "HEAD";
            request.Timeout = 5000;
            request.AllowAutoRedirect = false;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                exist = response.StatusCode == HttpStatusCode.OK;
            }
            catch
            {
                exist = false;// System.Windows.MessageBox.Show(e.Message);
            }
            finally
            {
                if (response != null)
                    response.Close();
            }
            return exist;
        }
    }
}