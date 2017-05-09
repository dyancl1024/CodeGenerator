using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingStudyStatusEntity 的摘要说明
    ///</summary>
    public class TrainingStudyStatusMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingStudyStatusEntity">trainingStudyStatusEntity;</returns>
        public static TrainingStudyStatusEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingStudyStatusEntity trainingStudyStatusEntity =new TrainingStudyStatusEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingStudyStatusEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //PCID int
           if(dataRow["PCID"].ToString() != "")
           {
              trainingStudyStatusEntity.PCID = int.Parse(dataRow["PCID"].ToString());
           }
           //课程ID int
           if(dataRow["CID"].ToString() != "")
           {
              trainingStudyStatusEntity.CID = int.Parse(dataRow["CID"].ToString());
           }
           //SubTID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingStudyStatusEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //课程学习状态：1学习中2.完成学习 int
           if(dataRow["Status"].ToString() != "")
           {
              trainingStudyStatusEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //UserID int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingStudyStatusEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           
           return trainingStudyStatusEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingStudyStatusEntity">objTrainingStudyStatusEntity</returns>
        public static TrainingStudyStatusEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingStudyStatusEntity objTrainingStudyStatusEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingStudyStatusEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingStudyStatusEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingStudyStatusEntity[]">arrayEntitys</returns>
        public static TrainingStudyStatusEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingStudyStatusEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingStudyStatusEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingStudyStatusEntity objTrainingStudyStatusEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingStudyStatusEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}