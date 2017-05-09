using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingClassRuleEntity 的摘要说明
    ///</summary>
    public class TrainingClassRuleMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingClassRuleEntity">trainingClassRuleEntity;</returns>
        public static TrainingClassRuleEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingClassRuleEntity trainingClassRuleEntity =new TrainingClassRuleEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingClassRuleEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //子项目ID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingClassRuleEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //学段代码 varchar(50)
           trainingClassRuleEntity.GradeCode = dataRow["GradeCode"].ToString();
           //学科code varchar(50)
           trainingClassRuleEntity.SubjectCode = dataRow["SubjectCode"].ToString();
           //ClassNum int
           if(dataRow["ClassNum"].ToString() != "")
           {
              trainingClassRuleEntity.ClassNum = int.Parse(dataRow["ClassNum"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingClassRuleEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingClassRuleEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingClassRuleEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingClassRuleEntity">objTrainingClassRuleEntity</returns>
        public static TrainingClassRuleEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingClassRuleEntity objTrainingClassRuleEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingClassRuleEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingClassRuleEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingClassRuleEntity[]">arrayEntitys</returns>
        public static TrainingClassRuleEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingClassRuleEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingClassRuleEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingClassRuleEntity objTrainingClassRuleEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingClassRuleEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}