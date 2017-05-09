using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingClassOfTeacherEntity 的摘要说明
    ///</summary>
    public class TrainingClassOfTeacherMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingClassOfTeacherEntity">trainingClassOfTeacherEntity;</returns>
        public static TrainingClassOfTeacherEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingClassOfTeacherEntity trainingClassOfTeacherEntity =new TrainingClassOfTeacherEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              trainingClassOfTeacherEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //班级id  RH_Class int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingClassOfTeacherEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //ClassID int
           if(dataRow["ClassID"].ToString() != "")
           {
              trainingClassOfTeacherEntity.ClassID = int.Parse(dataRow["ClassID"].ToString());
           }
           //辅导老师id RH_User表 int
           if(dataRow["TeacherID"].ToString() != "")
           {
              trainingClassOfTeacherEntity.TeacherID = int.Parse(dataRow["TeacherID"].ToString());
           }
           //任命人 对应RH_User表id int
           if(dataRow["Appointer"].ToString() != "")
           {
              trainingClassOfTeacherEntity.Appointer = int.Parse(dataRow["Appointer"].ToString());
           }
           //任命时间 datetime
           if(dataRow["AppointTime"].ToString() != "")
           {
              trainingClassOfTeacherEntity.AppointTime = DateTime.Parse(dataRow["AppointTime"].ToString());
           }
           
           return trainingClassOfTeacherEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingClassOfTeacherEntity">objTrainingClassOfTeacherEntity</returns>
        public static TrainingClassOfTeacherEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingClassOfTeacherEntity objTrainingClassOfTeacherEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingClassOfTeacherEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingClassOfTeacherEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingClassOfTeacherEntity[]">arrayEntitys</returns>
        public static TrainingClassOfTeacherEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingClassOfTeacherEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingClassOfTeacherEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingClassOfTeacherEntity objTrainingClassOfTeacherEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingClassOfTeacherEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}