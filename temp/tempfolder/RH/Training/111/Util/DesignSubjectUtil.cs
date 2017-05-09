using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///DesignSubjectEntity 的摘要说明
    ///</summary>
    public class DesignSubjectMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="DesignSubjectEntity">designSubjectEntity;</returns>
        public static DesignSubjectEntity ParseDataRowToEntity(DataRow dataRow)
        {
           DesignSubjectEntity designSubjectEntity =new DesignSubjectEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              designSubjectEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //DesignID int
           if(dataRow["DesignID"].ToString() != "")
           {
              designSubjectEntity.DesignID = int.Parse(dataRow["DesignID"].ToString());
           }
           //GradeCode varchar(50)
           designSubjectEntity.GradeCode = dataRow["GradeCode"].ToString();
           //SubjectCode varchar(50)
           designSubjectEntity.SubjectCode = dataRow["SubjectCode"].ToString();
           //CreateBy int
           if(dataRow["CreateBy"].ToString() != "")
           {
              designSubjectEntity.CreateBy = int.Parse(dataRow["CreateBy"].ToString());
           }
           //CreateTime datetime
           if(dataRow["CreateTime"].ToString() != "")
           {
              designSubjectEntity.CreateTime = DateTime.Parse(dataRow["CreateTime"].ToString());
           }
           
           return designSubjectEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignSubjectEntity">objDesignSubjectEntity</returns>
        public static DesignSubjectEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           DesignSubjectEntity objDesignSubjectEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objDesignSubjectEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objDesignSubjectEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="DesignSubjectEntity[]">arrayEntitys</returns>
        public static DesignSubjectEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           DesignSubjectEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new DesignSubjectEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    DesignSubjectEntity objDesignSubjectEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objDesignSubjectEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}