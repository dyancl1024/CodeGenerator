using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingSubSubjectEntity 的摘要说明
    ///</summary>
    public class TrainingSubSubjectMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingSubSubjectEntity">trainingSubSubjectEntity;</returns>
        public static TrainingSubSubjectEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingSubSubjectEntity trainingSubSubjectEntity =new TrainingSubSubjectEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingSubSubjectEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //SubTID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingSubSubjectEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //GradeCode varchar(50)
           trainingSubSubjectEntity.GradeCode = dataRow["GradeCode"].ToString();
           //SubjectCode varchar(50)
           trainingSubSubjectEntity.SubjectCode = dataRow["SubjectCode"].ToString();
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingSubSubjectEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingSubSubjectEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return trainingSubSubjectEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingSubSubjectEntity">objTrainingSubSubjectEntity</returns>
        public static TrainingSubSubjectEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingSubSubjectEntity objTrainingSubSubjectEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingSubSubjectEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingSubSubjectEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingSubSubjectEntity[]">arrayEntitys</returns>
        public static TrainingSubSubjectEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingSubSubjectEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingSubSubjectEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingSubSubjectEntity objTrainingSubSubjectEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingSubSubjectEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}