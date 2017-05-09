using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingHomeWorkAuditEntity 的摘要说明
    ///</summary>
    public class TrainingHomeWorkAuditMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingHomeWorkAuditEntity">trainingHomeWorkAuditEntity;</returns>
        public static TrainingHomeWorkAuditEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingHomeWorkAuditEntity trainingHomeWorkAuditEntity =new TrainingHomeWorkAuditEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingHomeWorkAuditEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //HomeWorkID int
           if(dataRow["HomeWorkID"].ToString() != "")
           {
              trainingHomeWorkAuditEntity.HomeWorkID = int.Parse(dataRow["HomeWorkID"].ToString());
           }
           //Auditor int
           if(dataRow["Auditor"].ToString() != "")
           {
              trainingHomeWorkAuditEntity.Auditor = int.Parse(dataRow["Auditor"].ToString());
           }
           //AuditTime datetime
           if(dataRow["AuditTime"].ToString() != "")
           {
              trainingHomeWorkAuditEntity.AuditTime = DateTime.Parse(dataRow["AuditTime"].ToString());
           }
           //审批意见 nvarchar(200)
           trainingHomeWorkAuditEntity.AuditDesc = dataRow["AuditDesc"].ToString();
           //作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交） int
           if(dataRow["Status"].ToString() != "")
           {
              trainingHomeWorkAuditEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           
           return trainingHomeWorkAuditEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingHomeWorkAuditEntity">objTrainingHomeWorkAuditEntity</returns>
        public static TrainingHomeWorkAuditEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingHomeWorkAuditEntity objTrainingHomeWorkAuditEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingHomeWorkAuditEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingHomeWorkAuditEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingHomeWorkAuditEntity[]">arrayEntitys</returns>
        public static TrainingHomeWorkAuditEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingHomeWorkAuditEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingHomeWorkAuditEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingHomeWorkAuditEntity objTrainingHomeWorkAuditEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingHomeWorkAuditEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}