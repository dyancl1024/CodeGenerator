using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///MngMenuEntity 的摘要说明
    ///</summary>
    public class MngMenuMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="MngMenuEntity">mngMenuEntity;</returns>
        public static MngMenuEntity ParseDataRowToEntity(DataRow dataRow)
        {
           MngMenuEntity mngMenuEntity =new MngMenuEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              mngMenuEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //菜单名字 nvarchar(50)
           mngMenuEntity.MenuName = dataRow["MenuName"].ToString();
           //菜单路径 nvarchar(200)
           mngMenuEntity.MenuUrl = dataRow["MenuUrl"].ToString();
           //MenuCode varchar(50)
           mngMenuEntity.MenuCode = dataRow["MenuCode"].ToString();
           //菜单级别 int
           if(dataRow["MenuLevel"].ToString() != "")
           {
              mngMenuEntity.MenuLevel = int.Parse(dataRow["MenuLevel"].ToString());
           }
           //菜单排序 int
           if(dataRow["MenuSort"].ToString() != "")
           {
              mngMenuEntity.MenuSort = int.Parse(dataRow["MenuSort"].ToString());
           }
           //状态：1.正常2.删除 int
           if(dataRow["Status"].ToString() != "")
           {
              mngMenuEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //父级菜单id int
           if(dataRow["ParentID"].ToString() != "")
           {
              mngMenuEntity.ParentID = int.Parse(dataRow["ParentID"].ToString());
           }
           
           return mngMenuEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="MngMenuEntity">objMngMenuEntity</returns>
        public static MngMenuEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           MngMenuEntity objMngMenuEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objMngMenuEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objMngMenuEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="MngMenuEntity[]">arrayEntitys</returns>
        public static MngMenuEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           MngMenuEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new MngMenuEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    MngMenuEntity objMngMenuEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objMngMenuEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}