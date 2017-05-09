using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) Entity类
    ///</summary>
    public class TrainingTeacherSummaryEntity
    {
        private int m_ID = 0; //-- ID
        private int m_TID = 0; //-- 总项目id
        private int m_SubTID = 0; //-- 阶段项目id
        private int m_Ttype = 0; //-- 总结类型：1.辅导老师工作总结 2.项目总结（挂在总项目下，教务的操作）
        private string m_TeacherSummaryTitle = string.Empty; //-- TeacherSummaryTitle
        private string m_TeacherSummaryContent = string.Empty; //-- TeacherSummaryContent
        private string m_StaticUrl = string.Empty; //-- 静态访问地址
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 发布时间
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingTeacherSummaryEntity(){ }
        public TrainingTeacherSummaryEntity(int ID,int TID,int SubTID,int Ttype,string TeacherSummaryTitle,string TeacherSummaryContent,string StaticUrl,int CreateBy,DateTime CreateTime,DateTime UpdateTime)
        {
            this.ID=ID;
            this.TID=TID;
            this.SubTID=SubTID;
            this.Ttype=Ttype;
            this.TeacherSummaryTitle=TeacherSummaryTitle;
            this.TeacherSummaryContent=TeacherSummaryContent;
            this.StaticUrl=StaticUrl;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateTime=UpdateTime;
        }

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