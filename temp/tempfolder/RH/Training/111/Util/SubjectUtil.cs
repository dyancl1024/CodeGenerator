using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///SubjectEntity 的摘要说明
    ///</summary>
    public class SubjectMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="SubjectEntity">subjectEntity;</returns>
        public static SubjectEntity ParseDataRowToEntity(DataRow dataRow)
        {
           SubjectEntity subjectEntity =new SubjectEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              subjectEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //SubjectName nvarchar(50)
           subjectEntity.SubjectName = dataRow["SubjectName"].ToString();
           //SubCode varchar(50)
           subjectEntity.SubCode = dataRow["SubCode"].ToString();
           //SubjectSort nvarchar(50)
           subjectEntity.SubjectSort = dataRow["SubjectSort"].ToString();
           
           return subjectEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="SubjectEntity">objSubjectEntity</returns>
        public static SubjectEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           SubjectEntity objSubjectEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objSubjectEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objSubjectEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="SubjectEntity[]">arrayEntitys</returns>
        public static SubjectEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           SubjectEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new SubjectEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    SubjectEntity objSubjectEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objSubjectEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}