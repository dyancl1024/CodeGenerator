using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///DistrictEntity 的摘要说明
    ///</summary>
    public class DistrictMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="DistrictEntity">districtEntity;</returns>
        public static DistrictEntity ParseDataRowToEntity(DataRow dataRow)
        {
           DistrictEntity districtEntity =new DistrictEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              districtEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //DistrictName nvarchar(50)
           districtEntity.DistrictName = dataRow["DistrictName"].ToString();
           //DistrictPY varchar(50)
           districtEntity.DistrictPY = dataRow["DistrictPY"].ToString();
           //CityID int
           if(dataRow["CityID"].ToString() != "")
           {
              districtEntity.CityID = int.Parse(dataRow["CityID"].ToString());
           }
           
           return districtEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DistrictEntity">objDistrictEntity</returns>
        public static DistrictEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           DistrictEntity objDistrictEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objDistrictEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objDistrictEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DistrictEntity[]">arrayEntitys</returns>
        public static DistrictEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           DistrictEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new DistrictEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    DistrictEntity objDistrictEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objDistrictEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}