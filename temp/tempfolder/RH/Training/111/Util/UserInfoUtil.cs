using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///UserInfoEntity 的摘要说明
    ///</summary>
    public class UserInfoMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="UserInfoEntity">userInfoEntity;</returns>
        public static UserInfoEntity ParseDataRowToEntity(DataRow dataRow)
        {
           UserInfoEntity userInfoEntity =new UserInfoEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              userInfoEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //人id int
           if(dataRow["UserID"].ToString() != "")
           {
              userInfoEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //学校ID int
           if(dataRow["SchoolID"].ToString() != "")
           {
              userInfoEntity.SchoolID = int.Parse(dataRow["SchoolID"].ToString());
           }
           //接口用户名 nvarchar(50)
           userInfoEntity.CUserName = dataRow["CUserName"].ToString();
           //CPassword nvarchar(50)
           userInfoEntity.CPassword = dataRow["CPassword"].ToString();
           //CSource int
           if(dataRow["CSource"].ToString() != "")
           {
              userInfoEntity.CSource = int.Parse(dataRow["CSource"].ToString());
           }
           
           return userInfoEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="UserInfoEntity">objUserInfoEntity</returns>
        public static UserInfoEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           UserInfoEntity objUserInfoEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objUserInfoEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objUserInfoEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="UserInfoEntity[]">arrayEntitys</returns>
        public static UserInfoEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           UserInfoEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new UserInfoEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    UserInfoEntity objUserInfoEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objUserInfoEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}