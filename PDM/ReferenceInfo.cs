using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReaderPDM.PDM
{
    //外键引用信息
    public class ReferenceInfo
    {
        public ReferenceInfo()
        {
        }
        string tableId;
        string objectID;
        string name;
        string code;
        int creationDate;
        string creator;
        int modificationDate;
        string modifier;
        string comment;
        string physicalOptions;

        string parentTableId;//父类表Id
        string childTableId;//子表Id

        string parentColumnId;//父表主键
        string childColumnId;//子表中外键


        public string TableId
        {
            get { return tableId; }
            set { tableId = value; }
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


        public string PhysicalOptions
        {
            get { return physicalOptions; }
            set { physicalOptions = value; }
        }

        
        /// <summary>
        /// 父类表Id
        /// </summary>
        public string ParentTableId
        {
            get { return parentTableId; }
            set { parentTableId = value; }
        }
        
        /// <summary>
        /// 子表Id
        /// </summary>
        public string ChildTableId
        {
            get { return childTableId; }
            set { childTableId = value; }
        }
        
        /// <summary>
        /// 父表主键
        /// </summary>
        public string ParentColumnId
        {
            get { return parentColumnId; }
            set { parentColumnId = value; }
        }
        
        /// <summary>
        /// 子表中外键
        /// </summary>
        public string ChildColumnId
        {
            get { return childColumnId; }
            set { childColumnId = value; }
        }
      
    }

}
