using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingEducationerEntity 的摘要说明
    ///</summary>
    public class TrainingEducationerMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingEducationerEntity">trainingEducationerEntity;</returns>
        public static TrainingEducationerEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingEducationerEntity trainingEducationerEntity =new TrainingEducationerEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingEducationerEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //阶段项目id int
           if(dataRow["DesignID"].ToString() != "")
           {
              trainingEducationerEntity.DesignID = int.Parse(dataRow["DesignID"].ToString());
           }
           //用户id int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingEducationerEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingEducationerEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingEducationerEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingEducationerEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingEducationerEntity">objTrainingEducationerEntity</returns>
        public static TrainingEducationerEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingEducationerEntity objTrainingEducationerEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingEducationerEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingEducationerEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingEducationerEntity[]">arrayEntitys</returns>
        public static TrainingEducationerEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingEducationerEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingEducationerEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingEducationerEntity objTrainingEducationerEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingEducationerEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}