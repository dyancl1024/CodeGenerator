using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///AssessmentEntity 的摘要说明
    ///</summary>
    public class AssessmentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="AssessmentEntity">assessmentEntity;</returns>
        public static AssessmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           AssessmentEntity assessmentEntity =new AssessmentEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              assessmentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //测评工具名称 nvarchar(200)
           assessmentEntity.AName = dataRow["AName"].ToString();
           //评测描述 nvarchar(Max)
           assessmentEntity.ADesc = dataRow["ADesc"].ToString();
           //0.未发布  1.已发布 int
           if(dataRow["Status"].ToString() != "")
           {
              assessmentEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           
           return assessmentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentEntity">objAssessmentEntity</returns>
        public static AssessmentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           AssessmentEntity objAssessmentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objAssessmentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objAssessmentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="AssessmentEntity[]">arrayEntitys</returns>
        public static AssessmentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           AssessmentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new AssessmentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    AssessmentEntity objAssessmentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objAssessmentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}