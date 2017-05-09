using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseAttachmentEntity 的摘要说明
    ///</summary>
    public class CourseAttachmentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseAttachmentEntity">courseAttachmentEntity;</returns>
        public static CourseAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseAttachmentEntity courseAttachmentEntity =new CourseAttachmentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseAttachmentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //CourseID int
           if(dataRow["CourseID"].ToString() != "")
           {
              courseAttachmentEntity.CourseID = int.Parse(dataRow["CourseID"].ToString());
           }
           //AttachmentName nvarchar(50)
           courseAttachmentEntity.AttachmentName = dataRow["AttachmentName"].ToString();
           //AttachmentUrl nvarchar(50)
           courseAttachmentEntity.AttachmentUrl = dataRow["AttachmentUrl"].ToString();
           //AttachmentType int
           if(dataRow["AttachmentType"].ToString() != "")
           {
              courseAttachmentEntity.AttachmentType = int.Parse(dataRow["AttachmentType"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              courseAttachmentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              courseAttachmentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return courseAttachmentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseAttachmentEntity">objCourseAttachmentEntity</returns>
        public static CourseAttachmentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseAttachmentEntity objCourseAttachmentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseAttachmentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseAttachmentEntity[]">arrayEntitys</returns>
        public static CourseAttachmentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseAttachmentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseAttachmentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseAttachmentEntity objCourseAttachmentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseAttachmentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}