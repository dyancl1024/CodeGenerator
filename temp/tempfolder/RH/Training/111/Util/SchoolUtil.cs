using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///SchoolEntity 的摘要说明
    ///</summary>
    public class SchoolMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="SchoolEntity">schoolEntity;</returns>
        public static SchoolEntity ParseDataRowToEntity(DataRow dataRow)
        {
           SchoolEntity schoolEntity =new SchoolEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              schoolEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //DistrictID int
           if(dataRow["DistrictID"].ToString() != "")
           {
              schoolEntity.DistrictID = int.Parse(dataRow["DistrictID"].ToString());
           }
           //SchoolName nvarchar(50)
           schoolEntity.SchoolName = dataRow["SchoolName"].ToString();
           //Status int
           if(dataRow["Status"].ToString() != "")
           {
              schoolEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              schoolEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              schoolEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              schoolEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              schoolEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return schoolEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="SchoolEntity">objSchoolEntity</returns>
        public static SchoolEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           SchoolEntity objSchoolEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objSchoolEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objSchoolEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="SchoolEntity[]">arrayEntitys</returns>
        public static SchoolEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           SchoolEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new SchoolEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    SchoolEntity objSchoolEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objSchoolEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}