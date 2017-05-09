using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace ReaderPDM.PDM
{
    /****
     * pdm文件读取器类
     * ****/
    public class PdmReader
    {
        public const string a = "attribute", c = "collection", o = "object";

        public const string cClasses = "c:Classes";
        public const string oClass = "o:Class";

        public const string cAttributes = "c:Attributes";
        public const string oAttribute = "o:Attribute";

        public const string cTables = "c:Tables";
        public const string oTable = "o:Table";

        public const string cColumns = "c:Columns";
        public const string oColumn = "o:Column";

        public const string cReferences = "c:References";
        public const string oReference = "o:Reference";

        XmlDocument xmlDoc;
        XmlNamespaceManager xmlnsManager;
        /// <summary>构造函数 </summary>
        public PdmReader()
        {
            // TODO: 在此处添加构造函数逻辑
            xmlDoc = new XmlDocument();
        }
        /// <summary>构造函数 </summary>
        public PdmReader(string pdm_file)
        {
            PdmFile = pdm_file;
        }

        string pdmFile;

        public string PdmFile
        {
            get { return pdmFile; }
            set
            {
                pdmFile = value;
                if (xmlDoc == null)
                {
                    xmlDoc = new XmlDocument();
                    xmlDoc.Load(pdmFile);
                    xmlnsManager = new XmlNamespaceManager(xmlDoc.NameTable);
                    xmlnsManager.AddNamespace("a", "attribute");
                    xmlnsManager.AddNamespace("c", "collection");
                    xmlnsManager.AddNamespace("o", "object");
                }
            }
        }

        IList<TableInfo> tables;

        public IList<TableInfo> Tables
        {
            get { return tables; }
            set { tables = value; }
        }

        IList<FKInfo> fkInfos;

        public IList<FKInfo> FKInfos
        {
            get { return fkInfos; }
            set { fkInfos = value; }
        }

        public void InitData()
        {
            if (Tables == null)
                Tables = new List<TableInfo>();
            XmlNode xnTables = xmlDoc.SelectSingleNode("//" + cTables, xmlnsManager);
            if (xnTables != null && xnTables.ChildNodes != null)
            {
                foreach (XmlNode xnTable in xnTables.ChildNodes)
                {
                    Tables.Add(GetTable(xnTable));
                }
            }

            if (FKInfos == null)
                FKInfos = new List<FKInfo>();
            XmlNode xnFKs = xmlDoc.SelectSingleNode("//" + cReferences, xmlnsManager);
            if (xnFKs != null && xnFKs.ChildNodes != null)
            {
                foreach (XmlNode xnfk in xnFKs.ChildNodes)
                {
                    FKInfos.Add(GetFK(xnfk));
                }
            }
        }

        /// <summary>
        /// 获取外键信息
        /// </summary>
        /// <param name="xnFk"></param>
        /// <returns></returns>
        private FKInfo GetFK(XmlNode xnFk)
        {
            FKInfo mFKInfo = new FKInfo();
            XmlElement xe = (XmlElement)xnFk;
            XmlNodeList xnTProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnTProperty)
            {
                switch (xnP.Name)
                {
                    case "c:ParentTable":
                        {
                            ////获取当前节点的子节点 
                            XmlNodeList fkNodes = xnP.ChildNodes;
                            XmlNode curNode = fkNodes[0];
                            XmlElement curXe = (XmlElement)curNode;
                            mFKInfo.pTableId = curXe.GetAttribute("Ref");
                            XmlNode pTable = xmlDoc.SelectSingleNode("//" + cTables + "//" + oTable + "[@Id='" + curXe.GetAttribute("Ref") + "']", xmlnsManager);
                            string name = pTable.SelectNodes("a:Name", xmlnsManager)[0].InnerText;
                            string code = pTable.SelectNodes("a:Code", xmlnsManager)[0].InnerText;
                            string scode = pTable.SelectNodes("a:Comment", xmlnsManager)[0].InnerText;
                            mFKInfo.pTableCode = code;
                            mFKInfo.pTableName = name;
                            mFKInfo.pTableShowCode = scode;
                            //xmlDoc.SelectSingleNode("//" + cTables + "//" + cColumns+"//"+oColumn+"[@Id='""']");
                        }
                        break;
                    case "c:ChildTable":
                        {
                            ////获取当前节点的子节点 
                            XmlNodeList fkNodes = xnP.ChildNodes;
                            XmlNode curNode = fkNodes[0];
                            XmlElement curXe = (XmlElement)curNode;
                            mFKInfo.cTableId = curXe.GetAttribute("Ref");
                        }
                        break;
                    case "c:Joins":
                        {
                            ////获取当前节点的子节点 
                            XmlNodeList fkNodes = xnP.ChildNodes;
                            XmlNode curNode = fkNodes[0];
                            XmlElement curXe = (XmlElement)curNode;
                            XmlNodeList curTPro = curXe.ChildNodes;
                            foreach (XmlNode refer in curTPro)
                            {
                                switch (refer.Name)
                                {
                                    case "c:Object1":
                                        {
                                            ////获取当前节点的子节点 
                                            XmlNodeList nodes = refer.ChildNodes;
                                            XmlNode node = nodes[0];
                                            XmlElement el = (XmlElement)node;
                                            mFKInfo.pColumnId = el.GetAttribute("Ref");
                                            XmlNode colNode = xmlDoc.SelectSingleNode("//" + cTables + "//" + oTable + "//" + cColumns + "//" + oColumn + "[@Id='" + el.GetAttribute("Ref") + "']", xmlnsManager);
                                            string code = colNode.SelectNodes("a:Code", xmlnsManager)[0].InnerText;
                                            mFKInfo.pColumnCode = code;
                                        }
                                        break;
                                    case "c:Object2":
                                        {
                                            ////获取当前节点的子节点 
                                            XmlNodeList nodes = refer.ChildNodes;
                                            XmlNode node = nodes[0];
                                            XmlElement el = (XmlElement)node;
                                            mFKInfo.cColumnId = el.GetAttribute("Ref");
                                        }
                                        break;
                                }
                            }
                        }
                        break;

                }
            }
            return mFKInfo;
        }

        //初始化"o:Table"的节点
        private TableInfo GetTable(XmlNode xnTable)
        {
            TableInfo mTable = new TableInfo();
            XmlElement xe = (XmlElement)xnTable;
            mTable.TableId = xe.GetAttribute("Id");
            XmlNodeList xnTProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnTProperty)
            {
                switch (xnP.Name)
                {
                    case "a:ObjectID": mTable.ObjectID = xnP.InnerText;
                        break;
                    case "a:Name": mTable.Name = xnP.InnerText;
                        break;
                    case "a:Code": mTable.Code = xnP.InnerText;
                        break;
                    case "a:CreationDate": mTable.CreationDate = Convert.ToInt32(xnP.InnerText);
                        break;
                    case "a:Creator": mTable.Creator = xnP.InnerText;
                        break;
                    case "a:ModificationDate": mTable.ModificationDate = Convert.ToInt32(xnP.InnerText);
                        break;
                    case "a:Modifier": mTable.Modifier = xnP.InnerText;
                        break;
                    case "a:Comment": mTable.Comment = xnP.InnerText;
                        break;
                    case "a:PhysicalOptions": mTable.PhysicalOptions = xnP.InnerText;
                        break;
                    case "c:Columns": InitColumns(xnP, mTable);
                        break;
                    case "c:Keys": InitKeys(xnP, mTable);
                        break;
                }
            }
            return mTable;
        }

        //初始化"c:Columns"的节点
        private void InitColumns(XmlNode xnColumns, TableInfo pTable)
        {
            foreach (XmlNode xnColumn in xnColumns)
            {
                pTable.AddColumn(GetColumn(xnColumn));
            }
        }

        //初始化c:Keys"的节点
        private void InitKeys(XmlNode xnKeys, TableInfo pTable)
        {
            foreach (XmlNode xnKey in xnKeys)
            {
                //pTable.AddKey(GetKey(xnKey));
                //pTable = GetPK(xnKey, pTable);

                pTable.AddPK(getPKs(xnKeys));
            }
        }

        private ColumnInfo GetColumn(XmlNode xnColumn)
        {
            ColumnInfo mColumn = new ColumnInfo();
            XmlElement xe = (XmlElement)xnColumn;
            mColumn.ColumnId = xe.GetAttribute("Id");
            XmlNodeList xnCProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnCProperty)
            {
                switch (xnP.Name)
                {
                    case "a:ObjectID": mColumn.ObjectID = xnP.InnerText;
                        break;
                    case "a:Name": mColumn.Name = xnP.InnerText;
                        break;
                    case "a:Code": mColumn.Code = xnP.InnerText;
                        break;
                    case "a:CreationDate": mColumn.CreationDate = Convert.ToInt32(xnP.InnerText);
                        break;
                    case "a:Creator": mColumn.Creator = xnP.InnerText;
                        break;
                    case "a:ModificationDate": mColumn.ModificationDate = Convert.ToInt32(xnP.InnerText);
                        break;
                    case "a:Modifier": mColumn.Modifier = xnP.InnerText;
                        break;
                    case "a:Comment": mColumn.Comment = xnP.InnerText;
                        break;
                    case "a:DataType": mColumn.DataType = xnP.InnerText;
                        break;
                    case "a:Length": mColumn.Length = xnP.InnerText;
                        break;
                    case "a:Identity": mColumn.Identity = ConvertStringToBoolean(xnP.InnerText);
                        break;
                    case "a:Mandatory": mColumn.Mandatory = ConvertStringToBoolean(xnP.InnerText);
                        break;
                    case "a:PhysicalOptions": mColumn.PhysicalOptions = xnP.InnerText;
                        break;
                    case "a:ExtendedAttributesText": mColumn.ExtendedAttributesText = xnP.InnerText;
                        break;
                }
            }
            return mColumn;
        }

        private PdmKey GetKey(XmlNode xnKey)
        {
            PdmKey mKey = new PdmKey();
            XmlElement xe = (XmlElement)xnKey;
            mKey.KeyId = xe.GetAttribute("Id");
            XmlNodeList xnKProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnKProperty)
            {
                switch (xnP.Name)
                {
                    case "a:ObjectID": mKey.ObjectID = xnP.InnerText;
                        break;
                    case "a:Name": mKey.Name = xnP.InnerText;
                        break;
                    case "a:Code": mKey.Code = xnP.InnerText;
                        break;
                    case "a:CreationDate": mKey.CreationDate = Convert.ToInt32(xnP.InnerText);
                        break;
                    case "a:Creator": mKey.Creator = xnP.InnerText;
                        break;
                    case "a:ModificationDate": mKey.ModificationDate = Convert.ToInt32(xnP.InnerText);
                        break;
                    case "a:Modifier": mKey.Modifier = xnP.InnerText;
                        break;
                    //case "c:Key.Columns":InitPK(xnP,)
                }
            }
            return mKey;
        }

        /// <summary>
        /// 获取主键信息
        /// </summary>
        /// <param name="xnKey"></param>
        /// <returns></returns>
        private List<PKInfo> getPKs(XmlNode xnKey)
        {
            List<PKInfo> pPks = new List<PKInfo>();
            PKInfo curPk = null;
            XmlElement xe = (XmlElement)xnKey;
            XmlNodeList xnKProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnKProperty)
            {
                switch (xnP.Name)
                {
                    case "o:Key":
                        {
                            ////获取当前节点的子节点 遍历获取主键的字段id
                            XmlNode colP = xnP.SelectNodes("c:Key.Columns", xmlnsManager)[0];
                            XmlNodeList pkNodes = colP.ChildNodes;
                            foreach (XmlNode curPkNode in pkNodes)
                            {
                                XmlElement cxe = (XmlElement)curPkNode;
                                curPk = new PKInfo();
                                curPk.PkId = cxe.GetAttribute("Ref");
                                pPks.Add(curPk);
                            }
                        }
                        break;
                }
            }
            return pPks;
        }

        private ColumnInfo GetPK(XmlNode xnKey, ColumnInfo pColumnInfo, TableInfo pTableInfo)
        {
            XmlElement xe = (XmlElement)xnKey;
            XmlNodeList xnKProperty = xe.ChildNodes;
            foreach (XmlNode xnP in xnKProperty)
            {
                switch (xnP.Name)
                {
                    case "c:Key.Columns":
                        {
                            ////获取当前节点的子节点 遍历获取主键的字段id
                            XmlNodeList pkNodes = xnP.ChildNodes;
                            foreach (XmlNode curPkNode in pkNodes)
                            {
                                XmlElement cxe = (XmlElement)curPkNode;
                                ColumnInfo col = pTableInfo.getColumnInfoByID(cxe.GetAttribute("Id"));
                                col.isPK = true;
                                return col;
                            }
                        }
                        break;
                }
            }
            return pColumnInfo;
        }



        private bool ConvertStringToBoolean(string curStr)
        {
            bool result = false;

            if (curStr.CompareTo("1") == 0)
            {
                result = true;
            }

            return result;
        }
    }

}
