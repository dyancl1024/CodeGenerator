using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingMyCourseRecordEntity 的摘要说明
    ///</summary>
    public class TrainingMyCourseRecordMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingMyCourseRecordEntity">trainingMyCourseRecordEntity;</returns>
        public static TrainingMyCourseRecordEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingMyCourseRecordEntity trainingMyCourseRecordEntity =new TrainingMyCourseRecordEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              trainingMyCourseRecordEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //人员ID int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingMyCourseRecordEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //项目id int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingMyCourseRecordEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //套餐ID int
           if(dataRow["PCID"].ToString() != "")
           {
              trainingMyCourseRecordEntity.PCID = int.Parse(dataRow["PCID"].ToString());
           }
           //课程id int
           if(dataRow["CourseID"].ToString() != "")
           {
              trainingMyCourseRecordEntity.CourseID = int.Parse(dataRow["CourseID"].ToString());
           }
           //当前已观看时间 int
           if(dataRow["WatchTime"].ToString() != "")
           {
              trainingMyCourseRecordEntity.WatchTime = int.Parse(dataRow["WatchTime"].ToString());
           }
           //总共观看时间 int
           if(dataRow["TotalWatchTime"].ToString() != "")
           {
              trainingMyCourseRecordEntity.TotalWatchTime = int.Parse(dataRow["TotalWatchTime"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingMyCourseRecordEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingMyCourseRecordEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingMyCourseRecordEntity">objTrainingMyCourseRecordEntity</returns>
        public static TrainingMyCourseRecordEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingMyCourseRecordEntity objTrainingMyCourseRecordEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingMyCourseRecordEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingMyCourseRecordEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingMyCourseRecordEntity[]">arrayEntitys</returns>
        public static TrainingMyCourseRecordEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingMyCourseRecordEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingMyCourseRecordEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingMyCourseRecordEntity objTrainingMyCourseRecordEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingMyCourseRecordEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}