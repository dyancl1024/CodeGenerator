using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingCourse ( RH_TrainingCourse ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingCourseEntity
    {
        private int m_ID = 0; 
        private int m_PresetID = 0; 
        private int m_SubTID = 0; 
        private int m_CourseID = 0; 
        private int m_IfRequired = 0; 
        private int m_CPharse = 0; 
        private int m_Sort = 0; 
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