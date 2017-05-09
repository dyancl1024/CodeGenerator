using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingOtherAttachmentEntity 的摘要说明
    ///</summary>
    public class TrainingOtherAttachmentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingOtherAttachmentEntity">trainingOtherAttachmentEntity;</returns>
        public static TrainingOtherAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingOtherAttachmentEntity trainingOtherAttachmentEntity =new TrainingOtherAttachmentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingOtherAttachmentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //对应RH_TrainingOther表id int
           if(dataRow["TOID"].ToString() != "")
           {
              trainingOtherAttachmentEntity.TOID = int.Parse(dataRow["TOID"].ToString());
           }
           //AttachmentName nvarchar(200)
           trainingOtherAttachmentEntity.AttachmentName = dataRow["AttachmentName"].ToString();
           //AttachmentURL nvarchar(200)
           trainingOtherAttachmentEntity.AttachmentURL = dataRow["AttachmentURL"].ToString();
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingOtherAttachmentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingOtherAttachmentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //UpdateBy int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingOtherAttachmentEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //UpdateTime datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingOtherAttachmentEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingOtherAttachmentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingOtherAttachmentEntity">objTrainingOtherAttachmentEntity</returns>
        public static TrainingOtherAttachmentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingOtherAttachmentEntity objTrainingOtherAttachmentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingOtherAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingOtherAttachmentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingOtherAttachmentEntity[]">arrayEntitys</returns>
        public static TrainingOtherAttachmentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingOtherAttachmentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingOtherAttachmentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingOtherAttachmentEntity objTrainingOtherAttachmentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingOtherAttachmentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}