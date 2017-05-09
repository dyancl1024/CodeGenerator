using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingLevelEntity 的摘要说明
    ///</summary>
    public class TrainingLevelMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingLevelEntity">trainingLevelEntity;</returns>
        public static TrainingLevelEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingLevelEntity trainingLevelEntity =new TrainingLevelEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingLevelEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //Name nvarchar(50)
           trainingLevelEntity.Name = dataRow["Name"].ToString();
           //Code varchar(50)
           trainingLevelEntity.Code = dataRow["Code"].ToString();
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              trainingLevelEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           
           return trainingLevelEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingLevelEntity">objTrainingLevelEntity</returns>
        public static TrainingLevelEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingLevelEntity objTrainingLevelEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingLevelEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingLevelEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingLevelEntity[]">arrayEntitys</returns>
        public static TrainingLevelEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingLevelEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingLevelEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingLevelEntity objTrainingLevelEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingLevelEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}