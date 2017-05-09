using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingTeacherSummaryEntity 的摘要说明
    ///</summary>
    public class TrainingTeacherSummaryMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingTeacherSummaryEntity">trainingTeacherSummaryEntity;</returns>
        public static TrainingTeacherSummaryEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingTeacherSummaryEntity trainingTeacherSummaryEntity =new TrainingTeacherSummaryEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingTeacherSummaryEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //总项目id int
           if(dataRow["TID"].ToString() != "")
           {
              trainingTeacherSummaryEntity.TID = int.Parse(dataRow["TID"].ToString());
           }
           //阶段项目id int
           if(dataRow["SubTID"].ToString() != "")
           {
              trainingTeacherSummaryEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //总结类型：1.辅导老师工作总结 2.项目总结（挂在总项目下，教务的操作） int
           if(dataRow["Ttype"].ToString() != "")
           {
              trainingTeacherSummaryEntity.Ttype = int.Parse(dataRow["Ttype"].ToString());
           }
           //TeacherSummaryTitle nvarchar(50)
           trainingTeacherSummaryEntity.TeacherSummaryTitle = dataRow["TeacherSummaryTitle"].ToString();
           //TeacherSummaryContent nvarchar(Max)
           trainingTeacherSummaryEntity.TeacherSummaryContent = dataRow["TeacherSummaryContent"].ToString();
           //静态访问地址 nvarchar(200)
           trainingTeacherSummaryEntity.StaticUrl = dataRow["StaticUrl"].ToString();
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingTeacherSummaryEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //发布时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingTeacherSummaryEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingTeacherSummaryEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingTeacherSummaryEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingTeacherSummaryEntity">objTrainingTeacherSummaryEntity</returns>
        public static TrainingTeacherSummaryEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingTeacherSummaryEntity objTrainingTeacherSummaryEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingTeacherSummaryEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingTeacherSummaryEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingTeacherSummaryEntity[]">arrayEntitys</returns>
        public static TrainingTeacherSummaryEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingTeacherSummaryEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingTeacherSummaryEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingTeacherSummaryEntity objTrainingTeacherSummaryEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingTeacherSummaryEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}