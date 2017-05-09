using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_DesignSuggest ( RH_DesignSuggest ) Entity类
    ///</summary>
    [Serializable]
    public class DesignSuggestEntity
    {
        private int m_ID = 0; 
        private int m_DesignID = 0; 
        private string m_DSuggest = string.Empty; 
        private int m_Status = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///DesignID
        ///</summary>
        public int DesignID
        {
            set { m_DesignID = value;}
            get { return m_DesignID;}
        }

        ///<summary>
        ///DSuggest
        ///</summary>
        public string DSuggest
        {
            set { m_DSuggest = value;}
            get { return m_DSuggest;}
        }

        ///<summary>
        ///1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.立项（对应的动作分配教务） 5.不立项（对应的动作分配教务）
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

        ///<summary>
        ///CreateBy
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///CreateTime
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}