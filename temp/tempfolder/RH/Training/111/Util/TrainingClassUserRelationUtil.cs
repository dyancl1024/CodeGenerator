using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingClassUserRelationEntity 的摘要说明
    ///</summary>
    public class TrainingClassUserRelationMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingClassUserRelationEntity">trainingClassUserRelationEntity;</returns>
        public static TrainingClassUserRelationEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingClassUserRelationEntity trainingClassUserRelationEntity =new TrainingClassUserRelationEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              trainingClassUserRelationEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //用户id int
           if(dataRow["UserID"].ToString() != "")
           {
              trainingClassUserRelationEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //工作坊id（班级） int
           if(dataRow["ClassID"].ToString() != "")
           {
              trainingClassUserRelationEntity.ClassID = int.Parse(dataRow["ClassID"].ToString());
           }
           //项目id int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingClassUserRelationEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //导入人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingClassUserRelationEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //导入时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingClassUserRelationEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingClassUserRelationEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingClassUserRelationEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingClassUserRelationEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingClassUserRelationEntity">objTrainingClassUserRelationEntity</returns>
        public static TrainingClassUserRelationEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingClassUserRelationEntity objTrainingClassUserRelationEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingClassUserRelationEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingClassUserRelationEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingClassUserRelationEntity[]">arrayEntitys</returns>
        public static TrainingClassUserRelationEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingClassUserRelationEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingClassUserRelationEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingClassUserRelationEntity objTrainingClassUserRelationEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingClassUserRelationEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}