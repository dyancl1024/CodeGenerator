using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingStudyGroupUserEntity 的摘要说明
    ///</summary>
    public class TrainingStudyGroupUserMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingStudyGroupUserEntity">trainingStudyGroupUserEntity;</returns>
        public static TrainingStudyGroupUserEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingStudyGroupUserEntity trainingStudyGroupUserEntity =new TrainingStudyGroupUserEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingStudyGroupUserEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //StudyGroupID int
           if(dataRow["StudyGroupID"].ToString() != "")
           {
              trainingStudyGroupUserEntity.StudyGroupID = int.Parse(dataRow["StudyGroupID"].ToString());
           }
           //UserID int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingStudyGroupUserEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //1.正常2.删除 int
           if(dataRow["Status"].ToString() != "")
           {
              trainingStudyGroupUserEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //发布时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingStudyGroupUserEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingStudyGroupUserEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingStudyGroupUserEntity">objTrainingStudyGroupUserEntity</returns>
        public static TrainingStudyGroupUserEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingStudyGroupUserEntity objTrainingStudyGroupUserEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingStudyGroupUserEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingStudyGroupUserEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingStudyGroupUserEntity[]">arrayEntitys</returns>
        public static TrainingStudyGroupUserEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingStudyGroupUserEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingStudyGroupUserEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingStudyGroupUserEntity objTrainingStudyGroupUserEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingStudyGroupUserEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}