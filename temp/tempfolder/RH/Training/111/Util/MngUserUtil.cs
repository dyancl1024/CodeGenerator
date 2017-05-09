using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///MngUserEntity 的摘要说明
    ///</summary>
    public class MngUserMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="MngUserEntity">mngUserEntity;</returns>
        public static MngUserEntity ParseDataRowToEntity(DataRow dataRow)
        {
           MngUserEntity mngUserEntity =new MngUserEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              mngUserEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //用户名 nvarchar(50)
           mngUserEntity.UserName = dataRow["UserName"].ToString();
           //Password nvarchar(50)
           mngUserEntity.Password = dataRow["Password"].ToString();
           //真实姓名 nvarchar(50)
           mngUserEntity.TrueName = dataRow["TrueName"].ToString();
           //角色id  角色表 int
           if(dataRow["RoleID"].ToString() != "")
           {
              mngUserEntity.RoleID = int.Parse(dataRow["RoleID"].ToString());
           }
           //状态：1.正常 2.删除 int
           if(dataRow["Status"].ToString() != "")
           {
              mngUserEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              mngUserEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              mngUserEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              mngUserEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              mngUserEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return mngUserEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="MngUserEntity">objMngUserEntity</returns>
        public static MngUserEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           MngUserEntity objMngUserEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objMngUserEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objMngUserEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="MngUserEntity[]">arrayEntitys</returns>
        public static MngUserEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           MngUserEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new MngUserEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    MngUserEntity objMngUserEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objMngUserEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}