using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingBriefingCommentEntity 的摘要说明
    ///</summary>
    public class TrainingBriefingCommentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingBriefingCommentEntity">trainingBriefingCommentEntity;</returns>
        public static TrainingBriefingCommentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingBriefingCommentEntity trainingBriefingCommentEntity =new TrainingBriefingCommentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingBriefingCommentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //项目简报ID 对应RH_TrainingBriefing int
           if(dataRow["TBID"].ToString() != "")
           {
              trainingBriefingCommentEntity.TBID = int.Parse(dataRow["TBID"].ToString());
           }
           //评论内容 nvarchar(Max)
           trainingBriefingCommentEntity.Comment = dataRow["Comment"].ToString();
           //IP地址 varchar(50)
           trainingBriefingCommentEntity.IPAdress = dataRow["IPAdress"].ToString();
           //评论的父级ID int
           if(dataRow["ParentID"].ToString() != "")
           {
              trainingBriefingCommentEntity.ParentID = int.Parse(dataRow["ParentID"].ToString());
           }
           //评论人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingBriefingCommentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //评论时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingBriefingCommentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingBriefingCommentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingBriefingCommentEntity">objTrainingBriefingCommentEntity</returns>
        public static TrainingBriefingCommentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingBriefingCommentEntity objTrainingBriefingCommentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingBriefingCommentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingBriefingCommentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingBriefingCommentEntity[]">arrayEntitys</returns>
        public static TrainingBriefingCommentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingBriefingCommentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingBriefingCommentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingBriefingCommentEntity objTrainingBriefingCommentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingBriefingCommentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}