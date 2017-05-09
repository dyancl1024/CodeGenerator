using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///BannerEntity 的摘要说明
    ///</summary>
    public class BannerMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="BannerEntity">bannerEntity;</returns>
        public static BannerEntity ParseDataRowToEntity(DataRow dataRow)
        {
           BannerEntity bannerEntity =new BannerEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              bannerEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //AD标题 nvarchar(200)
           bannerEntity.ADTitle = dataRow["ADTitle"].ToString();
           //区域： 1- 区域1（图片），2-区域2（图片）  3-区域3（图片） 4-区域4.... varchar(50)
           bannerEntity.AreaCode = dataRow["AreaCode"].ToString();
           //上传广告图片URL(由区域决定是否为图片广告) nvarchar(200)
           bannerEntity.ADPhotoUrl = dataRow["ADPhotoUrl"].ToString();
           //广告内容形式  1-编辑内容  2-链接URL int
           if(dataRow["ADContentType"].ToString() != "")
           {
              bannerEntity.ADContentType = int.Parse(dataRow["ADContentType"].ToString());
           }
           //内容链接URL nvarchar(200)
           bannerEntity.ADContentURL = dataRow["ADContentURL"].ToString();
           //AD内容(存放编辑的内容或链接URL) nvarchar(Max)
           bannerEntity.ADContent = dataRow["ADContent"].ToString();
           //1-未发布 2-已发布  3-删除 int
           if(dataRow["Status"].ToString() != "")
           {
              bannerEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              bannerEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              bannerEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //修改人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              bannerEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //修改时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              bannerEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return bannerEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="BannerEntity">objBannerEntity</returns>
        public static BannerEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           BannerEntity objBannerEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objBannerEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objBannerEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="BannerEntity[]">arrayEntitys</returns>
        public static BannerEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           BannerEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new BannerEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    BannerEntity objBannerEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objBannerEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}