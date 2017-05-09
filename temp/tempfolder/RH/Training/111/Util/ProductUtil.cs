using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///ProductEntity 的摘要说明
    ///</summary>
    public class ProductMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="ProductEntity">productEntity;</returns>
        public static ProductEntity ParseDataRowToEntity(DataRow dataRow)
        {
           ProductEntity productEntity =new ProductEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              productEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //ProductName nvarchar(50)
           productEntity.ProductName = dataRow["ProductName"].ToString();
           //ProductCode varchar(50)
           productEntity.ProductCode = dataRow["ProductCode"].ToString();
           //产品级别 1.省 2. 市 3.区县 int
           if(dataRow["ProductLevel"].ToString() != "")
           {
              productEntity.ProductLevel = int.Parse(dataRow["ProductLevel"].ToString());
           }
           //ProductUrl nvarchar(50)
           productEntity.ProductUrl = dataRow["ProductUrl"].ToString();
           //1.正常 2.删除 int
           if(dataRow["Status"].ToString() != "")
           {
              productEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //ProvinceID int
           if(dataRow["ProvinceID"].ToString() != "")
           {
              productEntity.ProvinceID = int.Parse(dataRow["ProvinceID"].ToString());
           }
           //CityID int
           if(dataRow["CityID"].ToString() != "")
           {
              productEntity.CityID = int.Parse(dataRow["CityID"].ToString());
           }
           //DistrictID int
           if(dataRow["DistrictID"].ToString() != "")
           {
              productEntity.DistrictID = int.Parse(dataRow["DistrictID"].ToString());
           }
           //StaticUrl nvarchar(200)
           productEntity.StaticUrl = dataRow["StaticUrl"].ToString();
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              productEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              productEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //UpdateBy int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              productEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //UpdateTime datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              productEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return productEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="ProductEntity">objProductEntity</returns>
        public static ProductEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           ProductEntity objProductEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objProductEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objProductEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="ProductEntity[]">arrayEntitys</returns>
        public static ProductEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           ProductEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new ProductEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    ProductEntity objProductEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objProductEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}