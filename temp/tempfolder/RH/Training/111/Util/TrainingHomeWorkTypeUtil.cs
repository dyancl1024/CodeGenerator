using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingHomeWorkTypeEntity 的摘要说明
    ///</summary>
    public class TrainingHomeWorkTypeMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingHomeWorkTypeEntity">trainingHomeWorkTypeEntity;</returns>
        public static TrainingHomeWorkTypeEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingHomeWorkTypeEntity trainingHomeWorkTypeEntity =new TrainingHomeWorkTypeEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingHomeWorkTypeEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //Name nvarchar(50)
           trainingHomeWorkTypeEntity.Name = dataRow["Name"].ToString();
           //Code varchar(50)
           trainingHomeWorkTypeEntity.Code = dataRow["Code"].ToString();
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              trainingHomeWorkTypeEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           
           return trainingHomeWorkTypeEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingHomeWorkTypeEntity">objTrainingHomeWorkTypeEntity</returns>
        public static TrainingHomeWorkTypeEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingHomeWorkTypeEntity objTrainingHomeWorkTypeEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingHomeWorkTypeEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingHomeWorkTypeEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingHomeWorkTypeEntity[]">arrayEntitys</returns>
        public static TrainingHomeWorkTypeEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingHomeWorkTypeEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingHomeWorkTypeEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingHomeWorkTypeEntity objTrainingHomeWorkTypeEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingHomeWorkTypeEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}