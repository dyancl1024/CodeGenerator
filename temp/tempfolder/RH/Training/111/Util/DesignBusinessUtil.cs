using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///DesignBusinessEntity 的摘要说明
    ///</summary>
    public class DesignBusinessMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="DesignBusinessEntity">designBusinessEntity;</returns>
        public static DesignBusinessEntity ParseDataRowToEntity(DataRow dataRow)
        {
           DesignBusinessEntity designBusinessEntity =new DesignBusinessEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              designBusinessEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //DesignID int
           if(dataRow["DesignID"].ToString() != "")
           {
              designBusinessEntity.DesignID = int.Parse(dataRow["DesignID"].ToString());
           }
           //UserID int
           if(dataRow["UserID"].ToString() != "")
           {
              designBusinessEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              designBusinessEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              designBusinessEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return designBusinessEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignBusinessEntity">objDesignBusinessEntity</returns>
        public static DesignBusinessEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           DesignBusinessEntity objDesignBusinessEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objDesignBusinessEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objDesignBusinessEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignBusinessEntity[]">arrayEntitys</returns>
        public static DesignBusinessEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           DesignBusinessEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new DesignBusinessEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    DesignBusinessEntity objDesignBusinessEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objDesignBusinessEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}