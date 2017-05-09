using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///DesignContentEntity 的摘要说明
    ///</summary>
    public class DesignContentMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="DesignContentEntity">designContentEntity;</returns>
        public static DesignContentEntity ParseDataRowToEntity(DataRow dataRow)
        {
           DesignContentEntity designContentEntity =new DesignContentEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              designContentEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //DesignID int
           if(dataRow["DesignID"].ToString() != "")
           {
              designContentEntity.DesignID = int.Parse(dataRow["DesignID"].ToString());
           }
           //1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书 int
           if(dataRow["DType"].ToString() != "")
           {
              designContentEntity.DType = int.Parse(dataRow["DType"].ToString());
           }
           //1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书 nvarchar(50)
           designContentEntity.DName = dataRow["DName"].ToString();
           //DContent nvarchar(Max)
           designContentEntity.DContent = dataRow["DContent"].ToString();
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              designContentEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              designContentEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           //UpdateBy int
           if(dataRow["UpdateBy"].ToString() != "")
           {
              designContentEntity.UpdateBy = int.Parse(dataRow["UpdateBy"].ToString());
           }
           //UpdateTime datetime
           if(dataRow["UpdateTime"].ToString() != "")
           {
              designContentEntity.UpdateTime = DateTime.Parse(dataRow["UpdateTime"].ToString());
           }
           
           return designContentEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignContentEntity">objDesignContentEntity</returns>
        public static DesignContentEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           DesignContentEntity objDesignContentEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objDesignContentEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objDesignContentEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignContentEntity[]">arrayEntitys</returns>
        public static DesignContentEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           DesignContentEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new DesignContentEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    DesignContentEntity objDesignContentEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objDesignContentEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}