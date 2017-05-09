using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingEntity 的摘要说明
    ///</summary>
    public class TrainingMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingEntity">trainingEntity;</returns>
        public static TrainingEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingEntity trainingEntity =new TrainingEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //社区id int
           if(dataRow["DesignID"].ToString() != "")
           {
              trainingEntity.DesignID = int.Parse(dataRow["DesignID"].ToString());
           }
           //项目名称 nvarchar(200)
           trainingEntity.TName = dataRow["TName"].ToString();
           //学时 int
           if(dataRow["TrainingPhase"].ToString() != "")
           {
              trainingEntity.TrainingPhase = int.Parse(dataRow["TrainingPhase"].ToString());
           }
           //项目名称 int
           if(dataRow["TrainingNum"].ToString() != "")
           {
              trainingEntity.TrainingNum = int.Parse(dataRow["TrainingNum"].ToString());
           }
           //承担机构id 对应表FJ_TrainingOrg的ID varchar(50)
           trainingEntity.TrainingLevelCode = dataRow["TrainingLevelCode"].ToString();
           //TrainingTypeCode varchar(50)
           trainingEntity.TrainingTypeCode = dataRow["TrainingTypeCode"].ToString();
           //ProvinceID int
           if(dataRow["ProvinceID"].ToString() != "")
           {
              trainingEntity.ProvinceID = int.Parse(dataRow["ProvinceID"].ToString());
           }
           //CityID int
           if(dataRow["CityID"].ToString() != "")
           {
              trainingEntity.CityID = int.Parse(dataRow["CityID"].ToString());
           }
           //DistrictID int
           if(dataRow["DistrictID"].ToString() != "")
           {
              trainingEntity.DistrictID = int.Parse(dataRow["DistrictID"].ToString());
           }
           //时间安排起 datetime
           if(dataRow["TrainingDateB"].ToString() != "")
           {
              trainingEntity.TrainingDateB = DateTime.Parse(dataRow["TrainingDateB"].ToString());
           }
           //时间安排止 datetime
           if(dataRow["TrainingDateE"].ToString() != "")
           {
              trainingEntity.TrainingDateE = DateTime.Parse(dataRow["TrainingDateE"].ToString());
           }
           //是否阶段项目 1 是 2 否 int
           if(dataRow["IsStage"].ToString() != "")
           {
              trainingEntity.IsStage = int.Parse(dataRow["IsStage"].ToString());
           }
           //TrainingUrl varchar(200)
           trainingEntity.TrainingUrl = dataRow["TrainingUrl"].ToString();
           //项目编码 varchar(50)
           trainingEntity.TrainingCode = dataRow["TrainingCode"].ToString();
           //TrainingHeadImg varchar(200)
           trainingEntity.TrainingHeadImg = dataRow["TrainingHeadImg"].ToString();
           //StaticUrl nvarchar(200)
           trainingEntity.StaticUrl = dataRow["StaticUrl"].ToString();
           //1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除 int
           if(dataRow["Status"].ToString() != "")
           {
              trainingEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           //发布人 int
           if(dataRow["Publisher"].ToString() != "")
           {
              trainingEntity.Publisher = int.Parse(dataRow["Publisher"].ToString());
           }
           //发布时间 datetime
           if(dataRow["PublishDate"].ToString() != "")
           {
              trainingEntity.PublishDate = DateTime.Parse(dataRow["PublishDate"].ToString());
           }
           
           return trainingEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingEntity">objTrainingEntity</returns>
        public static TrainingEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingEntity objTrainingEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingEntity[]">arrayEntitys</returns>
        public static TrainingEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingEntity objTrainingEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}