using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CoursePreset ( RH_CoursePreset ) Entity类
    ///</summary>
    public class CoursePresetEntity
    {
        private int m_ID = 0; //-- ID
        private string m_Name = string.Empty; //-- Name
        private string m_CPDesc = string.Empty; //-- CPDesc
        private int m_IfPromote = 0; //-- 是否提升 1-是 0-否
        private int m_IsRequired = 0; //-- 是否必修 1.是 2否
        private int m_CourseLevel = 0; //-- 能力提升课程等级 1.初级 2.中级 3，高级
        private int m_Dimension = 0; //-- 能力提升课程维度
        private int m_Version = 0; //-- 版本号
        private int m_parentID = 0; //-- 父套餐id，用于套餐复制
        private int m_Status = 0; //-- 状态：1-未发布 2-已发布 3 已删除
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime
        private int m_UpdateBy = 0; //-- UpdateBy
        private DateTime m_UpdateTime ; //-- UpdateTime

        public CoursePresetEntity(){ }
        public CoursePresetEntity(int ID,string Name,string CPDesc,int IfPromote,int IsRequired,int CourseLevel,int Dimension,int Version,int parentID,int Status,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.Name=Name;
            this.CPDesc=CPDesc;
            this.IfPromote=IfPromote;
            this.IsRequired=IsRequired;
            this.CourseLevel=CourseLevel;
            this.Dimension=Dimension;
            this.Version=Version;
            this.parentID=parentID;
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
        ///Name
        ///</summary>
        public string Name
        {
            set { m_Name = value;}
            get { return m_Name;}
        }

        ///<summary>
        ///CPDesc
        ///</summary>
        public string CPDesc
        {
            set { m_CPDesc = value;}
            get { return m_CPDesc;}
        }

        ///<summary>
        ///是否提升 1-是 0-否
        ///</summary>
        public int IfPromote
        {
            set { m_IfPromote = value;}
            get { return m_IfPromote;}
        }

        ///<summary>
        ///是否必修 1.是 2否
        ///</summary>
        public int IsRequired
        {
            set { m_IsRequired = value;}
            get { return m_IsRequired;}
        }

        ///<summary>
        ///能力提升课程等级 1.初级 2.中级 3，高级
        ///</summary>
        public int CourseLevel
        {
            set { m_CourseLevel = value;}
            get { return m_CourseLevel;}
        }

        ///<summary>
        ///能力提升课程维度
        ///</summary>
        public int Dimension
        {
            set { m_Dimension = value;}
            get { return m_Dimension;}
        }

        ///<summary>
        ///版本号
        ///</summary>
        public int Version
        {
            set { m_Version = value;}
            get { return m_Version;}
        }

        ///<summary>
        ///父套餐id，用于套餐复制
        ///</summary>
        public int parentID
        {
            set { m_parentID = value;}
            get { return m_parentID;}
        }

        ///<summary>
        ///状态：1-未发布 2-已发布 3 已删除
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