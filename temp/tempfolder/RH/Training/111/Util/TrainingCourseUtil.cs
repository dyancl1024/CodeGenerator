using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingCourseEntity 的摘要说明
    ///</summary>
    public class TrainingCourseMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingCourseEntity">trainingCourseEntity;</returns>
        public static TrainingCourseEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingCourseEntity trainingCourseEntity =new TrainingCourseEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingCourseEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //预设ID int
           if(dataRow["PresetID"].ToString() != "")
           {
              trainingCourseEntity.PresetID = int.Parse(dataRow["PresetID"].ToString());
           }
           //子项目ID int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingCourseEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //CourseID int
           if(dataRow["CourseID"].ToString() != "")
           {
              trainingCourseEntity.CourseID = int.Parse(dataRow["CourseID"].ToString());
           }
           //是否必修 1-是 0-否 int
           if(dataRow["IfRequired"].ToString() != "")
           {
              trainingCourseEntity.IfRequired = int.Parse(dataRow["IfRequired"].ToString());
           }
           //课程学时 int
           if(dataRow["CPharse"].ToString() != "")
           {
              trainingCourseEntity.CPharse = int.Parse(dataRow["CPharse"].ToString());
           }
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              trainingCourseEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingCourseEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingCourseEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingCourseEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingCourseEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingCourseEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingCourseEntity">objTrainingCourseEntity</returns>
        public static TrainingCourseEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingCourseEntity objTrainingCourseEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingCourseEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingCourseEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingCourseEntity[]">arrayEntitys</returns>
        public static TrainingCourseEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingCourseEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingCourseEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingCourseEntity objTrainingCourseEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingCourseEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}