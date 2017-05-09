using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///AssessmentQuestionEntity 的摘要说明
    ///</summary>
    public class AssessmentQuestionMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="AssessmentQuestionEntity">assessmentQuestionEntity;</returns>
        public static AssessmentQuestionEntity ParseDataRowToEntity(DataRow dataRow)
        {
           AssessmentQuestionEntity assessmentQuestionEntity =new AssessmentQuestionEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              assessmentQuestionEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //测评工具id 对应RH_Assessment表id int
           if(dataRow["AssessmentID"].ToString() != "")
           {
              assessmentQuestionEntity.AssessmentID = int.Parse(dataRow["AssessmentID"].ToString());
           }
           //题干 nvarchar(Max)
           assessmentQuestionEntity.Question = dataRow["Question"].ToString();
           //题干描述 nvarchar(Max)
           assessmentQuestionEntity.QuestionDesc = dataRow["QuestionDesc"].ToString();
           //题型 对应RH_AssessmentQuestionType表id int
           if(dataRow["TypeID"].ToString() != "")
           {
              assessmentQuestionEntity.TypeID = int.Parse(dataRow["TypeID"].ToString());
           }
           //课堂维度：1.课堂教学 2.学习方式 int
           if(dataRow["Dimensions"].ToString() != "")
           {
              assessmentQuestionEntity.Dimensions = int.Parse(dataRow["Dimensions"].ToString());
           }
           //排序 int
           if(dataRow["SortNo"].ToString() != "")
           {
              assessmentQuestionEntity.SortNo = int.Parse(dataRow["SortNo"].ToString());
           }
           //状态 0.未发布 1.发布 int
           if(dataRow["Status"].ToString() != "")
           {
              assessmentQuestionEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           
           return assessmentQuestionEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentQuestionEntity">objAssessmentQuestionEntity</returns>
        public static AssessmentQuestionEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           AssessmentQuestionEntity objAssessmentQuestionEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objAssessmentQuestionEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objAssessmentQuestionEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentQuestionEntity[]">arrayEntitys</returns>
        public static AssessmentQuestionEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           AssessmentQuestionEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new AssessmentQuestionEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    AssessmentQuestionEntity objAssessmentQuestionEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objAssessmentQuestionEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}