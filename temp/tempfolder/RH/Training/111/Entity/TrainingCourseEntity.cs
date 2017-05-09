using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingCourse ( RH_TrainingCourse ) Entity类
    ///</summary>
    public class TrainingCourseEntity
    {
        private int m_ID = 0; //-- ID
        private int m_PresetID = 0; //-- 预设ID
        private int m_SubTID = 0; //-- 子项目ID
        private int m_CourseID = 0; //-- CourseID
        private int m_IfRequired = 0; //-- 是否必修 1-是 0-否
        private int m_CPharse = 0; //-- 课程学时
        private int m_Sort = 0; //-- Sort
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingCourseEntity(){ }
        public TrainingCourseEntity(int ID,int PresetID,int SubTID,int CourseID,int IfRequired,int CPharse,int Sort,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.PresetID=PresetID;
            this.SubTID=SubTID;
            this.CourseID=CourseID;
            this.IfRequired=IfRequired;
            this.CPharse=CPharse;
            this.Sort=Sort;
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
        ///预设ID
        ///</summary>
        public int PresetID
        {
            set { m_PresetID = value;}
            get { return m_PresetID;}
        }

        ///<summary>
        ///子项目ID
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
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
        ///是否必修 1-是 0-否
        ///</summary>
        public int IfRequired
        {
            set { m_IfRequired = value;}
            get { return m_IfRequired;}
        }

        ///<summary>
        ///课程学时
        ///</summary>
        public int CPharse
        {
            set { m_CPharse = value;}
            get { return m_CPharse;}
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