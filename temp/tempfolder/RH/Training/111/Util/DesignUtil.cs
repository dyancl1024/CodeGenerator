using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///DesignEntity 的摘要说明
    ///</summary>
    public class DesignMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="DesignEntity">designEntity;</returns>
        public static DesignEntity ParseDataRowToEntity(DataRow dataRow)
        {
           DesignEntity designEntity =new DesignEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              designEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //社区id nvarchar(50)
           designEntity.DesignName = dataRow["DesignName"].ToString();
           //承担机构id 对应表FJ_TrainingOrg的ID varchar(50)
           designEntity.TrainingLevelCode = dataRow["TrainingLevelCode"].ToString();
           //TrainingTypeCode varchar(50)
           designEntity.TrainingTypeCode = dataRow["TrainingTypeCode"].ToString();
           //ProvinceID int
           if(dataRow["ProvinceID"].ToString() != "")
           {
              designEntity.ProvinceID = int.Parse(dataRow["ProvinceID"].ToString());
           }
           //CityID int
           if(dataRow["CityID"].ToString() != "")
           {
              designEntity.CityID = int.Parse(dataRow["CityID"].ToString());
           }
           //DistrictID int
           if(dataRow["DistrictID"].ToString() != "")
           {
              designEntity.DistrictID = int.Parse(dataRow["DistrictID"].ToString());
           }
           //OrgCode varchar(50)
           designEntity.OrgCode = dataRow["OrgCode"].ToString();
           //项目名称 int
           if(dataRow["TrainingNum"].ToString() != "")
           {
              designEntity.TrainingNum = int.Parse(dataRow["TrainingNum"].ToString());
           }
           //学时 int
           if(dataRow["TrainingPhase"].ToString() != "")
           {
              designEntity.TrainingPhase = int.Parse(dataRow["TrainingPhase"].ToString());
           }
           //时间安排起 datetime
           if(dataRow["TrainingDateB"].ToString() != "")
           {
              designEntity.TrainingDateB = DateTime.Parse(dataRow["TrainingDateB"].ToString());
           }
           //时间安排止 datetime
           if(dataRow["TrainingDateE"].ToString() != "")
           {
              designEntity.TrainingDateE = DateTime.Parse(dataRow["TrainingDateE"].ToString());
           }
           //DesignDesc nvarchar(Max)
           designEntity.DesignDesc = dataRow["DesignDesc"].ToString();
           //1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.不通过（对应的动作提交审批） 5.立项（对应的动作分配教务） 6.不立项（对应的动作分配教务） int
           if(dataRow["Status"].ToString() != "")
           {
              designEntity.Status = int.Parse(dataRow["Status"].ToString());
           }
           //创建人 int
           if(dataRow["CreateBy"].ToString() != "")
           {
              designEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              designEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //更新人 int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              designEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //UpdateTime datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              designEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return designEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignEntity">objDesignEntity</returns>
        public static DesignEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           DesignEntity objDesignEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objDesignEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objDesignEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignEntity[]">arrayEntitys</returns>
        public static DesignEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           DesignEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new DesignEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    DesignEntity objDesignEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objDesignEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}