using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingClassEntity 的摘要说明
    ///</summary>
    public class TrainingClassMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingClassEntity">trainingClassEntity;</returns>
        public static TrainingClassEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingClassEntity trainingClassEntity =new TrainingClassEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              trainingClassEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //项目id int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingClassEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //班号 int
           if(dataRow["ClassNO"].ToString() != "")
           {
              trainingClassEntity.ClassNO = int.Parse(dataRow["ClassNO"].ToString());
           }
           //班级名称 nvarchar(50)
           trainingClassEntity.CName = dataRow["CName"].ToString();
           //学科id varchar(50)
           trainingClassEntity.SubjectCode = dataRow["SubjectCode"].ToString();
           //学段id varchar(50)
           trainingClassEntity.GradeCode = dataRow["GradeCode"].ToString();
           //StaticUrl nvarchar(200)
           trainingClassEntity.StaticUrl = dataRow["StaticUrl"].ToString();
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingClassEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //发布时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingClassEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingClassEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingClassEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingClassEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingClassEntity">objTrainingClassEntity</returns>
        public static TrainingClassEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingClassEntity objTrainingClassEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingClassEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingClassEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingClassEntity[]">arrayEntitys</returns>
        public static TrainingClassEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingClassEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingClassEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingClassEntity objTrainingClassEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingClassEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}