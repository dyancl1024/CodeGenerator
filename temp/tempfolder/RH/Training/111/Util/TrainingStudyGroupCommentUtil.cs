using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingStudyGroupCommentEntity 的摘要说明
    ///</summary>
    public class TrainingStudyGroupCommentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingStudyGroupCommentEntity">trainingStudyGroupCommentEntity;</returns>
        public static TrainingStudyGroupCommentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingStudyGroupCommentEntity trainingStudyGroupCommentEntity =new TrainingStudyGroupCommentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingStudyGroupCommentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //StudyGroupID int
           if(dataRow["StudyGroupID"].ToString() != "")
           {
              trainingStudyGroupCommentEntity.StudyGroupID = int.Parse(dataRow["StudyGroupID"].ToString());
           }
           //CommentTitile nvarchar(50)
           trainingStudyGroupCommentEntity.CommentTitile = dataRow["CommentTitile"].ToString();
           //评论内容 nvarchar(Max)
           trainingStudyGroupCommentEntity.Comment = dataRow["Comment"].ToString();
           //IP地址 varchar(50)
           trainingStudyGroupCommentEntity.IPAdress = dataRow["IPAdress"].ToString();
           //评论的父级ID int
           if(dataRow["ParentID"].ToString() != "")
           {
              trainingStudyGroupCommentEntity.ParentID = int.Parse(dataRow["ParentID"].ToString());
           }
           //1.专家2.非专家 int
           if(dataRow["IsExpert"].ToString() != "")
           {
              trainingStudyGroupCommentEntity.IsExpert = int.Parse(dataRow["IsExpert"].ToString());
           }
           //评论人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingStudyGroupCommentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //评论时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingStudyGroupCommentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingStudyGroupCommentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingStudyGroupCommentEntity">objTrainingStudyGroupCommentEntity</returns>
        public static TrainingStudyGroupCommentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingStudyGroupCommentEntity objTrainingStudyGroupCommentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingStudyGroupCommentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingStudyGroupCommentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingStudyGroupCommentEntity[]">arrayEntitys</returns>
        public static TrainingStudyGroupCommentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingStudyGroupCommentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingStudyGroupCommentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingStudyGroupCommentEntity objTrainingStudyGroupCommentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingStudyGroupCommentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}