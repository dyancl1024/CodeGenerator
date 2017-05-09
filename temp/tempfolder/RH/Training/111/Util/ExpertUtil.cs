using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///ExpertEntity 的摘要说明
    ///</summary>
    public class ExpertMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="ExpertEntity">expertEntity;</returns>
        public static ExpertEntity ParseDataRowToEntity(DataRow dataRow)
        {
           ExpertEntity expertEntity =new ExpertEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              expertEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //UserID int
           if(dataRow["UserID"].ToString() != "")
           {
              expertEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              expertEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              expertEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return expertEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="ExpertEntity">objExpertEntity</returns>
        public static ExpertEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           ExpertEntity objExpertEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objExpertEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objExpertEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="ExpertEntity[]">arrayEntitys</returns>
        public static ExpertEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           ExpertEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new ExpertEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    ExpertEntity objExpertEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objExpertEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}