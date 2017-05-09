using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingExpertEntity 的摘要说明
    ///</summary>
    public class TrainingExpertMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingExpertEntity">trainingExpertEntity;</returns>
        public static TrainingExpertEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingExpertEntity trainingExpertEntity =new TrainingExpertEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingExpertEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //TID int
           if(dataRow["TID"].ToString() != "")
           {
              trainingExpertEntity.TID = int.Parse(dataRow["TID"].ToString());
           }
           //SubTID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingExpertEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //UserID int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingExpertEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingExpertEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingExpertEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingExpertEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingExpertEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingExpertEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingExpertEntity">objTrainingExpertEntity</returns>
        public static TrainingExpertEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingExpertEntity objTrainingExpertEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingExpertEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingExpertEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingExpertEntity[]">arrayEntitys</returns>
        public static TrainingExpertEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingExpertEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingExpertEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingExpertEntity objTrainingExpertEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingExpertEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}