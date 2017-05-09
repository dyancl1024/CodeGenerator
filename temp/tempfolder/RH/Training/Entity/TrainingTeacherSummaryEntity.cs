using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingTeacherSummaryEntity
    {
        private int m_ID = 0; 
        private int m_TID = 0; 
        private int m_SubTID = 0; 
        private int m_Ttype = 0; 
        private string m_TeacherSummaryTitle = string.Empty; 
        private string m_TeacherSummaryContent = string.Empty; 
        private string m_StaticUrl = string.Empty; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
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
        ///总项目id
        ///</summary>
        public int TID
        {
            set { m_TID = value;}
            get { return m_TID;}
        }

        ///<summary>
        ///阶段项目id
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///总结类型：1.辅导老师工作总结 2.项目总结（挂在总项目下，教务的操作）
        ///</summary>
        public int Ttype
        {
            set { m_Ttype = value;}
            get { return m_Ttype;}
        }

        ///<summary>
        ///TeacherSummaryTitle
        ///</summary>
        public string TeacherSummaryTitle
        {
            set { m_TeacherSummaryTitle = value;}
            get { return m_TeacherSummaryTitle;}
        }

        ///<summary>
        ///TeacherSummaryContent
        ///</summary>
        public string TeacherSummaryContent
        {
            set { m_TeacherSummaryContent = value;}
            get { return m_TeacherSummaryContent;}
        }

        ///<summary>
        ///静态访问地址
        ///</summary>
        public string StaticUrl
        {
            set { m_StaticUrl = value;}
            get { return m_StaticUrl;}
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
        ///更新时间
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}