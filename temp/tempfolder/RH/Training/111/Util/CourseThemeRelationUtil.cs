using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseThemeRelationEntity 的摘要说明
    ///</summary>
    public class CourseThemeRelationMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseThemeRelationEntity">courseThemeRelationEntity;</returns>
        public static CourseThemeRelationEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseThemeRelationEntity courseThemeRelationEntity =new CourseThemeRelationEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseThemeRelationEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //课程id int
           if(dataRow["CourseID"].ToString() != "")
           {
              courseThemeRelationEntity.CourseID = int.Parse(dataRow["CourseID"].ToString());
           }
           //能力提升课程代码 varchar(50)
           courseThemeRelationEntity.CourseThemeCode = dataRow["CourseThemeCode"].ToString();
           
           return courseThemeRelationEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseThemeRelationEntity">objCourseThemeRelationEntity</returns>
        public static CourseThemeRelationEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseThemeRelationEntity objCourseThemeRelationEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseThemeRelationEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseThemeRelationEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseThemeRelationEntity[]">arrayEntitys</returns>
        public static CourseThemeRelationEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseThemeRelationEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseThemeRelationEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseThemeRelationEntity objCourseThemeRelationEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseThemeRelationEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}