using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///AssessmentOptionsEntity 的摘要说明
    ///</summary>
    public class AssessmentOptionsMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="AssessmentOptionsEntity">assessmentOptionsEntity;</returns>
        public static AssessmentOptionsEntity ParseDataRowToEntity(DataRow dataRow)
        {
           AssessmentOptionsEntity assessmentOptionsEntity =new AssessmentOptionsEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              assessmentOptionsEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //问题id int
           if(dataRow["QID"].ToString() != "")
           {
              assessmentOptionsEntity.QID = int.Parse(dataRow["QID"].ToString());
           }
           //选项 nvarchar(Max)
           assessmentOptionsEntity.Options = dataRow["Options"].ToString();
           //排序 int
           if(dataRow["SortNO"].ToString() != "")
           {
              assessmentOptionsEntity.SortNO = int.Parse(dataRow["SortNO"].ToString());
           }
           //分值  1.1分 2.2分 3.3分 int
           if(dataRow["Score"].ToString() != "")
           {
              assessmentOptionsEntity.Score = int.Parse(dataRow["Score"].ToString());
           }
           
           return assessmentOptionsEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentOptionsEntity">objAssessmentOptionsEntity</returns>
        public static AssessmentOptionsEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           AssessmentOptionsEntity objAssessmentOptionsEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objAssessmentOptionsEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objAssessmentOptionsEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentOptionsEntity[]">arrayEntitys</returns>
        public static AssessmentOptionsEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           AssessmentOptionsEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new AssessmentOptionsEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    AssessmentOptionsEntity objAssessmentOptionsEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objAssessmentOptionsEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}