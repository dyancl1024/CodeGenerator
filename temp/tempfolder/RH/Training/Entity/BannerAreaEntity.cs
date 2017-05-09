using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_BannerArea ( RH_BannerArea ) Entity类
    ///</summary>
    [Serializable]
    public class BannerAreaEntity
    {
        private int m_ID = 0; 
        private string m_AreaCode = string.Empty; 
        private string m_AreaName = string.Empty; 
        private int m_AreaWidth = 0; 
        private int m_AreaHight = 0; 
        private int m_AreaType = 0; 
        private string m_AreaPicUrl = string.Empty; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///广告区域编码
        ///</summary>
        public string AreaCode
        {
            set { m_AreaCode = value;}
            get { return m_AreaCode;}
        }

        ///<summary>
        ///AreaName
        ///</summary>
        public string AreaName
        {
            set { m_AreaName = value;}
            get { return m_AreaName;}
        }

        ///<summary>
        ///AreaWidth
        ///</summary>
        public int AreaWidth
        {
            set { m_AreaWidth = value;}
            get { return m_AreaWidth;}
        }

        ///<summary>
        ///AreaHight
        ///</summary>
        public int AreaHight
        {
            set { m_AreaHight = value;}
            get { return m_AreaHight;}
        }

        ///<summary>
        ///区域位置:  1-主项目页面 2-阶段项目页面 3-学习页面
        ///</summary>
        public int AreaType
        {
            set { m_AreaType = value;}
            get { return m_AreaType;}
        }

        ///<summary>
        ///广告位置指示效果图
        ///</summary>
        public string AreaPicUrl
        {
            set { m_AreaPicUrl = value;}
            get { return m_AreaPicUrl;}
        }

    }
}