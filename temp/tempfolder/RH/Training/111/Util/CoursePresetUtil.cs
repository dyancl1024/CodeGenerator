using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CoursePresetEntity 的摘要说明
    ///</summary>
    public class CoursePresetMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CoursePresetEntity">coursePresetEntity;</returns>
        public static CoursePresetEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CoursePresetEntity coursePresetEntity =new CoursePresetEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              coursePresetEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //Name nvarchar(50)
           coursePresetEntity.Name = dataRow["Name"].ToString();
           //CPDesc nvarchar(200)
           coursePresetEntity.CPDesc = dataRow["CPDesc"].ToString();
           //是否提升 1-是 0-否 int
           if(dataRow["IfPromote"].ToString() != "")
           {
              coursePresetEntity.IfPromote = int.Parse(dataRow["IfPromote"].ToString());
           }
           //是否必修 1.是 2否 int
           if(dataRow["IsRequired"].ToString() != "")
           {
              coursePresetEntity.IsRequired = int.Parse(dataRow["IsRequired"].ToString());
           }
           //能力提升课程等级 1.初级 2.中级 3，高级 int
           if(dataRow["CourseLevel"].ToString() != "")
           {
              coursePresetEntity.CourseLevel = int.Parse(dataRow["CourseLevel"].ToString());
           }
           //能力提升课程维度 int
           if(dataRow["Dimension"].ToString() != "")
           {
              coursePresetEntity.Dimension = int.Parse(dataRow["Dimension"].ToString());
           }
           //版本号 int
           if(dataRow["Version"].ToString() != "")
           {
              coursePresetEntity.Version = int.Parse(dataRow["Version"].ToString());
           }
           //父套餐id，用于套餐复制 int
           if(dataRow["parentID"].ToString() != "")
           {
              coursePresetEntity.parentID = int.Parse(dataRow["parentID"].ToString());
           }
           //状态：1-未发布 2-已发布 3 已删除 int
           if(dataRow["Status"].ToString() != "")
           {
              coursePresetEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              coursePresetEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              coursePresetEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //UpdateBy int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              coursePresetEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //UpdateTime datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              coursePresetEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return coursePresetEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CoursePresetEntity">objCoursePresetEntity</returns>
        public static CoursePresetEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CoursePresetEntity objCoursePresetEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCoursePresetEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCoursePresetEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CoursePresetEntity[]">arrayEntitys</returns>
        public static CoursePresetEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CoursePresetEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CoursePresetEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CoursePresetEntity objCoursePresetEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCoursePresetEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}