using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///AssessmentAnswerEntity 的摘要说明
    ///</summary>
    public class AssessmentAnswerMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="AssessmentAnswerEntity">assessmentAnswerEntity;</returns>
        public static AssessmentAnswerEntity ParseDataRowToEntity(DataRow dataRow)
        {
           AssessmentAnswerEntity assessmentAnswerEntity =new AssessmentAnswerEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              assessmentAnswerEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //项目id int
           if(dataRow["SubTID"].ToString() != "")
           {
              assessmentAnswerEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //用户id int
           if(dataRow["UserID"].ToString() != "")
           {
              assessmentAnswerEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //问题id int
           if(dataRow["QID"].ToString() != "")
           {
              assessmentAnswerEntity.QID = int.Parse(dataRow["QID"].ToString());
           }
           //问题类型  RH_AssessmentQuestionType表id int
           if(dataRow["QType"].ToString() != "")
           {
              assessmentAnswerEntity.QType = int.Parse(dataRow["QType"].ToString());
           }
           //选项id  RH_AssessmentOptions表id int
           if(dataRow["OptionID"].ToString() != "")
           {
              assessmentAnswerEntity.OptionID = int.Parse(dataRow["OptionID"].ToString());
           }
           //得分 int
           if(dataRow["Score"].ToString() != "")
           {
              assessmentAnswerEntity.Score = int.Parse(dataRow["Score"].ToString());
           }
           
           return assessmentAnswerEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentAnswerEntity">objAssessmentAnswerEntity</returns>
        public static AssessmentAnswerEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           AssessmentAnswerEntity objAssessmentAnswerEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objAssessmentAnswerEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objAssessmentAnswerEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentAnswerEntity[]">arrayEntitys</returns>
        public static AssessmentAnswerEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           AssessmentAnswerEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new AssessmentAnswerEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    AssessmentAnswerEntity objAssessmentAnswerEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objAssessmentAnswerEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}