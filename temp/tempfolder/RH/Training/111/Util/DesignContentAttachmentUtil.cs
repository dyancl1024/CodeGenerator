using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///DesignContentAttachmentEntity 的摘要说明
    ///</summary>
    public class DesignContentAttachmentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="DesignContentAttachmentEntity">designContentAttachmentEntity;</returns>
        public static DesignContentAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           DesignContentAttachmentEntity designContentAttachmentEntity =new DesignContentAttachmentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              designContentAttachmentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //DesignContentID int
           if(dataRow["DesignContentID"].ToString() != "")
           {
              designContentAttachmentEntity.DesignContentID = int.Parse(dataRow["DesignContentID"].ToString());
           }
           //AttachementName nvarchar(50)
           designContentAttachmentEntity.AttachementName = dataRow["AttachementName"].ToString();
           //AttachmentUrl nvarchar(50)
           designContentAttachmentEntity.AttachmentUrl = dataRow["AttachmentUrl"].ToString();
           //版本号：附件带版本号（系统自动编号），如：v1.0，2.0，按版本从高到低排序 varchar(50)
           designContentAttachmentEntity.Version = dataRow["Version"].ToString();
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              designContentAttachmentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              designContentAttachmentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return designContentAttachmentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignContentAttachmentEntity">objDesignContentAttachmentEntity</returns>
        public static DesignContentAttachmentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           DesignContentAttachmentEntity objDesignContentAttachmentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objDesignContentAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objDesignContentAttachmentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignContentAttachmentEntity[]">arrayEntitys</returns>
        public static DesignContentAttachmentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           DesignContentAttachmentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new DesignContentAttachmentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    DesignContentAttachmentEntity objDesignContentAttachmentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objDesignContentAttachmentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}