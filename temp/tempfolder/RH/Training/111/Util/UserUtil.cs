using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///UserEntity 的摘要说明
    ///</summary>
    public class UserMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="UserEntity">userEntity;</returns>
        public static UserEntity ParseDataRowToEntity(DataRow dataRow)
        {
           UserEntity userEntity =new UserEntity();

           //id int
           if(dataRow["id"].ToString() != "")
           {
              userEntity.id = int.Parse(dataRow["id"].ToString());
           }
           //UserName varchar(50)
           userEntity.UserName = dataRow["UserName"].ToString();
           //Password nvarchar(200)
           userEntity.Password = dataRow["Password"].ToString();
           //TrueName nvarchar(50)
           userEntity.TrueName = dataRow["TrueName"].ToString();
           //Gender nvarchar(50)
           userEntity.Gender = dataRow["Gender"].ToString();
           //PicUrl nvarchar(200)
           userEntity.PicUrl = dataRow["PicUrl"].ToString();
           //Nation int
           if(dataRow["Nation"].ToString() != "")
           {
              userEntity.Nation = int.Parse(dataRow["Nation"].ToString());
           }
           //IDNO nvarchar(50)
           userEntity.IDNO = dataRow["IDNO"].ToString();
           //ProvinceID int
           if(dataRow["ProvinceID"].ToString() != "")
           {
              userEntity.ProvinceID = int.Parse(dataRow["ProvinceID"].ToString());
           }
           //CityID int
           if(dataRow["CityID"].ToString() != "")
           {
              userEntity.CityID = int.Parse(dataRow["CityID"].ToString());
           }
           //DistrictID int
           if(dataRow["DistrictID"].ToString() != "")
           {
              userEntity.DistrictID = int.Parse(dataRow["DistrictID"].ToString());
           }
           //Mobile varchar(50)
           userEntity.Mobile = dataRow["Mobile"].ToString();
           //Email varchar(50)
           userEntity.Email = dataRow["Email"].ToString();
           //QQ varchar(50)
           userEntity.QQ = dataRow["QQ"].ToString();
           //IPAddr nvarchar(50)
           userEntity.IPAddr = dataRow["IPAddr"].ToString();
           //IsChange int
           if(dataRow["IsChange"].ToString() != "")
           {
              userEntity.IsChange = int.Parse(dataRow["IsChange"].ToString());
           }
           //UserState int
           if(dataRow["UserState"].ToString() != "")
           {
              userEntity.UserState = int.Parse(dataRow["UserState"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              userEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              userEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //UpdateBy int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              userEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //UpdateTime datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              userEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return userEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="UserEntity">objUserEntity</returns>
        public static UserEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           UserEntity objUserEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objUserEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objUserEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="UserEntity[]">arrayEntitys</returns>
        public static UserEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           UserEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new UserEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    UserEntity objUserEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objUserEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}