using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Banner ( RH_Banner ) Entity类
    ///</summary>
    [Serializable]
    public class BannerEntity
    {
        private int m_ID = 0; 
        private string m_ADTitle = string.Empty; 
        private string m_AreaCode = string.Empty; 
        private string m_ADPhotoUrl = string.Empty; 
        private int m_ADContentType = 0; 
        private string m_ADContentURL = string.Empty; 
        private string m_ADContent = string.Empty; 
        private int m_Status = 0; 
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
        ///AD标题
        ///</summary>
        public string ADTitle
        {
            set { m_ADTitle = value;}
            get { return m_ADTitle;}
        }

        ///<summary>
        ///区域： 1- 区域1（图片），2-区域2（图片）  3-区域3（图片） 4-区域4....
        ///</summary>
        public string AreaCode
        {
            set { m_AreaCode = value;}
            get { return m_AreaCode;}
        }

        ///<summary>
        ///上传广告图片URL(由区域决定是否为图片广告)
        ///</summary>
        public string ADPhotoUrl
        {
            set { m_ADPhotoUrl = value;}
            get { return m_ADPhotoUrl;}
        }

        ///<summary>
        ///广告内容形式  1-编辑内容  2-链接URL
        ///</summary>
        public int ADContentType
        {
            set { m_ADContentType = value;}
            get { return m_ADContentType;}
        }

        ///<summary>
        ///内容链接URL
        ///</summary>
        public string ADContentURL
        {
            set { m_ADContentURL = value;}
            get { return m_ADContentURL;}
        }

        ///<summary>
        ///AD内容(存放编辑的内容或链接URL)
        ///</summary>
        public string ADContent
        {
            set { m_ADContent = value;}
            get { return m_ADContent;}
        }

        ///<summary>
        ///1-未发布 2-已发布  3-删除
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
        ///创建时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

        ///<summary>
        ///修改人
        ///</summary>
        public int UpdateBy
        {
            set { m_UpdateBy = value;}
            get { return m_UpdateBy;}
        }

        ///<summary>
        ///修改时间
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}