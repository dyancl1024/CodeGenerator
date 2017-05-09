using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingBriefingEntity
    {
        private int m_ID = 0; 
        private int m_ObjectID = 0; 
        private int m_MType = 0; 
        private string m_Periods = string.Empty; 
        private string m_Title = string.Empty; 
        private string m_BContnet = string.Empty; 
        private int m_ClickNum = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 
        private string m_StaticUrl = string.Empty; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///项目id
        ///</summary>
        public int ObjectID
        {
            set { m_ObjectID = value;}
            get { return m_ObjectID;}
        }

        ///<summary>
        ///1.项目 2.班级
        ///</summary>
        public int MType
        {
            set { m_MType = value;}
            get { return m_MType;}
        }

        ///<summary>
        ///期数 录入
        ///</summary>
        public string Periods
        {
            set { m_Periods = value;}
            get { return m_Periods;}
        }

        ///<summary>
        ///标题
        ///</summary>
        public string Title
        {
            set { m_Title = value;}
            get { return m_Title;}
        }

        ///<summary>
        ///内容
        ///</summary>
        public string BContnet
        {
            set { m_BContnet = value;}
            get { return m_BContnet;}
        }

        ///<summary>
        ///ClickNum
        ///</summary>
        public int ClickNum
        {
            set { m_ClickNum = value;}
            get { return m_ClickNum;}
        }

        ///<summary>
        ///创建人
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///发布时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

        ///<summary>
        ///更新人
        ///</summary>
        public int UpdateBy
        {
            set { m_UpdateBy = value;}
            get { return m_UpdateBy;}
        }

        ///<summary>
        ///更新时间
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

        ///<summary>
        ///StaticUrl
        ///</summary>
        public string StaticUrl
        {
            set { m_StaticUrl = value;}
            get { return m_StaticUrl;}
        }

    }
}