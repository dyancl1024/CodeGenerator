using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReaderPDM.PDM;
using System.Text;
using System.Data;
using System.Collections;
using paladin;
using System.Xml;
using ReaderPDM.XML;
using System.IO;
using System.Xml.Xsl;

namespace ReaderPDM.Test
{
    public partial class TestPDM : System.Web.UI.Page
    {
        Hashtable ht = new Hashtable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                ViewState["vsHT"] = null;
                ViewState["vsFK"] = null;
                InitPageDate();
            }
        }

        private void InitPageDate()
        {
            //房屋建筑物类.PDM
            //PdmReader mTest = new PdmReader("C:\\Documents and Settings\\Administrator\\桌面\\设备系统\\jne\\EIPOA_JNE.pdm");
            //PdmReader mTest = new PdmReader("E:\\FTTraining.pdm");// C:\\User\\ycl\\Desktop\\FJTraining.pdm
            PdmReader mTest = new PdmReader("E:\\xx.pdm");// C:\\User\\ycl\\Desktop\\FJTraining.pdm

            mTest.InitData();
            ViewState["vsFK"] = getFKs(mTest.FKInfos);
            this.lblPDM.Text = Convert.ToString(mTest.Tables.Count);
            StringBuilder curTable = new StringBuilder();
            ht.Clear();
            tvXML.Nodes.Clear();
            for (int i = 0; i < mTest.Tables.Count; i++)
            {
                //curTable.Append(" <span style=\"color:Blue\">Table Name :</span>&nbsp;&nbsp;" + mTest.Tables[i].Name + "     &nbsp;&nbsp;[列数：&nbsp;&nbsp;" + mTest.Tables[i].Columns.Count + "] .<br/>");

                TreeNode child = new TreeNode();
                child.Text = mTest.Tables[i].Name + "(" + mTest.Tables[i].Code + ")";
                child.Value = mTest.Tables[i].TableId;

                child.NavigateUrl = "";
                child.Target = "TreeRightFrame";
                this.tvXML.Nodes.Add(child);
                this.tvXML.ExpandDepth = 0;
                ht.Add(mTest.Tables[i].TableId, mTest.Tables[i]);
                foreach (ColumnInfo col in mTest.Tables[i].Columns)
                {
                    /*
                    curTable.Append(" &nbsp;&nbsp; <span style=\"color:Blue\"> Column Name :</span>&nbsp;&nbsp;" + col.Name);
                    curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> code : </span>&nbsp;&nbsp;" + col.Code);
                    curTable.Append(" &nbsp;&nbsp; <span style=\"color:Blue\"> type : </span>&nbsp;&nbsp;" + col.DataType);
                    curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> length:</span>&nbsp;&nbsp;" + col.Length);
                    curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> Is Identity:</span>&nbsp;&nbsp;" + col.Identity);
                    curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> Is Mandatory:</span>&nbsp;&nbsp;" + col.Mandatory);
                    //curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> ModificationDate:</span>&nbsp;&nbsp;" + col.ModificationDate);
                    //curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> ObjectID:</span>&nbsp;&nbsp;" + col.ObjectID);
                    //curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> PhysicalOptions:</span>&nbsp;&nbsp;" + col.PhysicalOptions);
                    //curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> ExtendedAttributesText:</span>&nbsp;&nbsp;" + col.ExtendedAttributesText);
                    //curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> Comment:</span>&nbsp;&nbsp;" + col.Comment);
                    //curTable.Append(" &nbsp;&nbsp;<span style=\"color:Blue\"> ColumnId:</span>&nbsp;&nbsp;" + col.ColumnId);
                    curTable.Append("            .<br/>");
                    */

                    if (col != null)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = col.Name + "(" + col.Code + " " + col.DataType + ")";
                        node.Value = col.ColumnId;

                        node.NavigateUrl = "#";

                        node.Target = "TreeRightFrame";
                        child.ChildNodes.Add(node);
                    }
                }
                this.tvXML.ExpandDepth = 0;
            }


            ViewState["vsHT"] = ht;
            lblTable.Text = curTable.ToString();
        }



        private void AddReplies(ref DataTable dt, TreeNode node, string GLID, string dw)
        {



        }


        /// <summary>
        /// 根据选择的表 生成标准XML文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnFormatXML_Click(object sender, EventArgs e)
        {
            ////XML操作类
            ToXml toXML = new ToXml();

            ////获取选择的TableID
            ArrayList aCheckId = new ArrayList();

            TreeView curTV = this.tvXML;

            XmlDocument doc = new XmlDocument();

            //创建一个新的XmlDeclaration，版本1.0，编码（默认utf8）和standalone标志
            XmlDeclaration newDec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            doc.AppendChild(newDec);

            //创建一个根元素
            XmlElement newTableRoot = doc.CreateElement("tables");

            //数据库外键信息
            Hashtable hashFk = (Hashtable)ViewState["vsFK"];

            for (int i = 0; i < curTV.Nodes.Count; i++)
            {
                if (curTV.Nodes[i].Checked)
                {
                    //aCheckId.Add(curTV.Nodes[i].Value);

                    //////根据TableId到Hashtable中获取TableInfo对象
                    ht = (Hashtable)ViewState["vsHT"];

                    TableInfo curTableInfo = formatTableInfo((TableInfo)ht[curTV.Nodes[i].Value]);

                    //主键信息
                    Hashtable hashPK = getPKs(curTableInfo.PKInfos);

                    //创建该元素的子元素
                    XmlElement newTable = doc.CreateElement("table");

                    //创建该元素的属性
                    newTable.SetAttribute("ID", curTableInfo.TableId);
                    newTable.SetAttribute("Code", curTableInfo.Code);
                    //newTable.SetAttribute("Name", curTableInfo.Name);
                    //newTable.SetAttribute("ShowCode", curTableInfo.Comment);
                    newTable.SetAttribute("Name", (curTableInfo.Comment == "" ? curTableInfo.Name : curTableInfo.Comment).Replace("\r\n", ""));
                    newTable.SetAttribute("ShowCode", curTableInfo.Code);  // 2014-12-26

                    ////当前Table的列对象
                    for (int k = 0; k < curTableInfo.Columns.Count; k++)
                    {
                        //创建该元素的子元素
                        XmlElement curColumnInfo = doc.CreateElement("column");

                        curColumnInfo.SetAttribute("ID", curTableInfo.Columns[k].ColumnId);
                        curColumnInfo.SetAttribute("Code", curTableInfo.Columns[k].Code);
                        //curColumnInfo.SetAttribute("Name", curTableInfo.Columns[k].Name);
                        //curColumnInfo.SetAttribute("ShowCode", curTableInfo.Columns[k].Comment);
                        curColumnInfo.SetAttribute("Name", (curTableInfo.Columns[k].Comment == "" ? curTableInfo.Columns[k].Name : curTableInfo.Columns[k].Comment).Replace("\r\n", " "));
                        curColumnInfo.SetAttribute("ShowCode", curTableInfo.Columns[k].Code);
                        curColumnInfo.SetAttribute("DataType", curTableInfo.Columns[k].DataType);
                        curColumnInfo.SetAttribute("Mandatory", "" + curTableInfo.Columns[k].Mandatory);
                        //是否为主键
                        if (hashPK.Contains(curTableInfo.Columns[k].ColumnId))
                        {
                            curTableInfo.Columns[k].isPK = true;
                            curColumnInfo.SetAttribute("PK", "" + curTableInfo.Columns[k].isPK);
                        }
                        //是否外键
                        if (hashFk.Contains(curTableInfo.Columns[k].ColumnId + "|" + curTableInfo.TableId))
                        {
                            ArrayList arr = (ArrayList)hashFk[curTableInfo.Columns[k].ColumnId + "|" + curTableInfo.TableId];
                            curColumnInfo.SetAttribute("FK", "True");
                            curColumnInfo.SetAttribute("FK_Col_Code", "" + arr[2]);
                            curColumnInfo.SetAttribute("FK_T_Name", "" + arr[1]);
                            curColumnInfo.SetAttribute("FK_T_Code", "" + arr[0]);
                            curColumnInfo.SetAttribute("FK_T_ShowCode", "" + arr[3]);
                        }
                        newTable.AppendChild(curColumnInfo);
                    }
                    newTableRoot.AppendChild(newTable);
                }
            }

            //////保存XML的文件名（路径）
            //string fileName = checkAndGetFileFullName("E:\\formatXML\\testA.xml");
            string fileName = checkAndGetFileFullName("E:\\testTraining.xml");

            doc.AppendChild(newTableRoot);

            //xml文件写入到磁盘
            doc.Save(fileName);

            Response.Write("<script>alert('成功！')</script>");
            ViewState["vsHT"] = null;
            InitPageDate();
        }

        /// <summary>
        /// 获取主键的Hashtable
        /// </summary>
        /// <param name="pkInfos"></param>
        /// <returns></returns>
        private Hashtable getPKs(IList<PKInfo> pkInfos)
        {
            Hashtable hash = new Hashtable();
            if (pkInfos != null && pkInfos.Count > 0)
            {
                for (int i = 0; i < pkInfos.Count; i++)
                {
                    if (hash.Contains(pkInfos[i].PkId) != true)
                    {
                        hash.Add(pkInfos[i].PkId, pkInfos[i].PkId);
                    }
                }
            }
            return hash;
        }


        /// <summary>
        /// 获取外键的Hashtable
        /// </summary>
        /// <param name="pkInfos"></param>
        /// <returns></returns>
        private Hashtable getFKs(IList<FKInfo> fkInfos)
        {
            Hashtable hash = new Hashtable();
            ArrayList param = new ArrayList();
            if (fkInfos != null && fkInfos.Count > 0)
            {
                for (int i = 0; i < fkInfos.Count; i++)
                {
                    param = new ArrayList();
                    param.Add(fkInfos[i].pTableCode);
                    param.Add(fkInfos[i].pTableName);
                    param.Add(fkInfos[i].pColumnCode);
                    param.Add(fkInfos[i].pTableShowCode);
                    hash.Add(fkInfos[i].cColumnId + "|" + fkInfos[i].cTableId, param);
                }
            }
            return hash;
        }

        /// <summary>
        /// 根据选择的表 生成标准XML文件 批量生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreatetXML_Click(object sender, EventArgs e)
        {
            ////XML操作类
            ToXml toXML = new ToXml();

            ////获取选择的TableID
            ArrayList aCheckId = new ArrayList();

            TreeView curTV = this.tvXML;

            //数据库外键信息
            Hashtable hashFk = (Hashtable)ViewState["vsFK"];

            string filePrefix = txtPrefix.Text.Trim();
            string[] aa = filePrefix.Split(',');
            string tablename = "";
            string ShowCode = "";
            for (int i = 0; i < curTV.Nodes.Count; i++)
            {
                if (curTV.Nodes[i].Checked)
                {

                    XmlDocument doc = new XmlDocument();

                    //创建一个新的XmlDeclaration，版本1.0，编码（默认utf8）和standalone标志
                    XmlDeclaration newDec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

                    doc.AppendChild(newDec);

                    //创建一个根元素
                    XmlElement newTableRoot = doc.CreateElement("tables");

                    //aCheckId.Add(curTV.Nodes[i].Value);

                    //////根据TableId到Hashtable中获取TableInfo对象
                    ht = (Hashtable)ViewState["vsHT"];
                    TableInfo curTableInfo = formatTableInfo((TableInfo)ht[curTV.Nodes[i].Value]);

                    //主键信息
                    Hashtable hashPK = getPKs(curTableInfo.PKInfos);

                    //创建该元素的子元素
                    XmlElement newTable = doc.CreateElement("table");

                    ShowCode = curTableInfo.Code;
                    for (var ii = 0; ii < aa.Length; ii++)
                    {
                        ShowCode = ShowCode.TrimStart(aa[ii].ToCharArray());
                    }

                    //创建该元素的属性
                    newTable.SetAttribute("ID", curTableInfo.TableId);
                    newTable.SetAttribute("Code", curTableInfo.Code);//数据库中的列名
                    //newTable.SetAttribute("Name", curTableInfo.Name);
                    //newTable.SetAttribute("ShowCode", curTableInfo.Comment);//实体类中的字段名
                    newTable.SetAttribute("Name", (curTableInfo.Comment == "" ? curTableInfo.Name : curTableInfo.Comment).Replace("\r\n", " "));
                    newTable.SetAttribute("ShowCode", ShowCode);//实体类中的字段名

                    string ns = txtNameSpace.Text.Trim();
                    if (ns == "")
                        ns = "cn.infocell";
                    curTableInfo.nameSpace = ns;//名字空间
                    newTable.SetAttribute("namespace", curTableInfo.nameSpace);
                    bool isFound = false;//查询是否有外键引用
                    ////当前Table的列对象
                    for (int k = 0; k < curTableInfo.Columns.Count; k++)
                    {
                        //创建该元素的子元素

                        XmlElement curColumnInfo = doc.CreateElement("column");

                        curColumnInfo.SetAttribute("ID", curTableInfo.Columns[k].ColumnId);
                        curColumnInfo.SetAttribute("Code", curTableInfo.Columns[k].Code);
                        //curColumnInfo.SetAttribute("Name", curTableInfo.Columns[k].Name);
                        //curColumnInfo.SetAttribute("ShowCode", curTableInfo.Columns[k].Comment);
                        curColumnInfo.SetAttribute("Name", (curTableInfo.Columns[k].Comment == "" ? curTableInfo.Columns[k].Name : curTableInfo.Columns[k].Comment).Replace("\r\n", " "));
                        curColumnInfo.SetAttribute("ShowCode", curTableInfo.Columns[k].Code);
                        curColumnInfo.SetAttribute("DataType", curTableInfo.Columns[k].DataType);
                        curColumnInfo.SetAttribute("Mandatory", "" + curTableInfo.Columns[k].Mandatory);
                        //是否为主键
                        if (hashPK.Contains(curTableInfo.Columns[k].ColumnId))
                        {
                            curTableInfo.Columns[k].isPK = true;
                            curColumnInfo.SetAttribute("PK", "" + curTableInfo.Columns[k].isPK);
                        }
                        //是否外键
                        if (hashFk.Contains(curTableInfo.Columns[k].ColumnId + "|" + curTableInfo.TableId))
                        {
                            ArrayList arr = (ArrayList)hashFk[curTableInfo.Columns[k].ColumnId + "|" + curTableInfo.TableId];
                            curColumnInfo.SetAttribute("FK", "True");
                            curColumnInfo.SetAttribute("FK_Col_Code", "" + arr[2]);
                            curColumnInfo.SetAttribute("FK_T_Name", "" + arr[1]);
                            curColumnInfo.SetAttribute("FK_T_Code", "" + arr[0]);
                            curColumnInfo.SetAttribute("FK_T_ShowCode", "" + arr[3]);
                            isFound = true;
                        }

                        newTable.SetAttribute("hasFK", "" + isFound);

                        newTable.AppendChild(curColumnInfo);

                    }

                    newTableRoot.AppendChild(newTable);


                    //////保存XML的文件名（路径）
                    //string fileName = "C:\\Documents and Settings\\Administrator\\桌面\\testA.xml";
                    tablename = curTableInfo.Comment;
                    for (var ii = 0; ii < aa.Length; ii++)
                    {
                        tablename = tablename.TrimStart(aa[ii].ToCharArray());
                    }
                    string fileName = Server.MapPath("/temp/source_xml/" + curTableInfo.nameSpace + "." + tablename + ".xml");

                    doc.AppendChild(newTableRoot);

                    //xml文件写入到磁盘
                    doc.Save(fileName);
                }
            }
            Response.Write("<script>alert('成功！')</script>");
            ViewState["vsHT"] = null;
            InitPageDate();
        }


        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnExport_Click(object sender, EventArgs e)
        {
            TreeView curTV = this.tvXML;
            Hashtable curHt = new Hashtable();
            ToWord toWord = new ToWord();

            for (int i = 0; i < curTV.Nodes.Count; i++)
            {
                if (curTV.Nodes[i].Checked)
                {
                    //aCheckId.Add(curTV.Nodes[i].Value);

                    //////根据TableId到Hashtable中获取TableInfo对象
                    ht = (Hashtable)ViewState["vsHT"];
                    TableInfo curTableInfo = (TableInfo)ht[curTV.Nodes[i].Value];

                    /////将选择的Table保存在Hashtable中 为导出Excel做准备
                    curHt.Add(curTV.Nodes[i].Value, curTableInfo);
                }
            }

            if (curHt != null && curHt.Count > 0)
            {
                //////导出Excel--表清单
                toWord.ExportWord(curHt, "");
            }
            else
            {
                Response.Write("<script>alert('请先选择要导出表')</script>");
            }

        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            InitPageDate();
        }

        /// <summary>
        /// 执行xslt解析xml文件生成代码 2014.6.30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreateCode_Click(object sender, EventArgs e)
        {
            XslCompiledTransform transform = new XslCompiledTransform();
            ArrayList xmlList = new ArrayList();
            ArrayList xsltList = new ArrayList();
            string fileDir = Server.MapPath("/temp/tempfolder/");//生成的文件保存路径 路径的一部分


            string fileName = "";//生成的文件名称
            string fileSuffix = "";//生成的文件名称后缀
            //xml文件  /temp/source_xml/
            string dXmlPath = Server.MapPath("/temp/source_xml");
            DirectoryInfo xmldir = new DirectoryInfo(dXmlPath);

            foreach (FileSystemInfo fsi in xmldir.GetFileSystemInfos())
            {
                if (fsi is FileInfo)
                {
                    xmlList.Add(fsi.FullName);
                }
            }

            //xslt文件 /template/xsl_dao/
            //string dXslPath = Server.MapPath("/template/xsl_sjxx");
            string dXslPath = Server.MapPath("/template/xsl_sjxx_mysql");
            DirectoryInfo mydir = new DirectoryInfo(dXslPath);

            foreach (FileSystemInfo fsi in mydir.GetFileSystemInfos())
            {
                if (fsi is FileInfo)
                {
                    xsltList.Add(fsi.FullName);
                }
            }

            if (xsltList.Count > 0 && xmlList.Count > 0)
            {
                for (int i = 0; i < xsltList.Count; i++) //模版
                {
                    string name = System.IO.Path.GetFileName(xsltList[i].ToString());
                    fileSuffix = name.Substring(0, name.LastIndexOf('.'));
                    //////区分单个生成的文件和追加生成的文件 for 史家小学 2016-3-17
                    if (fileSuffix == "Searcher.cs" || fileSuffix == "SearchResult.cs")
                    {
                        for (int k = 0; k < xmlList.Count; k++) //数据源
                        {
                            string fname = System.IO.Path.GetFileName(xmlList[k].ToString());
                            string n1 = fname.Substring(0, fname.LastIndexOf('.'));
                            string curfiledir = "";
                            fileName = n1.Substring(n1.LastIndexOf('.') + 1);
                            curfiledir = fileDir + n1.Substring(0, n1.LastIndexOf('.')).Replace('.', '\\') + "\\" + name.Substring(0, name.IndexOf('.')) + "\\".Replace("\\\\", "\\");
                            fileName = checkAndGetFileFullName(curfiledir + "" + fileSuffix);// 文件目录+类型目录（Entity|Logic|Biz|Util|Dao|）+文件名+文件后缀（名称结尾和文件类型）
                            FileStream filestream = new FileStream(@"" + fileName, FileMode.Append);
                            XmlTextWriter myWriter = new XmlTextWriter(filestream, null);
                            transform.Load(xsltList[i].ToString());
                            transform.Transform(xmlList[k].ToString(), null, myWriter);
                            myWriter.Close();
                            filestream.Close();
                        }

                    }
                    else
                    {
                        for (int k = 0; k < xmlList.Count; k++) //数据源
                        {
                            string fname = System.IO.Path.GetFileName(xmlList[k].ToString());
                            string n1 = fname.Substring(0, fname.LastIndexOf('.'));
                            string curfiledir = "";
                            fileName = n1.Substring(n1.LastIndexOf('.') + 1);
                            curfiledir = fileDir + n1.Substring(0, n1.LastIndexOf('.')).Replace('.', '\\') + "\\" + name.Substring(0, name.IndexOf('.')) + "\\".Replace("\\\\", "\\");
                            fileName = checkAndGetFileFullName(curfiledir + fileName + fileSuffix);// 文件目录+类型目录（Entity|Logic|Biz|Util|Dao|）+文件名+文件后缀（名称结尾和文件类型）

                            XmlTextWriter myWriter = new XmlTextWriter(fileName, null);
                            transform.Load(xsltList[i].ToString());
                            transform.Transform(xmlList[k].ToString(), null, myWriter);
                            myWriter.Close();
                        }
                    }
                }

            }
        }

        /// <summary>
        /// 格式话TableInfo 当Comment为空时 Comment=Code  
        /// Comment作为显示的字段信息（实体类的字段信息 目的是区分数据库中的列字段）
        /// </summary>
        /// <param name="paramTableInfo"></param>
        /// <returns></returns>
        protected TableInfo formatTableInfo(TableInfo paramTableInfo)
        {
            if (paramTableInfo.Comment.Equals(""))
            {
                paramTableInfo.Comment = paramTableInfo.Code;
            }

            for (int i = 0; i < paramTableInfo.Columns.Count; i++)
            {
                if (paramTableInfo.Columns[i].Comment.Equals(""))
                    paramTableInfo.Columns[i].Comment = paramTableInfo.Columns[i].Code;
            }
            return paramTableInfo;
        }

        protected string checkAndGetFileFullName(string fileFullName)
        {
            if (!File.Exists(fileFullName))
            {
                //路径
                string fileDir = fileFullName.Substring(0, fileFullName.LastIndexOf("\\"));
                if (Directory.Exists(fileDir) != true)
                {
                    Directory.CreateDirectory(fileDir);
                }
                //文件
                File.Create(fileFullName).Close();
            }


            return fileFullName;
        }


        /// <summary>
        /// 执行xslt解析xml文件生成代码 2014.6.30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnTest_Click(object sender, EventArgs e)
        {
            XslCompiledTransform transform = new XslCompiledTransform();

            string dXmlPath = Server.MapPath("/temp/source_xml");
            DirectoryInfo xmldir = new DirectoryInfo(dXmlPath);

            foreach (FileSystemInfo fsi in xmldir.GetFileSystemInfos())
            {
                if (fsi is FileInfo)
                {
                    string fullname = fsi.FullName;
                    string fname = System.IO.Path.GetFileName(fsi.FullName);
                    string n1 = fname.Substring(0, fname.LastIndexOf('.'));
                    string newFname = n1.Substring(n1.LastIndexOf('.') + 1);
                    fname = checkAndGetFileFullName(Server.MapPath("\\2014test\\" + newFname + "TestEntity.cs"));
                    XmlTextWriter myWriter = new XmlTextWriter(fname, null);
                    transform.Load(Server.MapPath("/template/xsl_entity/TestEntity.cs.xslt"));
                    transform.Transform(fullname, null, myWriter);
                    myWriter.Close();
                }
            }
        }
    }
}
