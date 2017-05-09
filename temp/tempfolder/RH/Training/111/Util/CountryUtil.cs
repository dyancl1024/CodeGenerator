using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CountryEntity 的摘要说明
    ///</summary>
    public class CountryMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CountryEntity">countryEntity;</returns>
        public static CountryEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CountryEntity countryEntity =new CountryEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              countryEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //国家名 nvarchar(50)
           countryEntity.CountryName = dataRow["CountryName"].ToString();
           //国家拼音 nvarchar(50)
           countryEntity.CountryPY = dataRow["CountryPY"].ToString();
           
           return countryEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CountryEntity">objCountryEntity</returns>
        public static CountryEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CountryEntity objCountryEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCountryEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCountryEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CountryEntity[]">arrayEntitys</returns>
        public static CountryEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CountryEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CountryEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CountryEntity objCountryEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCountryEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}