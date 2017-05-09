using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;

namespace ReaderPDM.XML
{
    public partial class XMLForTree1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //XDocument doc = XDocument.Load(Server.MapPath("html5Reader/ReaderData.xml")); 
            StringBuilder sb = new StringBuilder();
            XmlDocument dc = new XmlDocument();

            string path = Server.MapPath("~/html5Reader/ReaderData.xml");

            dc.Load(path);

            XmlNodeList xnl = dc.SelectNodes("section/chapter");

            sb.Append("<ul>");
            readxml(xnl, sb);
            sb.Append("</ul>");
            this.html.InnerHtml = sb.ToString();
        }


        private void readxml(XmlNodeList xmlnl, StringBuilder sb_)
        {

           foreach (XmlNode xl in xmlnl)
            {
                if (xl.ChildNodes.Count == 0)
                {
                    sb_.Append("<li><a>" + xl.Attributes["value"].Value + "</a></li>");

                }
                else
                {
                    sb_.Append("<li><a>" + xl.Attributes["value"].Value + "</a><ul>");
                    readxml(xl.ChildNodes, sb_);
                    sb_.Append("</ul></li>");
                }
            }
        }
    }
}
