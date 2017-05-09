using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReaderPDM.PDM
{
    //外键信息
    [Serializable]
    public class FKInfo
    {
        public FKInfo() { }

        string _pColumnId;//父级列id
        string _cColumnId;//子级列id
        string _pTableId;//父级id
        string _cTableId;//子级id
        string _pTableName;//父级table名称
        string _pTableCode;//父级table Code
        string _pTableShowCode;//父级table ShowCode
        string _pColumnCode;//父级列code
        string _cColumnCode;//子级列code

        /// <summary>
        /// 父级列id
        /// </summary>
        public string pColumnId
        {
            get { return _pColumnId; }
            set { _pColumnId = value; }
        }


        /// <summary>
        /// 子级列id
        /// </summary>
        public string cColumnId
        {
            get { return _cColumnId; }
            set { _cColumnId = value; }
        }

        /// <summary>
        /// 父级id
        /// </summary>
        public string pTableId
        {
            get { return _pTableId; }
            set { _pTableId = value; }
        }

        /// <summary>
        /// 子级id
        /// </summary>
        public string cTableId
        {
            get { return _cTableId; }
            set { _cTableId = value; }
        }

        /// <summary>
        /// 父级table名称
        /// </summary>
        public string pTableName
        {
            get { return _pTableName; }
            set { _pTableName = value; }
        }

        /// <summary>
        /// 父级table Code
        /// </summary>
        public string pTableCode
        {
            get { return _pTableCode; }
            set { _pTableCode = value; }
        }

        /// <summary>
        /// 父级列code
        /// </summary>
        public string pColumnCode
        {
            get { return _pColumnCode; }
            set { _pColumnCode = value; }
        }

        /// <summary>
        /// 子级列code
        /// </summary>
        public string cColumnCode
        {
            get { return _cColumnCode; }
            set { _cColumnCode = value; }
        }

        /// <summary>
        /// 父级table ShowCode
        /// </summary>
        public string pTableShowCode
        {
            get { return _pTableShowCode; }
            set { _pTableShowCode = value; }
        }

    }
}
