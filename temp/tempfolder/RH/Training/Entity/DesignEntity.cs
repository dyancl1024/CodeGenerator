using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Design ( RH_Design ) Entity类
    ///</summary>
    [Serializable]
    public class DesignEntity
    {
        private int m_ID = 0; 
        private string m_DesignName = string.Empty; 
        private string m_TrainingLevelCode = string.Empty; 
        private string m_TrainingTypeCode = string.Empty; 
        private int m_ProvinceID = 0; 
        private int m_CityID = 0; 
        private int m_DistrictID = 0; 
        private string m_OrgCode = string.Empty; 
        private int m_TrainingNum = 0; 
        private int m_TrainingPhase = 0; 
        private DateTime m_TrainingDateB ; 
        private DateTime m_TrainingDateE ; 
        private string m_DesignDesc = string.Empty; 
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
        ///社区id
        ///</summary>
        public string DesignName
        {
            set { m_DesignName = value;}
            get { return m_DesignName;}
        }

        ///<summary>
        ///承担机构id 对应表FJ_TrainingOrg的ID
        ///</summary>
        public string TrainingLevelCode
        {
            set { m_TrainingLevelCode = value;}
            get { return m_TrainingLevelCode;}
        }

        ///<summary>
        ///TrainingTypeCode
        ///</summary>
        public string TrainingTypeCode
        {
            set { m_TrainingTypeCode = value;}
            get { return m_TrainingTypeCode;}
        }

        ///<summary>
        ///ProvinceID
        ///</summary>
        public int ProvinceID
        {
            set { m_ProvinceID = value;}
            get { return m_ProvinceID;}
        }

        ///<summary>
        ///CityID
        ///</summary>
        public int CityID
        {
            set { m_CityID = value;}
            get { return m_CityID;}
        }

        ///<summary>
        ///DistrictID
        ///</summary>
        public int DistrictID
        {
            set { m_DistrictID = value;}
            get { return m_DistrictID;}
        }

        ///<summary>
        ///OrgCode
        ///</summary>
        public string OrgCode
        {
            set { m_OrgCode = value;}
            get { return m_OrgCode;}
        }

        ///<summary>
        ///项目名称
        ///</summary>
        public int TrainingNum
        {
            set { m_TrainingNum = value;}
            get { return m_TrainingNum;}
        }

        ///<summary>
        ///学时
        ///</summary>
        public int TrainingPhase
        {
            set { m_TrainingPhase = value;}
            get { return m_TrainingPhase;}
        }

        ///<summary>
        ///时间安排起
        ///</summary>
        public DateTime TrainingDateB
        {
            set { m_TrainingDateB = value;}
            get { return m_TrainingDateB;}
        }

        ///<summary>
        ///时间安排止
        ///</summary>
        public DateTime TrainingDateE
        {
            set { m_TrainingDateE = value;}
            get { return m_TrainingDateE;}
        }

        ///<summary>
        ///DesignDesc
        ///</summary>
        public string DesignDesc
        {
            set { m_DesignDesc = value;}
            get { return m_DesignDesc;}
        }

        ///<summary>
        ///1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.不通过（对应的动作提交审批） 5.立项（对应的动作分配教务） 6.不立项（对应的动作分配教务）
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
        ///CreateTime
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
        ///UpdateTime
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}