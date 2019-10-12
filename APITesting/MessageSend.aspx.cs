using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APITesting
{
    public partial class MessageSend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
     

        protected void ButtonSMS_Click(object sender, EventArgs e)
        {

            var parameter = new ParameterForMessage
            {
                ApiUrl = ConfigurationManager.AppSettings.Get("messageApiUri"),
                UserName = ConfigurationManager.AppSettings.Get("messageApiUserName"),
                Password = ConfigurationManager.AppSettings.Get("messageApiPassword"),
                Message = "Hi kalm vai !! kemon acen ?",
                CommaSeperatedReceivers = "+8801721002869"
            };

            MessageSender.PostMessage(parameter);

        }
    }
}