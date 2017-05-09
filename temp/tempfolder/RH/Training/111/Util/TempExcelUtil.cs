using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TempExcelEntity 的摘要说明
    ///</summary>
    public class TempExcelMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TempExcelEntity">tempExcelEntity;</returns>
        public static TempExcelEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TempExcelEntity tempExcelEntity =new TempExcelEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              tempExcelEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //FileExcel nvarchar(200)
           tempExcelEntity.FileExcel = dataRow["FileExcel"].ToString();
           //TableName nvarchar(200)
           tempExcelEntity.TableName = dataRow["TableName"].ToString();
           //TempRemark nvarchar(100)
           tempExcelEntity.TempRemark = dataRow["TempRemark"].ToString();
           
           return tempExcelEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TempExcelEntity">objTempExcelEntity</returns>
        public static TempExcelEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TempExcelEntity objTempExcelEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTempExcelEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTempExcelEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TempExcelEntity[]">arrayEntitys</returns>
        public static TempExcelEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TempExcelEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TempExcelEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TempExcelEntity objTempExcelEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTempExcelEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}