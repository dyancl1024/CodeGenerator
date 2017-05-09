using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseAnswerEntity 的摘要说明
    ///</summary>
    public class CourseAnswerMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseAnswerEntity">courseAnswerEntity;</returns>
        public static CourseAnswerEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseAnswerEntity courseAnswerEntity =new CourseAnswerEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseAnswerEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //QuestionID int
           if(dataRow["QuestionID"].ToString() != "")
           {
              courseAnswerEntity.QuestionID = int.Parse(dataRow["QuestionID"].ToString());
           }
           //OptionID int
           if(dataRow["OptionID"].ToString() != "")
           {
              courseAnswerEntity.OptionID = int.Parse(dataRow["OptionID"].ToString());
           }
           //IsRight int
           if(dataRow["IsRight"].ToString() != "")
           {
              courseAnswerEntity.IsRight = int.Parse(dataRow["IsRight"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              courseAnswerEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              courseAnswerEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return courseAnswerEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseAnswerEntity">objCourseAnswerEntity</returns>
        public static CourseAnswerEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseAnswerEntity objCourseAnswerEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseAnswerEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseAnswerEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseAnswerEntity[]">arrayEntitys</returns>
        public static CourseAnswerEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseAnswerEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseAnswerEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseAnswerEntity objCourseAnswerEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseAnswerEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}