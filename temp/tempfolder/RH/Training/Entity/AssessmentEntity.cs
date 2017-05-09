using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Assessment ( RH_Assessment ) Entity类
    ///</summary>
    [Serializable]
    public class AssessmentEntity
    {
        private int m_ID = 0; 
        private string m_AName = string.Empty; 
        private string m_ADesc = string.Empty; 
        private int m_Status = 0; 

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