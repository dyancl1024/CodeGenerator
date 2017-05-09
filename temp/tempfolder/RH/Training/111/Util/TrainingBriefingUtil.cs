using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingBriefingEntity 的摘要说明
    ///</summary>
    public class TrainingBriefingMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingBriefingEntity">trainingBriefingEntity;</returns>
        public static TrainingBriefingEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingBriefingEntity trainingBriefingEntity =new TrainingBriefingEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingBriefingEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //项目id int
           if(dataRow["ObjectID"].ToString() != "")
           {
              trainingBriefingEntity.ObjectID = int.Parse(dataRow["ObjectID"].ToString());
           }
           //1.项目 2.班级 int
           if(dataRow["MType"].ToString() != "")
           {
              trainingBriefingEntity.MType = int.Parse(dataRow["MType"].ToString());
           }
           //期数 录入 nvarchar(50)
           trainingBriefingEntity.Periods = dataRow["Periods"].ToString();
           //标题 nvarchar(200)
           trainingBriefingEntity.Title = dataRow["Title"].ToString();
           //内容 nvarchar(Max)
           trainingBriefingEntity.BContnet = dataRow["BContnet"].ToString();
           //ClickNum int
           if(dataRow["ClickNum"].ToString() != "")
           {
              trainingBriefingEntity.ClickNum = int.Parse(dataRow["ClickNum"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingBriefingEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //发布时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingBriefingEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingBriefingEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingBriefingEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           //StaticUrl nvarchar(200)
           trainingBriefingEntity.StaticUrl = dataRow["StaticUrl"].ToString();
           
           return trainingBriefingEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingBriefingEntity">objTrainingBriefingEntity</returns>
        public static TrainingBriefingEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingBriefingEntity objTrainingBriefingEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingBriefingEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingBriefingEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingBriefingEntity[]">arrayEntitys</returns>
        public static TrainingBriefingEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingBriefingEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingBriefingEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingBriefingEntity objTrainingBriefingEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingBriefingEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}