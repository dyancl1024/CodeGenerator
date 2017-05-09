using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_DesignContent ( RH_DesignContent ) Entity类
    ///</summary>
    [Serializable]
    public class DesignContentEntity
    {
        private int m_ID = 0; 
        private int m_DesignID = 0; 
        private int m_DType = 0; 
        private string m_DName = string.Empty; 
        private string m_DContent = string.Empty; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 

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
        ///1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书
        ///</summary>
        public int DType
        {
            set { m_DType = value;}
            get { return m_DType;}
        }

        ///<summary>
        ///1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书
        ///</summary>
        public string DName
        {
            set { m_DName = value;}
            get { return m_DName;}
        }

        ///<summary>
        ///DContent
        ///</summary>
        public string DContent
        {
            set { m_DContent = value;}
            get { return m_DContent;}
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

        ///<summary>
        ///UpdateBy
        ///</summary>
        public int UpdateBy
        {
            set { m_UpdateBy = value;}
            get { return m_UpdateBy;}
        }

        ///<summary>
        ///UpdateTime
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}