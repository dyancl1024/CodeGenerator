using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///PostionEntity 的摘要说明
    ///</summary>
    public class PostionMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="PostionEntity">postionEntity;</returns>
        public static PostionEntity ParseDataRowToEntity(DataRow dataRow)
        {
           PostionEntity postionEntity =new PostionEntity();

           //主键 int
           if(dataRow["ID"].ToString() != "")
           {
              postionEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //职位名称 nvarchar(50)
           postionEntity.Name = dataRow["Name"].ToString();
           //编号 varchar(50)
           postionEntity.Code = dataRow["Code"].ToString();
           //顺序 int
           if(dataRow["Sort"].ToString() != "")
           {
              postionEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           
           return postionEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="PostionEntity">objPostionEntity</returns>
        public static PostionEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           PostionEntity objPostionEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objPostionEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objPostionEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="PostionEntity[]">arrayEntitys</returns>
        public static PostionEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           PostionEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new PostionEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    PostionEntity objPostionEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objPostionEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}