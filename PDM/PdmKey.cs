using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReaderPDM.PDM
{
    //主键类
    [Serializable]
    public class PdmKey
    {
        public PdmKey()
        {
        }

        string keyId;
        string objectID;
        string name;
        string code;
        int creationDate;
        string creator;
        int modificationDate;
        string modifier;

        public string KeyId
        {
            get { return keyId; }
            set { keyId = value; }
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

        IList<ColumnInfo> columns;

        public IList<ColumnInfo> Columns
        {
            get { return columns; }
        }

        public void AddColumn(ColumnInfo mColumn)
        {
            if (columns == null)
                columns = new List<ColumnInfo>();
            columns.Add(mColumn);
        }
    }

}
