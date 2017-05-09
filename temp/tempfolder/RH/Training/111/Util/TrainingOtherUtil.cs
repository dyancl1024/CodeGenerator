using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingOtherEntity 的摘要说明
    ///</summary>
    public class TrainingOtherMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingOtherEntity">trainingOtherEntity;</returns>
        public static TrainingOtherEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingOtherEntity trainingOtherEntity =new TrainingOtherEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingOtherEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //TID int
           if(dataRow["TID"].ToString() != "")
           {
              trainingOtherEntity.TID = int.Parse(dataRow["TID"].ToString());
           }
           //SubTID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingOtherEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //TTitle nvarchar(50)
           trainingOtherEntity.TTitle = dataRow["TTitle"].ToString();
           //项目附属信息  1.项目考核方案 2.学员手册 3.辅导老师手册 4.项目实施方案 int
           if(dataRow["TType"].ToString() != "")
           {
              trainingOtherEntity.TType = int.Parse(dataRow["TType"].ToString());
           }
           //TContent nvarchar(Max)
           trainingOtherEntity.TContent = dataRow["TContent"].ToString();
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingOtherEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingOtherEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingOtherEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingOtherEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingOtherEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingOtherEntity">objTrainingOtherEntity</returns>
        public static TrainingOtherEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingOtherEntity objTrainingOtherEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingOtherEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingOtherEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingOtherEntity[]">arrayEntitys</returns>
        public static TrainingOtherEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingOtherEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingOtherEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingOtherEntity objTrainingOtherEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingOtherEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}