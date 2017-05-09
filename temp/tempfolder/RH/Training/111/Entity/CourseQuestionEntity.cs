using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseQuestion ( RH_CourseQuestion ) Entity类
    ///</summary>
    public class CourseQuestionEntity
    {
        private int m_ID = 0; //-- ID
        private int m_CourseID = 0; //-- CourseID
        private string m_Question = string.Empty; //-- Question
        private int m_QType = 0; //-- 1单选2多选3判断
        private int m_Sort = 0; //-- Sort
        private int m_Status = 0; //-- 状态 1-未发布 2-已发布 3-删除
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public CourseQuestionEntity(){ }
        public CourseQuestionEntity(int ID,int CourseID,string Question,int QType,int Sort,int Status,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.CourseID=CourseID;
            this.Question=Question;
            this.QType=QType;
            this.Sort=Sort;
            this.Status=Status;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
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
        ///CourseID
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
        }

        ///<summary>
        ///Question
        ///</summary>
        public string Question
        {
            set { m_Question = value;}
            get { return m_Question;}
        }

        ///<summary>
        ///1单选2多选3判断
        ///</summary>
        public int QType
        {
            set { m_QType = value;}
            get { return m_QType;}
        }

        ///<summary>
        ///Sort
        ///</summary>
        public int Sort
        {
            set { m_Sort = value;}
            get { return m_Sort;}
        }

        ///<summary>
        ///状态 1-未发布 2-已发布 3-删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
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
        ///创建时间
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