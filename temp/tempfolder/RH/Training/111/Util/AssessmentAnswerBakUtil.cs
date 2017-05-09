using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///AssessmentAnswerBakEntity 的摘要说明
    ///</summary>
    public class AssessmentAnswerBakMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="AssessmentAnswerBakEntity">assessmentAnswerBakEntity;</returns>
        public static AssessmentAnswerBakEntity ParseDataRowToEntity(DataRow dataRow)
        {
           AssessmentAnswerBakEntity assessmentAnswerBakEntity =new AssessmentAnswerBakEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              assessmentAnswerBakEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //项目id int
           if(dataRow["SubTID"].ToString() != "")
           {
              assessmentAnswerBakEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //用户id int
           if(dataRow["UserID"].ToString() != "")
           {
              assessmentAnswerBakEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //问题id int
           if(dataRow["QID"].ToString() != "")
           {
              assessmentAnswerBakEntity.QID = int.Parse(dataRow["QID"].ToString());
           }
           //问题类型 问题类型  RH_AssessmentQuestionType表id int
           if(dataRow["QType"].ToString() != "")
           {
              assessmentAnswerBakEntity.QType = int.Parse(dataRow["QType"].ToString());
           }
           //选项id  RH_AssessmentOptions表id int
           if(dataRow["OptionID"].ToString() != "")
           {
              assessmentAnswerBakEntity.OptionID = int.Parse(dataRow["OptionID"].ToString());
           }
           //得分 int
           if(dataRow["Score"].ToString() != "")
           {
              assessmentAnswerBakEntity.Score = int.Parse(dataRow["Score"].ToString());
           }
           
           return assessmentAnswerBakEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentAnswerBakEntity">objAssessmentAnswerBakEntity</returns>
        public static AssessmentAnswerBakEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           AssessmentAnswerBakEntity objAssessmentAnswerBakEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objAssessmentAnswerBakEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objAssessmentAnswerBakEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentAnswerBakEntity[]">arrayEntitys</returns>
        public static AssessmentAnswerBakEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           AssessmentAnswerBakEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new AssessmentAnswerBakEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    AssessmentAnswerBakEntity objAssessmentAnswerBakEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objAssessmentAnswerBakEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}