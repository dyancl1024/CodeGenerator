using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingType ( RH_TrainingType ) Entity类
    ///</summary>
    public class TrainingTypeEntity
    {
        private int m_ID = 0; //-- ID
        private string m_Name = string.Empty; //-- Name
        private string m_Code = string.Empty; //-- Code
        private int m_Sort = 0; //-- Sort

        public TrainingTypeEntity(){ }
        public TrainingTypeEntity(int ID,string Name,string Code,int Sort)
        {
            this.ID=ID;
            this.Name=Name;
            this.Code=Code;
            this.Sort=Sort;
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
        ///Code
        ///</summary>
        public string Code
        {
            set { m_Code = value;}
            get { return m_Code;}
        }

        ///<summary>
        ///Sort
        ///</summary>
        public int Sort
        {
            set { m_Sort = value;}
            get { return m_Sort;}
        }

    }
}