using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingHomeWorkAttachmentEntity 的摘要说明
    ///</summary>
    public class TrainingHomeWorkAttachmentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingHomeWorkAttachmentEntity">trainingHomeWorkAttachmentEntity;</returns>
        public static TrainingHomeWorkAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingHomeWorkAttachmentEntity trainingHomeWorkAttachmentEntity =new TrainingHomeWorkAttachmentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingHomeWorkAttachmentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //HomeWorkID int
           if(dataRow["HomeWorkID"].ToString() != "")
           {
              trainingHomeWorkAttachmentEntity.HomeWorkID = int.Parse(dataRow["HomeWorkID"].ToString());
           }
           //AttachmentName nvarchar(50)
           trainingHomeWorkAttachmentEntity.AttachmentName = dataRow["AttachmentName"].ToString();
           //AttachmentUrl nvarchar(50)
           trainingHomeWorkAttachmentEntity.AttachmentUrl = dataRow["AttachmentUrl"].ToString();
           //1-文本 2-视频 3-图片 4-音频 int
           if(dataRow["AttachmentType"].ToString() != "")
           {
              trainingHomeWorkAttachmentEntity.AttachmentType = int.Parse(dataRow["AttachmentType"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingHomeWorkAttachmentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingHomeWorkAttachmentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingHomeWorkAttachmentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingHomeWorkAttachmentEntity">objTrainingHomeWorkAttachmentEntity</returns>
        public static TrainingHomeWorkAttachmentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingHomeWorkAttachmentEntity objTrainingHomeWorkAttachmentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingHomeWorkAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingHomeWorkAttachmentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingHomeWorkAttachmentEntity[]">arrayEntitys</returns>
        public static TrainingHomeWorkAttachmentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingHomeWorkAttachmentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingHomeWorkAttachmentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingHomeWorkAttachmentEntity objTrainingHomeWorkAttachmentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingHomeWorkAttachmentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}