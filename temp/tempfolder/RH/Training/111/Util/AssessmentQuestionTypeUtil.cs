using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///AssessmentQuestionTypeEntity 的摘要说明
    ///</summary>
    public class AssessmentQuestionTypeMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="AssessmentQuestionTypeEntity">assessmentQuestionTypeEntity;</returns>
        public static AssessmentQuestionTypeEntity ParseDataRowToEntity(DataRow dataRow)
        {
           AssessmentQuestionTypeEntity assessmentQuestionTypeEntity =new AssessmentQuestionTypeEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              assessmentQuestionTypeEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //问题类型 nvarchar(50)
           assessmentQuestionTypeEntity.TypeName = dataRow["TypeName"].ToString();
           
           return assessmentQuestionTypeEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentQuestionTypeEntity">objAssessmentQuestionTypeEntity</returns>
        public static AssessmentQuestionTypeEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           AssessmentQuestionTypeEntity objAssessmentQuestionTypeEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objAssessmentQuestionTypeEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objAssessmentQuestionTypeEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentQuestionTypeEntity[]">arrayEntitys</returns>
        public static AssessmentQuestionTypeEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           AssessmentQuestionTypeEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new AssessmentQuestionTypeEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    AssessmentQuestionTypeEntity objAssessmentQuestionTypeEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objAssessmentQuestionTypeEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}