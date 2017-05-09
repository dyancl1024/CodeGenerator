using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TempUserEntity 的摘要说明
    ///</summary>
    public class TempUserMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TempUserEntity">tempUserEntity;</returns>
        public static TempUserEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TempUserEntity tempUserEntity =new TempUserEntity();

           //id int
           if(dataRow["id"].ToString() != "")
           {
              tempUserEntity.id = int.Parse(dataRow["id"].ToString());
           }
           //UserName varchar(50)
           tempUserEntity.UserName = dataRow["UserName"].ToString();
           //Password nvarchar(200)
           tempUserEntity.Password = dataRow["Password"].ToString();
           //TrueName nvarchar(50)
           tempUserEntity.TrueName = dataRow["TrueName"].ToString();
           //Gender nvarchar(50)
           tempUserEntity.Gender = dataRow["Gender"].ToString();
           //PicUrl nvarchar(200)
           tempUserEntity.PicUrl = dataRow["PicUrl"].ToString();
           //Nation int
           if(dataRow["Nation"].ToString() != "")
           {
              tempUserEntity.Nation = int.Parse(dataRow["Nation"].ToString());
           }
           //IDNO nvarchar(50)
           tempUserEntity.IDNO = dataRow["IDNO"].ToString();
           //ProvinceID int
           if(dataRow["ProvinceID"].ToString() != "")
           {
              tempUserEntity.ProvinceID = int.Parse(dataRow["ProvinceID"].ToString());
           }
           //CityID int
           if(dataRow["CityID"].ToString() != "")
           {
              tempUserEntity.CityID = int.Parse(dataRow["CityID"].ToString());
           }
           //DistrictID int
           if(dataRow["DistrictID"].ToString() != "")
           {
              tempUserEntity.DistrictID = int.Parse(dataRow["DistrictID"].ToString());
           }
           //Mobile varchar(50)
           tempUserEntity.Mobile = dataRow["Mobile"].ToString();
           //Email varchar(50)
           tempUserEntity.Email = dataRow["Email"].ToString();
           //QQ varchar(50)
           tempUserEntity.QQ = dataRow["QQ"].ToString();
           //IPAddr nvarchar(50)
           tempUserEntity.IPAddr = dataRow["IPAddr"].ToString();
           //IsChange int
           if(dataRow["IsChange"].ToString() != "")
           {
              tempUserEntity.IsChange = int.Parse(dataRow["IsChange"].ToString());
           }
           //UserState int
           if(dataRow["UserState"].ToString() != "")
           {
              tempUserEntity.UserState = int.Parse(dataRow["UserState"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              tempUserEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              tempUserEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //UpdateBy int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              tempUserEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //UpdateTime datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              tempUserEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           //CUserName nvarchar(50)
           tempUserEntity.CUserName = dataRow["CUserName"].ToString();
           //CPassword nvarchar(50)
           tempUserEntity.CPassword = dataRow["CPassword"].ToString();
           //GradeCode varchar(50)
           tempUserEntity.GradeCode = dataRow["GradeCode"].ToString();
           //SubjectCode varchar(50)
           tempUserEntity.SubjectCode = dataRow["SubjectCode"].ToString();
           //SchoolID int
           if(dataRow["SchoolID"].ToString() != "")
           {
              tempUserEntity.SchoolID = int.Parse(dataRow["SchoolID"].ToString());
           }
           //SchoolName nvarchar(50)
           tempUserEntity.SchoolName = dataRow["SchoolName"].ToString();
           //TempRemark nvarchar(100)
           tempUserEntity.TempRemark = dataRow["TempRemark"].ToString();
           //TempUserID int
           if(dataRow["TempUserID"].ToString() != "")
           {
              tempUserEntity.TempUserID = int.Parse(dataRow["TempUserID"].ToString());
           }
           //TempClassName nvarchar(50)
           tempUserEntity.TempClassName = dataRow["TempClassName"].ToString();
           //TempClassID int
           if(dataRow["TempClassID"].ToString() != "")
           {
              tempUserEntity.TempClassID = int.Parse(dataRow["TempClassID"].ToString());
           }
           
           return tempUserEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TempUserEntity">objTempUserEntity</returns>
        public static TempUserEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TempUserEntity objTempUserEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTempUserEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTempUserEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TempUserEntity[]">arrayEntitys</returns>
        public static TempUserEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TempUserEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TempUserEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TempUserEntity objTempUserEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTempUserEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}