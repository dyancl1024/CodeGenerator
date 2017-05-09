using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///DesignSuggestEntity 的摘要说明
    ///</summary>
    public class DesignSuggestMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="DesignSuggestEntity">designSuggestEntity;</returns>
        public static DesignSuggestEntity ParseDataRowToEntity(DataRow dataRow)
        {
           DesignSuggestEntity designSuggestEntity =new DesignSuggestEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              designSuggestEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //DesignID int
           if(dataRow["DesignID"].ToString() != "")
           {
              designSuggestEntity.DesignID = int.Parse(dataRow["DesignID"].ToString());
           }
           //DSuggest nvarchar(200)
           designSuggestEntity.DSuggest = dataRow["DSuggest"].ToString();
           //1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.立项（对应的动作分配教务） 5.不立项（对应的动作分配教务） int
           if(dataRow["Status"].ToString() != "")
           {
              designSuggestEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              designSuggestEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              designSuggestEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return designSuggestEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignSuggestEntity">objDesignSuggestEntity</returns>
        public static DesignSuggestEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           DesignSuggestEntity objDesignSuggestEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objDesignSuggestEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objDesignSuggestEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignSuggestEntity[]">arrayEntitys</returns>
        public static DesignSuggestEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           DesignSuggestEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new DesignSuggestEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    DesignSuggestEntity objDesignSuggestEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objDesignSuggestEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}