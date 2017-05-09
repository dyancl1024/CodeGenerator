using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingTypeEntity 的摘要说明
    ///</summary>
    public class TrainingTypeMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingTypeEntity">trainingTypeEntity;</returns>
        public static TrainingTypeEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingTypeEntity trainingTypeEntity =new TrainingTypeEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingTypeEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //Name nvarchar(50)
           trainingTypeEntity.Name = dataRow["Name"].ToString();
           //Code nvarchar(50)
           trainingTypeEntity.Code = dataRow["Code"].ToString();
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              trainingTypeEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           
           return trainingTypeEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingTypeEntity">objTrainingTypeEntity</returns>
        public static TrainingTypeEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingTypeEntity objTrainingTypeEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingTypeEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingTypeEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingTypeEntity[]">arrayEntitys</returns>
        public static TrainingTypeEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingTypeEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingTypeEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingTypeEntity objTrainingTypeEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingTypeEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}