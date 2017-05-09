using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///UserSubjectRuleEntity 的摘要说明
    ///</summary>
    public class UserSubjectRuleMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="UserSubjectRuleEntity">userSubjectRuleEntity;</returns>
        public static UserSubjectRuleEntity ParseDataRowToEntity(DataRow dataRow)
        {
           UserSubjectRuleEntity userSubjectRuleEntity =new UserSubjectRuleEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              userSubjectRuleEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //用户id int
           if(dataRow["UserID"].ToString() != "")
           {
              userSubjectRuleEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //学段id varchar(50)
           userSubjectRuleEntity.GradeCode = dataRow["GradeCode"].ToString();
           //学科ID varchar(50)
           userSubjectRuleEntity.SubjectCode = dataRow["SubjectCode"].ToString();
           //子项目ID  一个学员在一个项目下只有一个学段学科 int
           if(dataRow["TID"].ToString() != "")
           {
              userSubjectRuleEntity.TID = int.Parse(dataRow["TID"].ToString());
           }
           
           return userSubjectRuleEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="UserSubjectRuleEntity">objUserSubjectRuleEntity</returns>
        public static UserSubjectRuleEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           UserSubjectRuleEntity objUserSubjectRuleEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objUserSubjectRuleEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objUserSubjectRuleEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="UserSubjectRuleEntity[]">arrayEntitys</returns>
        public static UserSubjectRuleEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           UserSubjectRuleEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new UserSubjectRuleEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    UserSubjectRuleEntity objUserSubjectRuleEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objUserSubjectRuleEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}