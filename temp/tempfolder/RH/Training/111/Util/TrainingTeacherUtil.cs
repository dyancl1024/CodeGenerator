using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingTeacherEntity 的摘要说明
    ///</summary>
    public class TrainingTeacherMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingTeacherEntity">trainingTeacherEntity;</returns>
        public static TrainingTeacherEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingTeacherEntity trainingTeacherEntity =new TrainingTeacherEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingTeacherEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //用户id int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingTeacherEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //项目id int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingTeacherEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //导入人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingTeacherEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //导入时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingTeacherEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingTeacherEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingTeacherEntity">objTrainingTeacherEntity</returns>
        public static TrainingTeacherEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingTeacherEntity objTrainingTeacherEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingTeacherEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingTeacherEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingTeacherEntity[]">arrayEntitys</returns>
        public static TrainingTeacherEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingTeacherEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingTeacherEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingTeacherEntity objTrainingTeacherEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingTeacherEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}