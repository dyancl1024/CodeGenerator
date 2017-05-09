using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingClass ( RH_TrainingClass ) Entity类
    ///</summary>
    public class TrainingClassEntity
    {
        private int m_ID = 0; //-- 主键
        private int m_SubTID = 0; //-- 项目id
        private int m_ClassNO = 0; //-- 班号
        private string m_CName = string.Empty; //-- 班级名称
        private string m_SubjectCode = string.Empty; //-- 学科id
        private string m_GradeCode = string.Empty; //-- 学段id
        private string m_StaticUrl = string.Empty; //-- StaticUrl
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 发布时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingClassEntity(){ }
        public TrainingClassEntity(int ID,int SubTID,int ClassNO,string CName,string SubjectCode,string GradeCode,string StaticUrl,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.ClassNO=ClassNO;
            this.CName=CName;
            this.SubjectCode=SubjectCode;
            this.GradeCode=GradeCode;
            this.StaticUrl=StaticUrl;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
        }

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///项目id
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///班号
        ///</summary>
        public int ClassNO
        {
            set { m_ClassNO = value;}
            get { return m_ClassNO;}
        }

        ///<summary>
        ///班级名称
        ///</summary>
        public string CName
        {
            set { m_CName = value;}
            get { return m_CName;}
        }

        ///<summary>
        ///学科id
        ///</summary>
        public string SubjectCode
        {
            set { m_SubjectCode = value;}
            get { return m_SubjectCode;}
        }

        ///<summary>
        ///学段id
        ///</summary>
        public string GradeCode
        {
            set { m_GradeCode = value;}
            get { return m_GradeCode;}
        }

        ///<summary>
        ///StaticUrl
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

    }
}