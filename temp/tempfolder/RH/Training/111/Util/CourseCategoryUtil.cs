using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///CourseCategoryEntity 的摘要说明
    ///</summary>
    public class CourseCategoryMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="CourseCategoryEntity">courseCategoryEntity;</returns>
        public static CourseCategoryEntity ParseDataRowToEntity(DataRow dataRow)
        {
           CourseCategoryEntity courseCategoryEntity =new CourseCategoryEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              courseCategoryEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //通识、技术、教研、科研、专业、技术素养、计划与准备、组织与管理、评估与诊断、组织与发展 nvarchar(50)
           courseCategoryEntity.Name = dataRow["Name"].ToString();
           //Code varchar(50)
           courseCategoryEntity.Code = dataRow["Code"].ToString();
           //课程类型：1非能力2能力 int
           if(dataRow["Type"].ToString() != "")
           {
              courseCategoryEntity.Type = int.Parse(dataRow["Type"].ToString());
           }
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              courseCategoryEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           
           return courseCategoryEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseCategoryEntity">objCourseCategoryEntity</returns>
        public static CourseCategoryEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           CourseCategoryEntity objCourseCategoryEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objCourseCategoryEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objCourseCategoryEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="CourseCategoryEntity[]">arrayEntitys</returns>
        public static CourseCategoryEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           CourseCategoryEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new CourseCategoryEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    CourseCategoryEntity objCourseCategoryEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objCourseCategoryEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}