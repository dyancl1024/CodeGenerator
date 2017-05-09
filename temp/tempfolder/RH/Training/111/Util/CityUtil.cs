using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CityEntity 的摘要说明
    ///</summary>
    public class CityMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CityEntity">cityEntity;</returns>
        public static CityEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CityEntity cityEntity =new CityEntity();

           //id int
           if(dataRow["id"].ToString() != "")
           {
              cityEntity.id = int.Parse(dataRow["id"].ToString());
           }
           //CityName nvarchar(50)
           cityEntity.CityName = dataRow["CityName"].ToString();
           //CityPY varchar(50)
           cityEntity.CityPY = dataRow["CityPY"].ToString();
           //ProvinceID int
           if(dataRow["ProvinceID"].ToString() != "")
           {
              cityEntity.ProvinceID = int.Parse(dataRow["ProvinceID"].ToString());
           }
           
           return cityEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CityEntity">objCityEntity</returns>
        public static CityEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CityEntity objCityEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCityEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCityEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CityEntity[]">arrayEntitys</returns>
        public static CityEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CityEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CityEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CityEntity objCityEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCityEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}