using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingMyCourseEntity 的摘要说明
    ///</summary>
    public class TrainingMyCourseMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingMyCourseEntity">trainingMyCourseEntity;</returns>
        public static TrainingMyCourseEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingMyCourseEntity trainingMyCourseEntity =new TrainingMyCourseEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              trainingMyCourseEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //项目id int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingMyCourseEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //套餐id，对应课程预设表 int
           if(dataRow["PCID"].ToString() != "")
           {
              trainingMyCourseEntity.PCID = int.Parse(dataRow["PCID"].ToString());
           }
           //课程id int
           if(dataRow["CID"].ToString() != "")
           {
              trainingMyCourseEntity.CID = int.Parse(dataRow["CID"].ToString());
           }
           //学员id int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingMyCourseEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //选课时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingMyCourseEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //选课状态：1.正常2.删除 int
           if(dataRow["Status"].ToString() != "")
           {
              trainingMyCourseEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           
           return trainingMyCourseEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingMyCourseEntity">objTrainingMyCourseEntity</returns>
        public static TrainingMyCourseEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingMyCourseEntity objTrainingMyCourseEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingMyCourseEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingMyCourseEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingMyCourseEntity[]">arrayEntitys</returns>
        public static TrainingMyCourseEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingMyCourseEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingMyCourseEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingMyCourseEntity objTrainingMyCourseEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingMyCourseEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}