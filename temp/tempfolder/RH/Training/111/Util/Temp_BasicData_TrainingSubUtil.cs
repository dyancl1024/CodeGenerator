using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///Temp_BasicData_TrainingSubEntity 的摘要说明
    ///</summary>
    public class Temp_BasicData_TrainingSubMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="Temp_BasicData_TrainingSubEntity">temp_BasicData_TrainingSubEntity;</returns>
        public static Temp_BasicData_TrainingSubEntity ParseDataRowToEntity(DataRow dataRow)
        {
           Temp_BasicData_TrainingSubEntity temp_BasicData_TrainingSubEntity =new Temp_BasicData_TrainingSubEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //tid int
           if(dataRow["tid"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.tid = int.Parse(dataRow["tid"].ToString());
           }
           //SubTID int
           if(dataRow["SubTID"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //TeacherNum int
           if(dataRow["TeacherNum"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.TeacherNum = int.Parse(dataRow["TeacherNum"].ToString());
           }
           //班级数量 int
           if(dataRow["ClassNum"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.ClassNum = int.Parse(dataRow["ClassNum"].ToString());
           }
           //合格人数 int
           if(dataRow["FinishedNum"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.FinishedNum = int.Parse(dataRow["FinishedNum"].ToString());
           }
           //学习人数 int
           if(dataRow["StudyNum"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.StudyNum = int.Parse(dataRow["StudyNum"].ToString());
           }
           //学员总数 int
           if(dataRow["UserNum"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.UserNum = int.Parse(dataRow["UserNum"].ToString());
           }
           //合格率 decimal(6,2)
           if(dataRow["FinishedRate"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.FinishedRate = decimal.Parse(dataRow["FinishedRate"].ToString());
           }
           //学习率 decimal(6,2)
           if(dataRow["StudyRate"].ToString() != "")
           {
              temp_BasicData_TrainingSubEntity.StudyRate = decimal.Parse(dataRow["StudyRate"].ToString());
           }
           
           return temp_BasicData_TrainingSubEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="Temp_BasicData_TrainingSubEntity">objTemp_BasicData_TrainingSubEntity</returns>
        public static Temp_BasicData_TrainingSubEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           Temp_BasicData_TrainingSubEntity objTemp_BasicData_TrainingSubEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTemp_BasicData_TrainingSubEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTemp_BasicData_TrainingSubEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="Temp_BasicData_TrainingSubEntity[]">arrayEntitys</returns>
        public static Temp_BasicData_TrainingSubEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           Temp_BasicData_TrainingSubEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new Temp_BasicData_TrainingSubEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    Temp_BasicData_TrainingSubEntity objTemp_BasicData_TrainingSubEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTemp_BasicData_TrainingSubEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}