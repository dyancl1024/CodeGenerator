using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseOptionEntity 的摘要说明
    ///</summary>
    public class CourseOptionMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseOptionEntity">courseOptionEntity;</returns>
        public static CourseOptionEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseOptionEntity courseOptionEntity =new CourseOptionEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseOptionEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //QuestionID int
           if(dataRow["QuestionID"].ToString() != "")
           {
              courseOptionEntity.QuestionID = int.Parse(dataRow["QuestionID"].ToString());
           }
           //QOption nvarchar(200)
           courseOptionEntity.QOption = dataRow["QOption"].ToString();
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              courseOptionEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           //是否标准答案1是2否 int
           if(dataRow["IsRight"].ToString() != "")
           {
              courseOptionEntity.IsRight = int.Parse(dataRow["IsRight"].ToString());
           }
           
           return courseOptionEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseOptionEntity">objCourseOptionEntity</returns>
        public static CourseOptionEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseOptionEntity objCourseOptionEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseOptionEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseOptionEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseOptionEntity[]">arrayEntitys</returns>
        public static CourseOptionEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseOptionEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseOptionEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseOptionEntity objCourseOptionEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseOptionEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}