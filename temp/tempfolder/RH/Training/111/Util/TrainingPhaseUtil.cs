using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingPhaseEntity 的摘要说明
    ///</summary>
    public class TrainingPhaseMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingPhaseEntity">trainingPhaseEntity;</returns>
        public static TrainingPhaseEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingPhaseEntity trainingPhaseEntity =new TrainingPhaseEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingPhaseEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //SubTID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingPhaseEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //1 课程学时 2.作业学时 int
           if(dataRow["PType"].ToString() != "")
           {
              trainingPhaseEntity.PType = int.Parse(dataRow["PType"].ToString());
           }
           //作业名称 nvarchar(50)
           trainingPhaseEntity.HomeName = dataRow["HomeName"].ToString();
           //作业描述 nvarchar(200)
           trainingPhaseEntity.HomeWorkDesc = dataRow["HomeWorkDesc"].ToString();
           //作业类型：表RH_TrainingHomeWorkType varchar(50)
           trainingPhaseEntity.HomeWorkCode = dataRow["HomeWorkCode"].ToString();
           //Phase int
           if(dataRow["Phase"].ToString() != "")
           {
              trainingPhaseEntity.Phase = int.Parse(dataRow["Phase"].ToString());
           }
           //导入人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingPhaseEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //导入时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingPhaseEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingPhaseEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingPhaseEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingPhaseEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingPhaseEntity">objTrainingPhaseEntity</returns>
        public static TrainingPhaseEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingPhaseEntity objTrainingPhaseEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingPhaseEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingPhaseEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingPhaseEntity[]">arrayEntitys</returns>
        public static TrainingPhaseEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingPhaseEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingPhaseEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingPhaseEntity objTrainingPhaseEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingPhaseEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}