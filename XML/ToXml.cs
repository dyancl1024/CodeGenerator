　///C#使用XSLT计算解析XML

　using   System;
　using   System.Data;
　using   System.Xml;
　using   System.IO;

namespace paladin
{

    ///   <summary>
    ///   ToXml   的摘要说明。
    ///   Author:paladin。
    ///   Last   Update   Date:   2004-6-14   16:00
    ///   YuanDa   Corporation,   2003-2010   All   Rights   Reserved
    ///
    /// 一、使用MSXML（microsoft的xml分析器）。MSXML是一个基于com的组件。
    ///	    DOMDocument40   doc=new   DOMDocument40();
    ///	    doc.load("books.xml");
    /// 二、使用net   framework自带的xml类。xmlreader、xmlwriter。
    ///	    xmlTextReader、xmlTextWriter、xmlNodeReader、XmlValidatingReader。
    ///	三、使用DOM（文档对象模型）
    ///	    xmlDocument   doc=new   xnlDocument();
    ///	    xmlDocument与xmlreader、xmlwriter不同，它具有读写功能、可以随机访问DOM树。类似MSXML的DOM执行方式。
    ///	四、使用Xpath和Xslt。
    ///	    Xpath是XML的查询语言。XSlt是把基本文档转换为结构或类型不同的另一个文档。
    ///	五、XML和ADO.NET
    ///	    XML和ADO.NET的互相转化。
    ///     访问xml文件可以用XmlTextWriter、XmlTextReader   来访问。也可以利用DOM文档模板来访问。
    ///     读取xml数据可以利用XmlTextReader   、DOM或者是ADO.net
    ///   </summary>
    public class ToXml
    {

        public ToXml()
        {
            //
            //   TODO:   在此处添加构造函数逻辑
            //
        }

        ///   <summary>
        ///   创建一个xml文件，包括根元素。
        ///   </summary>
        ///   <param   name="file"></param>
        ///   <param   name="rootElement"></param>
        public void CreateXml(string file, string rootElement)
        {

            XmlDocument doc = new XmlDocument();

            //创建一个新的XmlDeclaration，版本1.0，编码（默认utf8）和standalone标志

            XmlDeclaration newDec = doc.CreateXmlDeclaration("1.0", null, null);

            doc.AppendChild(newDec);

            //创建一个根元素

            XmlElement newRoot = doc.CreateElement(rootElement);

            doc.AppendChild(newRoot);

            //xml文件写入到磁盘

            doc.Save(file);

        }

        ///   <summary>
        ///   创建一个xml文件，xml文件的内容在xmlStr中已经构造好了。
        ///   </summary>
        ///   <param   name="xmlStr"></param>
        public void CreateXml(string xmlStr)
        {

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xmlStr);

            doc.Save(System.Web.HttpContext.Current.Server.MapPath("/newengnieer/includes/categoryTree.xml"));

        }

        ///   <summary>
        ///   添加一个xml元素，包括该元素的子元素和属性。
        ///   </summary>
        ///   <param   name="file"></param>
        public void InsertXml(string file)
        {

            XmlDocument doc = new XmlDocument();

            doc.Load(file);

            //创建一个新元素

            XmlElement newBook = doc.CreateElement("book");

            //创建该元素的属性

            newBook.SetAttribute("aa", "ss");

            newBook.SetAttribute("ss", "dd");

            //创建该元素的子元素

            XmlElement newtitle = doc.CreateElement("title");

            newtitle.InnerText = "sdfdf";

            newBook.AppendChild(newtitle);

            //创建该元素的子元素

            XmlElement newauthor = doc.CreateElement("author");

            newBook.AppendChild(newauthor);

            //

            doc.DocumentElement.AppendChild(newBook);

            //xml文件写入到磁盘

            XmlTextWriter tr = new XmlTextWriter(file, null);

            tr.Formatting = Formatting.Indented;

            doc.WriteContentTo(tr);

            tr.Close();

        }

