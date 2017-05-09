using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReaderPDM.PDM
{
    //主键信息
    [Serializable]
    public class PKInfo
    {
        public PKInfo() { }

        string pkId;

        public string PkId
        {
            get { return pkId; }
            set { pkId = value; }
        }
    }
}
