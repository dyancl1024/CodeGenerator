using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseLevelRelationEntity 的摘要说明
    ///</summary>
    public class CourseLevelRelationMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseLevelRelationEntity">courseLevelRelationEntity;</returns>
        public static CourseLevelRelationEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseLevelRelationEntity courseLevelRelationEntity =new CourseLevelRelationEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseLevelRelationEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //CourseID int
           if(dataRow["CourseID"].ToString() != "")
           {
              courseLevelRelationEntity.CourseID = int.Parse(dataRow["CourseID"].ToString());
           }
           //1初级2中级3高级 int
           if(dataRow["CourseLevel"].ToString() != "")
           {
              courseLevelRelationEntity.CourseLevel = int.Parse(dataRow["CourseLevel"].ToString());
           }
           
           return courseLevelRelationEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseLevelRelationEntity">objCourseLevelRelationEntity</returns>
        public static CourseLevelRelationEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseLevelRelationEntity objCourseLevelRelationEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseLevelRelationEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseLevelRelationEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseLevelRelationEntity[]">arrayEntitys</returns>
        public static CourseLevelRelationEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseLevelRelationEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseLevelRelationEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseLevelRelationEntity objCourseLevelRelationEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseLevelRelationEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}