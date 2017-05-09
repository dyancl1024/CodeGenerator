using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseQuestionEntity 的摘要说明
    ///</summary>
    public class CourseQuestionMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseQuestionEntity">courseQuestionEntity;</returns>
        public static CourseQuestionEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseQuestionEntity courseQuestionEntity =new CourseQuestionEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseQuestionEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //CourseID int
           if(dataRow["CourseID"].ToString() != "")
           {
              courseQuestionEntity.CourseID = int.Parse(dataRow["CourseID"].ToString());
           }
           //Question nvarchar(200)
           courseQuestionEntity.Question = dataRow["Question"].ToString();
           //1单选2多选3判断 int
           if(dataRow["QType"].ToString() != "")
           {
              courseQuestionEntity.QType = int.Parse(dataRow["QType"].ToString());
           }
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              courseQuestionEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           //状态 1-未发布 2-已发布 3-删除 int
           if(dataRow["Status"].ToString() != "")
           {
              courseQuestionEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              courseQuestionEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              courseQuestionEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              courseQuestionEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              courseQuestionEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return courseQuestionEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseQuestionEntity">objCourseQuestionEntity</returns>
        public static CourseQuestionEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseQuestionEntity objCourseQuestionEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseQuestionEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseQuestionEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseQuestionEntity[]">arrayEntitys</returns>
        public static CourseQuestionEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseQuestionEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseQuestionEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseQuestionEntity objCourseQuestionEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseQuestionEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}