        ///   <summary>
        ///   使用XmlTextWriter写入xml
        ///   </summary>
        private void writeToXml(string fileName)
        {

            //xml的文件路径

            //	 string   fileName=MapPath("ucTabBarConfig.xml");

            XmlTextWriter xmltw = new XmlTextWriter(fileName, System.Text.Encoding.Unicode);

            xmltw.Formatting = Formatting.Indented;

            //开始写入xml文档

            xmltw.WriteStartDocument();

            //开始写入文档元素

            xmltw.WriteStartElement("tabBar1");

            //开始写入元素‘tabBar1’下的文档元素‘tab1’

            xmltw.WriteStartElement("tab1");

            xmltw.WriteElementString("text", "违法行为立案");

            xmltw.WriteElementString("href", "");

            xmltw.WriteEndElement();

            //元素写入完毕

            xmltw.WriteStartElement("tab2");

            xmltw.WriteElementString("text", "行政处罚意见");

            xmltw.WriteElementString("href", "");

            xmltw.WriteEndElement();

            //

            xmltw.WriteStartElement("tab3");

            xmltw.WriteElementString("text", "额外");

            xmltw.WriteElementString("href", "");

            xmltw.WriteEndElement();

            //

            xmltw.WriteStartElement("tab4");

            xmltw.WriteElementString("text", "行政处罚收费");

            xmltw.WriteElementString("href", "");

            xmltw.WriteEndElement();

            //元素写入完毕

            xmltw.WriteEndElement();

            //文档写入完毕

            xmltw.WriteEndDocument();

            //

            xmltw.Flush();

            xmltw.Close();

        }

        ///   <summary>
        ///   利用xmlTextReader读取xml的数据
        ///   </summary>
        ///   <param   name="fileName"></param>
        ///   <returns></returns>
        private string readFromXml(string fileName)
        {

            //xml的文件路径
            //	 string   fileName=MapPath("ucTabBarConfig.xml");
            XmlTextReader xmltr = new XmlTextReader(fileName);
            //

            string returnValue = "";

            while (xmltr.Read())
            {

                if (xmltr.NodeType == XmlNodeType.Text)
                {

                    returnValue = returnValue + xmltr.Value;

                }

            }

            return returnValue;

        }

        ///   <summary>
        ///   利用Ado.net读取xml的数据
        ///   </summary>
        ///   <returns></returns>
        private DataView readDataFromXml(string fileName)
        {

            DataSet ds = new DataSet();

            ds.ReadXml(fileName);

            return ds.Tables[0].DefaultView;

        }

        ///   <summary>
        ///   根据strSearch条件来查找
        ///   </summary>
        ///   <param   name="file"></param>
        ///   <param   name="strSearch"></param>
        ///   <returns></returns>
        public string searchXml(string file, string strSearch)
        {

            string returnVal = "";

            XmlDocument doc = new XmlDocument();

            doc.Load(file);

            //查找	<root>

            //	 <book   name="文明">
            //	 <title>dfdf</title>
            //	 </book>
            //	 </root>
            //查找元素book的子元素的innerText“sdfdf”项
            //string   strSearch="root/book[title='sdfdf']";
            //查找元素book的属性name为“文明”项
            //string   strSearch="root/book[@name='文明']";

            XmlNode serchNode = doc.SelectSingleNode(strSearch);

            if (serchNode != null)
            {

                returnVal = serchNode.InnerText;

            }

            return returnVal;

        }

        ///   <summary>
        ///   根据TagName来查找
        ///   </summary>
        ///   <param   name="file"></param>
        ///   <param   name="TagName"></param>
        public void searchXmlByTag(string file, string TagName)
        {

            XmlDocument doc = new XmlDocument();

            doc.Load(file);

            //查找<title></title>

            XmlNodeList nodeList = doc.GetElementsByTagName("title");

            foreach (XmlNode node in nodeList)
            {

                //	 ListBox1.Items.Add(node.InnerText);

            }

        }

    }

}
