using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseSubjectEntity 的摘要说明
    ///</summary>
    public class CourseSubjectMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseSubjectEntity">courseSubjectEntity;</returns>
        public static CourseSubjectEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseSubjectEntity courseSubjectEntity =new CourseSubjectEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseSubjectEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //CourseID int
           if(dataRow["CourseID"].ToString() != "")
           {
              courseSubjectEntity.CourseID = int.Parse(dataRow["CourseID"].ToString());
           }
           //GradeCode varchar(50)
           courseSubjectEntity.GradeCode = dataRow["GradeCode"].ToString();
           //SubjectCode varchar(50)
           courseSubjectEntity.SubjectCode = dataRow["SubjectCode"].ToString();
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              courseSubjectEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              courseSubjectEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return courseSubjectEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseSubjectEntity">objCourseSubjectEntity</returns>
        public static CourseSubjectEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseSubjectEntity objCourseSubjectEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseSubjectEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseSubjectEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseSubjectEntity[]">arrayEntitys</returns>
        public static CourseSubjectEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseSubjectEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseSubjectEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseSubjectEntity objCourseSubjectEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseSubjectEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}