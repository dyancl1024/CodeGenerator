using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingStudyGroupEntity 的摘要说明
    ///</summary>
    public class TrainingStudyGroupMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingStudyGroupEntity">trainingStudyGroupEntity;</returns>
        public static TrainingStudyGroupEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingStudyGroupEntity trainingStudyGroupEntity =new TrainingStudyGroupEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingStudyGroupEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //学习小组名称 nvarchar(50)
           trainingStudyGroupEntity.StudyGroupName = dataRow["StudyGroupName"].ToString();
           //阶段项目ID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingStudyGroupEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //课程ID int
           if(dataRow["CID"].ToString() != "")
           {
              trainingStudyGroupEntity.CID = int.Parse(dataRow["CID"].ToString());
           }
           //状态：1.正常2.关闭 int
           if(dataRow["Status"].ToString() != "")
           {
              trainingStudyGroupEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingStudyGroupEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //发布时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingStudyGroupEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingStudyGroupEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingStudyGroupEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingStudyGroupEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingStudyGroupEntity">objTrainingStudyGroupEntity</returns>
        public static TrainingStudyGroupEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingStudyGroupEntity objTrainingStudyGroupEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingStudyGroupEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingStudyGroupEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingStudyGroupEntity[]">arrayEntitys</returns>
        public static TrainingStudyGroupEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingStudyGroupEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingStudyGroupEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingStudyGroupEntity objTrainingStudyGroupEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingStudyGroupEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}