using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingDynamicEntity 的摘要说明
    ///</summary>
    public class TrainingDynamicMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingDynamicEntity">trainingDynamicEntity;</returns>
        public static TrainingDynamicEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingDynamicEntity trainingDynamicEntity =new TrainingDynamicEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              trainingDynamicEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //社区ID int
           if(dataRow["ObjectID"].ToString() != "")
           {
              trainingDynamicEntity.ObjectID = int.Parse(dataRow["ObjectID"].ToString());
           }
           //类型：1.项目 2.班级 int
           if(dataRow["MType"].ToString() != "")
           {
              trainingDynamicEntity.MType = int.Parse(dataRow["MType"].ToString());
           }
           //动态标题 nvarchar(100)
           trainingDynamicEntity.DyTitle = dataRow["DyTitle"].ToString();
           //动态类型 1-文字 2-图片 3.链接类型 （无点击率） int
           if(dataRow["DyType"].ToString() != "")
           {
              trainingDynamicEntity.DyType = int.Parse(dataRow["DyType"].ToString());
           }
           //内容 nvarchar(Max)
           trainingDynamicEntity.DyContent = dataRow["DyContent"].ToString();
           //当DyType为3链接时 存放link url nvarchar(200)
           trainingDynamicEntity.DyLink = dataRow["DyLink"].ToString();
           //当DyType为2图片和图片广告4时 存放图片的 url nvarchar(200)
           trainingDynamicEntity.DyPicUrl = dataRow["DyPicUrl"].ToString();
           //动态状态 1-正常 2-删除 int
           if(dataRow["DState"].ToString() != "")
           {
              trainingDynamicEntity.DState = int.Parse(dataRow["DState"].ToString());
           }
           //点击率 int
           if(dataRow["CilckNum"].ToString() != "")
           {
              trainingDynamicEntity.CilckNum = int.Parse(dataRow["CilckNum"].ToString());
           }
           //StaticUrl nvarchar(200)
           trainingDynamicEntity.StaticUrl = dataRow["StaticUrl"].ToString();
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingDynamicEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingDynamicEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingDynamicEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingDynamicEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingDynamicEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingDynamicEntity">objTrainingDynamicEntity</returns>
        public static TrainingDynamicEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingDynamicEntity objTrainingDynamicEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingDynamicEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingDynamicEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingDynamicEntity[]">arrayEntitys</returns>
        public static TrainingDynamicEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingDynamicEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingDynamicEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingDynamicEntity objTrainingDynamicEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingDynamicEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}