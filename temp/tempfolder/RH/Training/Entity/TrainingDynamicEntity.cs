using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingDynamic ( RH_TrainingDynamic ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingDynamicEntity
    {
        private int m_ID = 0; 
        private int m_ObjectID = 0; 
        private int m_MType = 0; 
        private string m_DyTitle = string.Empty; 
        private int m_DyType = 0; 
        private string m_DyContent = string.Empty; 
        private string m_DyLink = string.Empty; 
        private string m_DyPicUrl = string.Empty; 
        private int m_DState = 0; 
        private int m_CilckNum = 0; 
        private string m_StaticUrl = string.Empty; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///社区ID
        ///</summary>
        public int ObjectID
        {
            set { m_ObjectID = value;}
            get { return m_ObjectID;}
        }

        ///<summary>
        ///类型：1.项目 2.班级
        ///</summary>
        public int MType
        {
            set { m_MType = value;}
            get { return m_MType;}
        }

        ///<summary>
        ///动态标题
        ///</summary>
        public string DyTitle
        {
            set { m_DyTitle = value;}
            get { return m_DyTitle;}
        }

        ///<summary>
        ///动态类型 1-文字 2-图片 3.链接类型 （无点击率）
        ///</summary>
        public int DyType
        {
            set { m_DyType = value;}
            get { return m_DyType;}
        }

        ///<summary>
        ///内容
        ///</summary>
        public string DyContent
        {
            set { m_DyContent = value;}
            get { return m_DyContent;}
        }

        ///<summary>
        ///当DyType为3链接时 存放link url
        ///</summary>
        public string DyLink
        {
            set { m_DyLink = value;}
            get { return m_DyLink;}
        }

        ///<summary>
        ///当DyType为2图片和图片广告4时 存放图片的 url
        ///</summary>
        public string DyPicUrl
        {
            set { m_DyPicUrl = value;}
            get { return m_DyPicUrl;}
        }

        ///<summary>
        ///动态状态 1-正常 2-删除
        ///</summary>
        public int DState
        {
            set { m_DState = value;}
            get { return m_DState;}
        }

        ///<summary>
        ///点击率
        ///</summary>
        public int CilckNum
        {
            set { m_CilckNum = value;}
            get { return m_CilckNum;}
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