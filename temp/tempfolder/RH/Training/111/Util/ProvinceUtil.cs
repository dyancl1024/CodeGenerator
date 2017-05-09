using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///ProvinceEntity 的摘要说明
    ///</summary>
    public class ProvinceMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="ProvinceEntity">provinceEntity;</returns>
        public static ProvinceEntity ParseDataRowToEntity(DataRow dataRow)
        {
           ProvinceEntity provinceEntity =new ProvinceEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              provinceEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //ProvinceName nvarchar(50)
           provinceEntity.ProvinceName = dataRow["ProvinceName"].ToString();
           //ProvincePY varchar(50)
           provinceEntity.ProvincePY = dataRow["ProvincePY"].ToString();
           //CountyID int
           if(dataRow["CountyID"].ToString() != "")
           {
              provinceEntity.CountyID = int.Parse(dataRow["CountyID"].ToString());
           }
           //Status int
           if(dataRow["Status"].ToString() != "")
           {
              provinceEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           
           return provinceEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="ProvinceEntity">objProvinceEntity</returns>
        public static ProvinceEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           ProvinceEntity objProvinceEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objProvinceEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objProvinceEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="ProvinceEntity[]">arrayEntitys</returns>
        public static ProvinceEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           ProvinceEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new ProvinceEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    ProvinceEntity objProvinceEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objProvinceEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}