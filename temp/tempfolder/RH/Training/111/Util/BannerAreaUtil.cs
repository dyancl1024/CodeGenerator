using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///BannerAreaEntity 的摘要说明
    ///</summary>
    public class BannerAreaMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="BannerAreaEntity">bannerAreaEntity;</returns>
        public static BannerAreaEntity ParseDataRowToEntity(DataRow dataRow)
        {
           BannerAreaEntity bannerAreaEntity =new BannerAreaEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              bannerAreaEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //广告区域编码 varchar(50)
           bannerAreaEntity.AreaCode = dataRow["AreaCode"].ToString();
           //AreaName nvarchar(50)
           bannerAreaEntity.AreaName = dataRow["AreaName"].ToString();
           //AreaWidth int
           if(dataRow["AreaWidth"].ToString() != "")
           {
              bannerAreaEntity.AreaWidth = int.Parse(dataRow["AreaWidth"].ToString());
           }
           //AreaHight int
           if(dataRow["AreaHight"].ToString() != "")
           {
              bannerAreaEntity.AreaHight = int.Parse(dataRow["AreaHight"].ToString());
           }
           //区域位置:  1-主项目页面 2-阶段项目页面 3-学习页面 int
           if(dataRow["AreaType"].ToString() != "")
           {
              bannerAreaEntity.AreaType = int.Parse(dataRow["AreaType"].ToString());
           }
           //广告位置指示效果图 nvarchar(50)
           bannerAreaEntity.AreaPicUrl = dataRow["AreaPicUrl"].ToString();
           
           return bannerAreaEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="BannerAreaEntity">objBannerAreaEntity</returns>
        public static BannerAreaEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           BannerAreaEntity objBannerAreaEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objBannerAreaEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objBannerAreaEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="BannerAreaEntity[]">arrayEntitys</returns>
        public static BannerAreaEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           BannerAreaEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new BannerAreaEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    BannerAreaEntity objBannerAreaEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objBannerAreaEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}