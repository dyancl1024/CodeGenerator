using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReaderPDM.PDM
{
    //字段信息
    [Serializable]
    public class ColumnInfo
    {
        public ColumnInfo()
        { }

        string columnId = string.Empty;
        string objectID = string.Empty;
        string name = string.Empty;
        string code = string.Empty;
        int creationDate;
        string creator = string.Empty;
        int modificationDate;
        string modifier = string.Empty;
        string comment = string.Empty;
        string dataType;
        string length;
        bool identity; //是否自增量
        bool mandatory;  //禁止为空
        string extendedAttributesText = string.Empty; //扩展属性
        string physicalOptions = string.Empty;

        //主外键信息
        bool isPrimaryKey = false;
        bool isForeignKey = false;
        string fkTCode;//外键表code
        string fkTName;//外键表name
        string fkCCode;//外键列code


        public string ColumnId
        {
            get { return columnId; }
            set { columnId = value; }
        }

        public string ObjectID
        {
            get { return objectID; }
            set { objectID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public int CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }

        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        public int ModificationDate
        {
            get { return modificationDate; }
            set { modificationDate = value; }
        }

        public string Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }

        public string Length
        {
            get { return length; }
            set { length = value; }
        }

        public bool Identity
        {
            get { return identity; }
            set { identity = value; }
        }
        public bool Mandatory
        {
            get { return mandatory; }
            set { mandatory = value; }
        }
        public string ExtendedAttributesText
        {
            get { return extendedAttributesText; }
            set { extendedAttributesText = value; }
        }

        public string PhysicalOptions
        {
            get { return physicalOptions; }
            set { physicalOptions = value; }
        }

        /// <summary>
        /// 是否为主键
        /// </summary>
        public bool isPK
        {
            get { return isPrimaryKey; }
            set { isPrimaryKey = value; }
        }

        /// <summary>
        /// 是否为外键
        /// </summary>
        public bool isFK
        {
            get { return isForeignKey; }
            set { isForeignKey = value; }
        }

        /// <summary>
        /// 外键表code
        /// </summary>
        public string FK_TCode
        {
            get { return fkTCode; }
            set { fkTCode = value; }
        }

        /// <summary>
        /// 外键表name
        /// </summary>
        public string FK_TName
        {
            get { return fkTName; }
            set { fkTName = value; }
        }

        /// <summary>
        /// 外键列code
        /// </summary>
        public string FK_CCode
        {
            get { return fkCCode; }
            set { fkCCode = value; }
        }
    }
}
