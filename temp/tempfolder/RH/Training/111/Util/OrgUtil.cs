using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///OrgEntity 的摘要说明
    ///</summary>
    public class OrgMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="OrgEntity">orgEntity;</returns>
        public static OrgEntity ParseDataRowToEntity(DataRow dataRow)
        {
           OrgEntity orgEntity =new OrgEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              orgEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //承担机构名称 nvarchar(50)
           orgEntity.Name = dataRow["Name"].ToString();
           //机构状态 1-正常 0-删除 varchar(50)
           orgEntity.Code = dataRow["Code"].ToString();
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              orgEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           //1:正常 2.删除 int
           if(dataRow["Status"].ToString() != "")
           {
              orgEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           
           return orgEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="OrgEntity">objOrgEntity</returns>
        public static OrgEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           OrgEntity objOrgEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objOrgEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objOrgEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="OrgEntity[]">arrayEntitys</returns>
        public static OrgEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           OrgEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new OrgEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    OrgEntity objOrgEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objOrgEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}