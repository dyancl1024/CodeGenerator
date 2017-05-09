using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///DesignAttachmentEntity 的摘要说明
    ///</summary>
    public class DesignAttachmentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="DesignAttachmentEntity">designAttachmentEntity;</returns>
        public static DesignAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           DesignAttachmentEntity designAttachmentEntity =new DesignAttachmentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              designAttachmentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //DesignID int
           if(dataRow["DesignID"].ToString() != "")
           {
              designAttachmentEntity.DesignID = int.Parse(dataRow["DesignID"].ToString());
           }
           //AttachmentName nvarchar(50)
           designAttachmentEntity.AttachmentName = dataRow["AttachmentName"].ToString();
           //AttachmentUrl nvarchar(50)
           designAttachmentEntity.AttachmentUrl = dataRow["AttachmentUrl"].ToString();
           //AttachmentType int
           if(dataRow["AttachmentType"].ToString() != "")
           {
              designAttachmentEntity.AttachmentType = int.Parse(dataRow["AttachmentType"].ToString());
           }
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              designAttachmentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              designAttachmentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return designAttachmentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignAttachmentEntity">objDesignAttachmentEntity</returns>
        public static DesignAttachmentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           DesignAttachmentEntity objDesignAttachmentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objDesignAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objDesignAttachmentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignAttachmentEntity[]">arrayEntitys</returns>
        public static DesignAttachmentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           DesignAttachmentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new DesignAttachmentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    DesignAttachmentEntity objDesignAttachmentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objDesignAttachmentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}