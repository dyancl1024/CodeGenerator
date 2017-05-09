using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///GradeSubjectRelationEntity 的摘要说明
    ///</summary>
    public class GradeSubjectRelationMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="GradeSubjectRelationEntity">gradeSubjectRelationEntity;</returns>
        public static GradeSubjectRelationEntity ParseDataRowToEntity(DataRow dataRow)
        {
           GradeSubjectRelationEntity gradeSubjectRelationEntity =new GradeSubjectRelationEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              gradeSubjectRelationEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //学段代码 varchar(50)
           gradeSubjectRelationEntity.GradeCode = dataRow["GradeCode"].ToString();
           //学科code varchar(50)
           gradeSubjectRelationEntity.SubjectCode = dataRow["SubjectCode"].ToString();
           
           return gradeSubjectRelationEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="GradeSubjectRelationEntity">objGradeSubjectRelationEntity</returns>
        public static GradeSubjectRelationEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           GradeSubjectRelationEntity objGradeSubjectRelationEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objGradeSubjectRelationEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objGradeSubjectRelationEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="GradeSubjectRelationEntity[]">arrayEntitys</returns>
        public static GradeSubjectRelationEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           GradeSubjectRelationEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new GradeSubjectRelationEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    GradeSubjectRelationEntity objGradeSubjectRelationEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objGradeSubjectRelationEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}