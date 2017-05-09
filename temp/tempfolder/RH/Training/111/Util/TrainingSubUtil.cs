using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingSubEntity 的摘要说明
    ///</summary>
    public class TrainingSubMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingSubEntity">trainingSubEntity;</returns>
        public static TrainingSubEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingSubEntity trainingSubEntity =new TrainingSubEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingSubEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //主项目ID int
           if(dataRow["TID"].ToString() != "")
           {
              trainingSubEntity.TID = int.Parse(dataRow["TID"].ToString());
           }
           //项目名称 nvarchar(200)
           trainingSubEntity.TName = dataRow["TName"].ToString();
           //项目名称 int
           if(dataRow["TrainingNum"].ToString() != "")
           {
              trainingSubEntity.TrainingNum = int.Parse(dataRow["TrainingNum"].ToString());
           }
           //承担机构id 对应表FJ_TrainingOrg的ID varchar(50)
           trainingSubEntity.TrainingLevelCode = dataRow["TrainingLevelCode"].ToString();
           //TrainingTypeCode varchar(50)
           trainingSubEntity.TrainingTypeCode = dataRow["TrainingTypeCode"].ToString();
           //研修方式：1.网络培训 2.现场培训 3.能力提升 int
           if(dataRow["TMethod"].ToString() != "")
           {
              trainingSubEntity.TMethod = int.Parse(dataRow["TMethod"].ToString());
           }
           //是否国培 1 是 2 否 int
           if(dataRow["IsGP"].ToString() != "")
           {
              trainingSubEntity.IsGP = int.Parse(dataRow["IsGP"].ToString());
           }
           //OrgCode varchar(50)
           trainingSubEntity.OrgCode = dataRow["OrgCode"].ToString();
           //时间安排起 datetime
           if(dataRow["TrainingDateB"].ToString() != "")
           {
              trainingSubEntity.TrainingDateB = DateTime.Parse(dataRow["TrainingDateB"].ToString());
           }
           //时间安排止 datetime
           if(dataRow["TrainingDateE"].ToString() != "")
           {
              trainingSubEntity.TrainingDateE = DateTime.Parse(dataRow["TrainingDateE"].ToString());
           }
           //报名规则：1.导入报名 2.自主报名 int
           if(dataRow["SignupRule"].ToString() != "")
           {
              trainingSubEntity.SignupRule = int.Parse(dataRow["SignupRule"].ToString());
           }
           //分班规则：1.规则分班 2.人工分班 nchar(10)
           trainingSubEntity.ClassRule = dataRow["ClassRule"].ToString();
           //是否阶段项目 1 是 2 否 int
           if(dataRow["IsStage"].ToString() != "")
           {
              trainingSubEntity.IsStage = int.Parse(dataRow["IsStage"].ToString());
           }
           //TrainingUrl varchar(200)
           trainingSubEntity.TrainingUrl = dataRow["TrainingUrl"].ToString();
           //TrainingHeadImg varchar(200)
           trainingSubEntity.TrainingHeadImg = dataRow["TrainingHeadImg"].ToString();
           //StaticUrl nvarchar(200)
           trainingSubEntity.StaticUrl = dataRow["StaticUrl"].ToString();
           //1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除 int
           if(dataRow["Status"].ToString() != "")
           {
              trainingSubEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //咨询电话 varchar(50)
           trainingSubEntity.AskTel = dataRow["AskTel"].ToString();
           //是否显示在线客服 1 是 2 否 int
           if(dataRow["IsShowQQ"].ToString() != "")
           {
              trainingSubEntity.IsShowQQ = int.Parse(dataRow["IsShowQQ"].ToString());
           }
           //测评工具 1内部 2外部 int
           if(dataRow["TestMethod"].ToString() != "")
           {
              trainingSubEntity.TestMethod = int.Parse(dataRow["TestMethod"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingSubEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingSubEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingSubEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingSubEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           //发布人 int
           if(dataRow["Publisher"].ToString() != "")
           {
              trainingSubEntity.Publisher = int.Parse(dataRow["Publisher"].ToString());
           }
           //发布时间 datetime
           if(dataRow["PublishDate"].ToString() != "")
           {
              trainingSubEntity.PublishDate = DateTime.Parse(dataRow["PublishDate"].ToString());
           }
           
           return trainingSubEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingSubEntity">objTrainingSubEntity</returns>
        public static TrainingSubEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingSubEntity objTrainingSubEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingSubEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingSubEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingSubEntity[]">arrayEntitys</returns>
        public static TrainingSubEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingSubEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingSubEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingSubEntity objTrainingSubEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingSubEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}