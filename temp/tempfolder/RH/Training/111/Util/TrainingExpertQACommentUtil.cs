using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingExpertQACommentEntity 的摘要说明
    ///</summary>
    public class TrainingExpertQACommentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingExpertQACommentEntity">trainingExpertQACommentEntity;</returns>
        public static TrainingExpertQACommentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingExpertQACommentEntity trainingExpertQACommentEntity =new TrainingExpertQACommentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingExpertQACommentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //QAID int
           if(dataRow["QAID"].ToString() != "")
           {
              trainingExpertQACommentEntity.QAID = int.Parse(dataRow["QAID"].ToString());
           }
           //Comment nvarchar(Max)
           trainingExpertQACommentEntity.Comment = dataRow["Comment"].ToString();
           //IPAdress varchar(50)
           trainingExpertQACommentEntity.IPAdress = dataRow["IPAdress"].ToString();
           //ParentID int
           if(dataRow["ParentID"].ToString() != "")
           {
              trainingExpertQACommentEntity.ParentID = int.Parse(dataRow["ParentID"].ToString());
           }
           //是否专家回答 1.是 2.否 int
           if(dataRow["IsExpert"].ToString() != "")
           {
              trainingExpertQACommentEntity.IsExpert = int.Parse(dataRow["IsExpert"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingExpertQACommentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingExpertQACommentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingExpertQACommentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingExpertQACommentEntity">objTrainingExpertQACommentEntity</returns>
        public static TrainingExpertQACommentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingExpertQACommentEntity objTrainingExpertQACommentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingExpertQACommentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingExpertQACommentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingExpertQACommentEntity[]">arrayEntitys</returns>
        public static TrainingExpertQACommentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingExpertQACommentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingExpertQACommentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingExpertQACommentEntity objTrainingExpertQACommentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingExpertQACommentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}