using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingSub ( RH_TrainingSub ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingSubEntity
    {
        private int m_ID = 0; 
        private int m_TID = 0; 
        private string m_TName = string.Empty; 
        private int m_TrainingNum = 0; 
        private string m_TrainingLevelCode = string.Empty; 
        private string m_TrainingTypeCode = string.Empty; 
        private int m_TMethod = 0; 
        private int m_IsGP = 0; 
        private string m_OrgCode = string.Empty; 
        private DateTime m_TrainingDateB ; 
        private DateTime m_TrainingDateE ; 
        private int m_SignupRule = 0; 
        private char m_ClassRule ; 
        private int m_IsStage = 0; 
        private string m_TrainingUrl = string.Empty; 
        private string m_TrainingHeadImg = string.Empty; 
        private string m_StaticUrl = string.Empty; 
        private int m_Status = 0; 
        private string m_AskTel = string.Empty; 
        private int m_IsShowQQ = 0; 
        private int m_TestMethod = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 
        private int m_Publisher = 0; 
        private DateTime m_PublishDate ; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///主项目ID
        ///</summary>
        public int TID
        {
            set { m_TID = value;}
            get { return m_TID;}
        }

        ///<summary>
        ///项目名称
        ///</summary>
        public string TName
        {
            set { m_TName = value;}
            get { return m_TName;}
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
        ///研修方式：1.网络培训 2.现场培训 3.能力提升
        ///</summary>
        public int TMethod
        {
            set { m_TMethod = value;}
            get { return m_TMethod;}
        }

        ///<summary>
        ///是否国培 1 是 2 否
        ///</summary>
        public int IsGP
        {
            set { m_IsGP = value;}
            get { return m_IsGP;}
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
        ///报名规则：1.导入报名 2.自主报名
        ///</summary>
        public int SignupRule
        {
            set { m_SignupRule = value;}
            get { return m_SignupRule;}
        }

        ///<summary>
        ///分班规则：1.规则分班 2.人工分班
        ///</summary>
        public char ClassRule
        {
            set { m_ClassRule = value;}
            get { return m_ClassRule;}
        }

        ///<summary>
        ///是否阶段项目 1 是 2 否
        ///</summary>
        public int IsStage
        {
            set { m_IsStage = value;}
            get { return m_IsStage;}
        }

        ///<summary>
        ///TrainingUrl
        ///</summary>
        public string TrainingUrl
        {
            set { m_TrainingUrl = value;}
            get { return m_TrainingUrl;}
        }

        ///<summary>
        ///TrainingHeadImg
        ///</summary>
        public string TrainingHeadImg
        {
            set { m_TrainingHeadImg = value;}
            get { return m_TrainingHeadImg;}
        }

        ///<summary>
        ///StaticUrl
        ///</summary>
        public string StaticUrl
        {
            set { m_StaticUrl = value;}
            get { return m_StaticUrl;}
        }

        ///<summary>
        ///1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

        ///<summary>
        ///咨询电话
        ///</summary>
        public string AskTel
        {
            set { m_AskTel = value;}
            get { return m_AskTel;}
        }

        ///<summary>
        ///是否显示在线客服 1 是 2 否
        ///</summary>
        public int IsShowQQ
        {
            set { m_IsShowQQ = value;}
            get { return m_IsShowQQ;}
        }

        ///<summary>
        ///测评工具 1内部 2外部
        ///</summary>
        public int TestMethod
        {
            set { m_TestMethod = value;}
            get { return m_TestMethod;}
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

        ///<summary>
        ///发布人
        ///</summary>
        public int Publisher
        {
            set { m_Publisher = value;}
            get { return m_Publisher;}
        }

        ///<summary>
        ///发布时间
        ///</summary>
        public DateTime PublishDate
        {
            set { m_PublishDate = value;}
            get { return m_PublishDate;}
        }

    }
}