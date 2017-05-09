using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseThemeEntity 的摘要说明
    ///</summary>
    public class CourseThemeMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseThemeEntity">courseThemeEntity;</returns>
        public static CourseThemeEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseThemeEntity courseThemeEntity =new CourseThemeEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseThemeEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //Name nvarchar(50)
           courseThemeEntity.Name = dataRow["Name"].ToString();
           //Code varchar(50)
           courseThemeEntity.Code = dataRow["Code"].ToString();
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              courseThemeEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           //1.应用信息技术优化课堂教学  2.应用信息技术转变学习方式 int
           if(dataRow["Type"].ToString() != "")
           {
              courseThemeEntity.Type = int.Parse(dataRow["Type"].ToString());
           }
           
           return courseThemeEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseThemeEntity">objCourseThemeEntity</returns>
        public static CourseThemeEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseThemeEntity objCourseThemeEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseThemeEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseThemeEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseThemeEntity[]">arrayEntitys</returns>
        public static CourseThemeEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseThemeEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseThemeEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseThemeEntity objCourseThemeEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseThemeEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}