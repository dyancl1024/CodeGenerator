using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) Entity类
    ///</summary>
    public class CoursePreSetListEntity
    {
        private int m_ID = 0; //-- ID
        private int m_PreSetID = 0; //-- PreSetID
        private int m_CourseID = 0; //-- CourseID

        public CoursePreSetListEntity(){ }
        public CoursePreSetListEntity(int ID,int PreSetID,int CourseID)
        {
            this.ID=ID;
            this.PreSetID=PreSetID;
            this.CourseID=CourseID;
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
        ///PreSetID
        ///</summary>
        public int PreSetID
        {
            set { m_PreSetID = value;}
            get { return m_PreSetID;}
        }

        ///<summary>
        ///CourseID
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
        }

    }
}