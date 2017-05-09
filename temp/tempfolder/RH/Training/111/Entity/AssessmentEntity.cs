using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Assessment ( RH_Assessment ) Entity类
    ///</summary>
    public class AssessmentEntity
    {
        private int m_ID = 0; //-- 主键
        private string m_AName = string.Empty; //-- 测评工具名称
        private string m_ADesc = string.Empty; //-- 评测描述
        private int m_Status = 0; //-- 0.未发布  1.已发布

        public AssessmentEntity(){ }
        public AssessmentEntity(int ID,string AName,string ADesc,int Status)
        {
            this.ID=ID;
            this.AName=AName;
            this.ADesc=ADesc;
            this.Status=Status;
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
        ///测评工具名称
        ///</summary>
        public string AName
        {
            set { m_AName = value;}
            get { return m_AName;}
        }

        ///<summary>
        ///评测描述
        ///</summary>
        public string ADesc
        {
            set { m_ADesc = value;}
            get { return m_ADesc;}
        }

        ///<summary>
        ///0.未发布  1.已发布
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

    }
}