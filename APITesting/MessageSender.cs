using System;
using System.IO;
using System.Net;
using System.Text;

namespace APITesting
{
    internal class MessageSender
    {
        internal static void PostMessage(ParameterForMessage parameter)
        {
            // throw new NotImplementedException();
            var request = WebRequest.Create(parameter.ApiUrl.ToString());
            request.Method = "POST";
            var postData = new StringBuilder();
            postData.AppendUrlEncoded("username", parameter.UserName.ToString());
            postData.AppendUrlEncoded("password", parameter.Password.ToString());
            postData.AppendUrlEncoded("message", parameter.Message);
            postData.AppendUrlEncoded("receivers", parameter.CommaSeperatedReceivers.ToString());

            byte[] byteArray = Encoding.UTF8.GetBytes(postData.ToString());
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            var dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            var response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            dataStream = response.GetResponseStream();
            if (dataStream != null)
            {
                var reader = new StreamReader(dataStream);
                var responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
                reader.Close();
                dataStream.Close();
            }
            else
            {
                Console.WriteLine("Response not found from server!!!");
            }
            response.Close();
        }
    }
    }
