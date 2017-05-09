using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingExcellentEntity 的摘要说明
    ///</summary>
    public class TrainingExcellentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingExcellentEntity">trainingExcellentEntity;</returns>
        public static TrainingExcellentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingExcellentEntity trainingExcellentEntity =new TrainingExcellentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingExcellentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //TID int
           if(dataRow["TID"].ToString() != "")
           {
              trainingExcellentEntity.TID = int.Parse(dataRow["TID"].ToString());
           }
           //UserID int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingExcellentEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //项目评优表:1.学员2.辅导老师 int
           if(dataRow["Ttype"].ToString() != "")
           {
              trainingExcellentEntity.Ttype = int.Parse(dataRow["Ttype"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingExcellentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingExcellentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingExcellentEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingExcellentEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingExcellentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingExcellentEntity">objTrainingExcellentEntity</returns>
        public static TrainingExcellentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingExcellentEntity objTrainingExcellentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingExcellentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingExcellentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingExcellentEntity[]">arrayEntitys</returns>
        public static TrainingExcellentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingExcellentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingExcellentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingExcellentEntity objTrainingExcellentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingExcellentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}