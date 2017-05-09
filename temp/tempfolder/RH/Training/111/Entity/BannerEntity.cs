using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Banner ( RH_Banner ) Entity类
    ///</summary>
    public class BannerEntity
    {
        private int m_ID = 0; //-- 主键
        private string m_ADTitle = string.Empty; //-- AD标题
        private string m_AreaCode = string.Empty; //-- 区域： 1- 区域1（图片），2-区域2（图片）  3-区域3（图片） 4-区域4....
        private string m_ADPhotoUrl = string.Empty; //-- 上传广告图片URL(由区域决定是否为图片广告)
        private int m_ADContentType = 0; //-- 广告内容形式  1-编辑内容  2-链接URL
        private string m_ADContentURL = string.Empty; //-- 内容链接URL
        private string m_ADContent = string.Empty; //-- AD内容(存放编辑的内容或链接URL)
        private int m_Status = 0; //-- 1-未发布 2-已发布  3-删除
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 修改人
        private DateTime m_UpdateTime ; //-- 修改时间

        public BannerEntity(){ }
        public BannerEntity(int ID,string ADTitle,string AreaCode,string ADPhotoUrl,int ADContentType,string ADContentURL,string ADContent,int Status,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.ADTitle=ADTitle;
            this.AreaCode=AreaCode;
            this.ADPhotoUrl=ADPhotoUrl;
            this.ADContentType=ADContentType;
            this.ADContentURL=ADContentURL;
            this.ADContent=ADContent;
            this.Status=Status;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
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