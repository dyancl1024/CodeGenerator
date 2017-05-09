using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///BannerObjectEntity 的摘要说明
    ///</summary>
    public class BannerObjectMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="BannerObjectEntity">bannerObjectEntity;</returns>
        public static BannerObjectEntity ParseDataRowToEntity(DataRow dataRow)
        {
           BannerObjectEntity bannerObjectEntity =new BannerObjectEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              bannerObjectEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //BannerID int
           if(dataRow["BannerID"].ToString() != "")
           {
              bannerObjectEntity.BannerID = int.Parse(dataRow["BannerID"].ToString());
           }
           //ObjectID int
           if(dataRow["ObjectID"].ToString() != "")
           {
              bannerObjectEntity.ObjectID = int.Parse(dataRow["ObjectID"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              bannerObjectEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              bannerObjectEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return bannerObjectEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="BannerObjectEntity">objBannerObjectEntity</returns>
        public static BannerObjectEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           BannerObjectEntity objBannerObjectEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objBannerObjectEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objBannerObjectEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="BannerObjectEntity[]">arrayEntitys</returns>
        public static BannerObjectEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           BannerObjectEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new BannerObjectEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    BannerObjectEntity objBannerObjectEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objBannerObjectEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}