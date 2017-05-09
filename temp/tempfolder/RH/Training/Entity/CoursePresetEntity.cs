using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CoursePreset ( RH_CoursePreset ) Entity类
    ///</summary>
    [Serializable]
    public class CoursePresetEntity
    {
        private int m_ID = 0; 
        private string m_Name = string.Empty; 
        private string m_CPDesc = string.Empty; 
        private int m_IfPromote = 0; 
        private int m_IsRequired = 0; 
        private int m_CourseLevel = 0; 
        private int m_Dimension = 0; 
        private int m_Version = 0; 
        private int m_parentID = 0; 
        private int m_Status = 0; 
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