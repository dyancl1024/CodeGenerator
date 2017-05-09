using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CoursePreSetListEntity 的摘要说明
    ///</summary>
    public class CoursePreSetListMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CoursePreSetListEntity">coursePreSetListEntity;</returns>
        public static CoursePreSetListEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CoursePreSetListEntity coursePreSetListEntity =new CoursePreSetListEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              coursePreSetListEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //PreSetID int
           if(dataRow["PreSetID"].ToString() != "")
           {
              coursePreSetListEntity.PreSetID = int.Parse(dataRow["PreSetID"].ToString());
           }
           //CourseID int
           if(dataRow["CourseID"].ToString() != "")
           {
              coursePreSetListEntity.CourseID = int.Parse(dataRow["CourseID"].ToString());
           }
           
           return coursePreSetListEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CoursePreSetListEntity">objCoursePreSetListEntity</returns>
        public static CoursePreSetListEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CoursePreSetListEntity objCoursePreSetListEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCoursePreSetListEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCoursePreSetListEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CoursePreSetListEntity[]">arrayEntitys</returns>
        public static CoursePreSetListEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CoursePreSetListEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CoursePreSetListEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CoursePreSetListEntity objCoursePreSetListEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCoursePreSetListEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}