using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingMyHomeWorkEntity 的摘要说明
    ///</summary>
    public class TrainingMyHomeWorkMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingMyHomeWorkEntity">trainingMyHomeWorkEntity;</returns>
        public static TrainingMyHomeWorkEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingMyHomeWorkEntity trainingMyHomeWorkEntity =new TrainingMyHomeWorkEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingMyHomeWorkEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //作业标题 nvarchar(50)
           trainingMyHomeWorkEntity.HomeWorkTitle = dataRow["HomeWorkTitle"].ToString();
           //作业内容 nvarchar(Max)
           trainingMyHomeWorkEntity.HomeWorkContent = dataRow["HomeWorkContent"].ToString();
           //作业指标ID  RH_TrainingPhase int
           if(dataRow["HomeWorkPhaseID"].ToString() != "")
           {
              trainingMyHomeWorkEntity.HomeWorkPhaseID = int.Parse(dataRow["HomeWorkPhaseID"].ToString());
           }
           //阶段项目ID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingMyHomeWorkEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交） int
           if(dataRow["Status"].ToString() != "")
           {
              trainingMyHomeWorkEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //导入人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingMyHomeWorkEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //导入时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingMyHomeWorkEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingMyHomeWorkEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingMyHomeWorkEntity">objTrainingMyHomeWorkEntity</returns>
        public static TrainingMyHomeWorkEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingMyHomeWorkEntity objTrainingMyHomeWorkEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingMyHomeWorkEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingMyHomeWorkEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingMyHomeWorkEntity[]">arrayEntitys</returns>
        public static TrainingMyHomeWorkEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingMyHomeWorkEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingMyHomeWorkEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingMyHomeWorkEntity objTrainingMyHomeWorkEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingMyHomeWorkEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}