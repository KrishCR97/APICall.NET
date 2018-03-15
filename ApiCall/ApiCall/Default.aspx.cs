using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ApiCall
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var jsonString = "";
            HttpWebRequest req;
            req = (HttpWebRequest)WebRequest.Create("https://nwmissouri.instructure.com/api/v1/courses" +
                "/8368/students?access_token=7438~HQ4YbVGNASSk0BGTybj7IISvCXNKx2bsL8iRgLhd1m" +
                "OruC9XKFa9wDtqMvmcDoxT");
            req.Method = "GET";
            req.ContentType = "application/json";
            var response = (HttpWebResponse)req.GetResponse();
            var stream = new StreamReader(response.GetResponseStream());
            jsonString = stream.ReadToEnd();
            stream.Close();
            var data = JToken.Parse(jsonString);
            Console.WriteLine(data);

        }
    }
}