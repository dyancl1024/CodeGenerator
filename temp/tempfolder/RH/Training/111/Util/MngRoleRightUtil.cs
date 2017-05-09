using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///MngRoleRightEntity 的摘要说明
    ///</summary>
    public class MngRoleRightMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="MngRoleRightEntity">mngRoleRightEntity;</returns>
        public static MngRoleRightEntity ParseDataRowToEntity(DataRow dataRow)
        {
           MngRoleRightEntity mngRoleRightEntity =new MngRoleRightEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              mngRoleRightEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //RoleCode varchar(50)
           mngRoleRightEntity.RoleCode = dataRow["RoleCode"].ToString();
           //菜单code  对应RH_MngMenu varchar(50)
           mngRoleRightEntity.MenuCode = dataRow["MenuCode"].ToString();
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              mngRoleRightEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              mngRoleRightEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return mngRoleRightEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="MngRoleRightEntity">objMngRoleRightEntity</returns>
        public static MngRoleRightEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           MngRoleRightEntity objMngRoleRightEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objMngRoleRightEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objMngRoleRightEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="MngRoleRightEntity[]">arrayEntitys</returns>
        public static MngRoleRightEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           MngRoleRightEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new MngRoleRightEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    MngRoleRightEntity objMngRoleRightEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objMngRoleRightEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}