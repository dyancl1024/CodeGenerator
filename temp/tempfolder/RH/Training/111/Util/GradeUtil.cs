using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///GradeEntity 的摘要说明
    ///</summary>
    public class GradeMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="GradeEntity">gradeEntity;</returns>
        public static GradeEntity ParseDataRowToEntity(DataRow dataRow)
        {
           GradeEntity gradeEntity =new GradeEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              gradeEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //Name nvarchar(50)
           gradeEntity.Name = dataRow["Name"].ToString();
           //Code varchar(50)
           gradeEntity.Code = dataRow["Code"].ToString();
           //Sort int
           if(dataRow["Sort"].ToString() != "")
           {
              gradeEntity.Sort = int.Parse(dataRow["Sort"].ToString());
           }
           //0：大学段（如：小学） ，&lt;&gt;0:小学段（如小学1-6年级） int
           if(dataRow["ParentID"].ToString() != "")
           {
              gradeEntity.ParentID = int.Parse(dataRow["ParentID"].ToString());
           }
           
           return gradeEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="GradeEntity">objGradeEntity</returns>
        public static GradeEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           GradeEntity objGradeEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objGradeEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objGradeEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="GradeEntity[]">arrayEntitys</returns>
        public static GradeEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           GradeEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new GradeEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    GradeEntity objGradeEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objGradeEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}