using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseEntity 的摘要说明
    ///</summary>
    public class CourseMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseEntity">courseEntity;</returns>
        public static CourseEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseEntity courseEntity =new CourseEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //课程名称 nvarchar(200)
           courseEntity.CourseName = dataRow["CourseName"].ToString();
           //课程学时 int
           if(dataRow["CoursePharse"].ToString() != "")
           {
              courseEntity.CoursePharse = int.Parse(dataRow["CoursePharse"].ToString());
           }
           //1-通识 2-专业 3-技术 4-科研 5-教研 varchar(50)
           courseEntity.CourseCategoryCode = dataRow["CourseCategoryCode"].ToString();
           //CourseDesc nvarchar(Max)
           courseEntity.CourseDesc = dataRow["CourseDesc"].ToString();
           //记录课程文件路径 nvarchar(200)
           courseEntity.CourseUrl = dataRow["CourseUrl"].ToString();
           //讲师简介 nvarchar(Max)
           courseEntity.TeacherDesc = dataRow["TeacherDesc"].ToString();
           //讲师姓名 nvarchar(200)
           courseEntity.TeacherName = dataRow["TeacherName"].ToString();
           //讲师职称 nvarchar(200)
           courseEntity.TeacherTitle = dataRow["TeacherTitle"].ToString();
           //课程标签 nvarchar(50)
           courseEntity.CourseLabel = dataRow["CourseLabel"].ToString();
           //课程代码 nvarchar(50)
           courseEntity.CourseCode = dataRow["CourseCode"].ToString();
           //是否为实践性课程：1.是 2.否 int
           if(dataRow["IsPractice"].ToString() != "")
           {
              courseEntity.IsPractice = int.Parse(dataRow["IsPractice"].ToString());
           }
           //课程单位 nvarchar(200)
           courseEntity.CourseCompany = dataRow["CourseCompany"].ToString();
           //课程形式 nvarchar(200)
           courseEntity.CourseStyle = dataRow["CourseStyle"].ToString();
           //是否为一线教师教研员：1.是 2.否 int
           if(dataRow["IsSpecialTeacher"].ToString() != "")
           {
              courseEntity.IsSpecialTeacher = int.Parse(dataRow["IsSpecialTeacher"].ToString());
           }
           //学习时长 int
           if(dataRow["VideoDuration"].ToString() != "")
           {
              courseEntity.VideoDuration = int.Parse(dataRow["VideoDuration"].ToString());
           }
           //是否App： 1.是2.否 int
           if(dataRow["IsApp"].ToString() != "")
           {
              courseEntity.IsApp = int.Parse(dataRow["IsApp"].ToString());
           }
           //状态 1-未发布 2-已发布 3-删除 int
           if(dataRow["Status"].ToString() != "")
           {
              courseEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              courseEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              courseEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              courseEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              courseEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return courseEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseEntity">objCourseEntity</returns>
        public static CourseEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseEntity objCourseEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseEntity[]">arrayEntitys</returns>
        public static CourseEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseEntity objCourseEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}