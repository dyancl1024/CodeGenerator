using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReaderPDM.PDM
{
    //表信息

    [Serializable]
    public class TableInfo
    {
        public TableInfo()
        {
        }
        string tableId=string.Empty;
        string objectID = string.Empty;
        string name = string.Empty;
        string code = string.Empty;
        int creationDate;
        string creator = string.Empty;
        int modificationDate;
        string modifier = string.Empty;
        string comment = string.Empty;
        string physicalOptions = string.Empty;

        string strNameSpace;


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


        IList<ColumnInfo> columns;

        public IList<ColumnInfo> Columns
        {
            get { return columns; }
        }

        IList<PdmKey> keys;

        public IList<PdmKey> Keys
        {
            get { return keys; }
        }

        IList<PKInfo> pkkeys;

        public IList<PKInfo> PKInfos
        {
            get { return pkkeys; }
        }

        IList<FKInfo> fkkeys;

        public IList<FKInfo> FKInfos
        {
            get { return fkkeys; }
        }

        public void AddColumn(ColumnInfo mColumn)
        {
            if (columns == null)
                columns = new List<ColumnInfo>();
            columns.Add(mColumn);
        }

        public void AddKey(PdmKey mKey)
        {
            if (keys == null)
                keys = new List<PdmKey>();
            keys.Add(mKey);
        }

        public void AddKeys(List<PdmKey> mKeys)
        {
            if (keys == null)
                keys = new List<PdmKey>();
            for (int i = 0; i < mKeys.Count; i++)
            {
                keys.Add(mKeys[i]);
            }
        }

        public void AddPK(PKInfo mPK)
        {
            if (pkkeys == null)
                pkkeys = new List<PKInfo>();
            pkkeys.Add(mPK);
        }

        public void AddPK(List<PKInfo> mKeys)
        {
            if (pkkeys == null)
                pkkeys = new List<PKInfo>();
            for (int i = 0; i < mKeys.Count; i++)
            {
                pkkeys.Add(mKeys[i]);
            }
        }

        public void AddFK(FKInfo mFK)
        {
            if (fkkeys == null)
                fkkeys = new List<FKInfo>();
            fkkeys.Add(mFK);
        }

        public string nameSpace
        {
            get { return strNameSpace; }
            set { strNameSpace = value; }
        }

        /// <summary>
        /// 根据列id返回列对象
        /// </summary>
        /// <param name="columnInfoId"></param>
        /// <returns></returns>
        public ColumnInfo getColumnInfoByID(string columnInfoId)
        {
            ColumnInfo curCol = new ColumnInfo();

            if (columns != null)
            {
                for (int i = 0; i < columns.Count; i++)
                {
                    if (columnInfoId.Equals(columns[i].ColumnId))
                    {
                        return columns[i];
                    }
                }
            }
            return curCol;
        }

        /// <summary>
        /// 修改Table的Column信息
        /// </summary>
        /// <param name="columnInfoId"></param>
        /// <param name="paramColumnInfo"></param>
        public TableInfo UpdateColumnInfoByID(string columnInfoId, ColumnInfo paramColumnInfo, TableInfo pTableInfo)
        {
            if (pTableInfo.Columns != null)
            {
                for (int i = 0; i < pTableInfo.Columns.Count; i++)
                {
                    if (columnInfoId.Equals(pTableInfo.Columns[i].ColumnId))
                    {
                        pTableInfo.Columns[i] = paramColumnInfo;
                    }
                }
            }
            return pTableInfo;
        }

    }
}
