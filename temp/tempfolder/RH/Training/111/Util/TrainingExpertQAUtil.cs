using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///TrainingExpertQAEntity 的摘要说明
    ///</summary>
    public class TrainingExpertQAMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="TrainingExpertQAEntity">trainingExpertQAEntity;</returns>
        public static TrainingExpertQAEntity ParseDataRowToEntity(DataRow dataRow)
        {
           TrainingExpertQAEntity trainingExpertQAEntity =new TrainingExpertQAEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              trainingExpertQAEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //项目id int
           if(dataRow["TID"].ToString() != "")
           {
              trainingExpertQAEntity.TID = int.Parse(dataRow["TID"].ToString());
           }
           //答疑标题 nvarchar(50)
           trainingExpertQAEntity.QATitle = dataRow["QATitle"].ToString();
           //答疑内容 nvarchar(Max)
           trainingExpertQAEntity.QAContent = dataRow["QAContent"].ToString();
           //点击率 int
           if(dataRow["ClickNum"].ToString() != "")
           {
              trainingExpertQAEntity.ClickNum = int.Parse(dataRow["ClickNum"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              trainingExpertQAEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //创建时间 datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              trainingExpertQAEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              trainingExpertQAEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //更新时间 datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              trainingExpertQAEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return trainingExpertQAEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingExpertQAEntity">objTrainingExpertQAEntity</returns>
        public static TrainingExpertQAEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           TrainingExpertQAEntity objTrainingExpertQAEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTrainingExpertQAEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTrainingExpertQAEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="TrainingExpertQAEntity[]">arrayEntitys</returns>
        public static TrainingExpertQAEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           TrainingExpertQAEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new TrainingExpertQAEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    TrainingExpertQAEntity objTrainingExpertQAEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTrainingExpertQAEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}