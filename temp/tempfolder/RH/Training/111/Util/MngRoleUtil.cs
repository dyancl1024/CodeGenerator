using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///MngRoleEntity 的摘要说明
    ///</summary>
    public class MngRoleMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="MngRoleEntity">mngRoleEntity;</returns>
        public static MngRoleEntity ParseDataRowToEntity(DataRow dataRow)
        {
           MngRoleEntity mngRoleEntity =new MngRoleEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              mngRoleEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //角色名称 nvarchar(50)
           mngRoleEntity.RoleName = dataRow["RoleName"].ToString();
           //角色代码 nvarchar(50)
           mngRoleEntity.RoleCode = dataRow["RoleCode"].ToString();
           //角色排序 int
           if(dataRow["SortNum"].ToString() != "")
           {
              mngRoleEntity.SortNum = int.Parse(dataRow["SortNum"].ToString());
           }
           
           return mngRoleEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="MngRoleEntity">objMngRoleEntity</returns>
        public static MngRoleEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           MngRoleEntity objMngRoleEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objMngRoleEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objMngRoleEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="MngRoleEntity[]">arrayEntitys</returns>
        public static MngRoleEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           MngRoleEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new MngRoleEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    MngRoleEntity objMngRoleEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objMngRoleEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}