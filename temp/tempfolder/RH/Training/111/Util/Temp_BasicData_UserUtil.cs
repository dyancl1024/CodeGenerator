using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///Temp_BasicData_UserEntity 的摘要说明
    ///</summary>
    public class Temp_BasicData_UserMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="Temp_BasicData_UserEntity">temp_BasicData_UserEntity;</returns>
        public static Temp_BasicData_UserEntity ParseDataRowToEntity(DataRow dataRow)
        {
           Temp_BasicData_UserEntity temp_BasicData_UserEntity =new Temp_BasicData_UserEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              temp_BasicData_UserEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //SubTID int
           if(dataRow["SubTID"].ToString() != "")
           {
              temp_BasicData_UserEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //ClassID int
           if(dataRow["ClassID"].ToString() != "")
           {
              temp_BasicData_UserEntity.ClassID = int.Parse(dataRow["ClassID"].ToString());
           }
           //UserID int
           if(dataRow["UserID"].ToString() != "")
           {
              temp_BasicData_UserEntity.UserID = int.Parse(dataRow["UserID"].ToString());
           }
           //获得作业学时 int
           if(dataRow["Phase"].ToString() != "")
           {
              temp_BasicData_UserEntity.Phase = int.Parse(dataRow["Phase"].ToString());
           }
           //Q_jxfs int
           if(dataRow["Q_jxfs"].ToString() != "")
           {
              temp_BasicData_UserEntity.Q_jxfs = int.Parse(dataRow["Q_jxfs"].ToString());
           }
           //T_jxfs int
           if(dataRow["T_jxfs"].ToString() != "")
           {
              temp_BasicData_UserEntity.T_jxfs = int.Parse(dataRow["T_jxfs"].ToString());
           }
           //F_jxfs int
           if(dataRow["F_jxfs"].ToString() != "")
           {
              temp_BasicData_UserEntity.F_jxfs = int.Parse(dataRow["F_jxfs"].ToString());
           }
           //E_jxfs int
           if(dataRow["E_jxfs"].ToString() != "")
           {
              temp_BasicData_UserEntity.E_jxfs = int.Parse(dataRow["E_jxfs"].ToString());
           }
           //Q_jxcl int
           if(dataRow["Q_jxcl"].ToString() != "")
           {
              temp_BasicData_UserEntity.Q_jxcl = int.Parse(dataRow["Q_jxcl"].ToString());
           }
           //T_jxcl int
           if(dataRow["T_jxcl"].ToString() != "")
           {
              temp_BasicData_UserEntity.T_jxcl = int.Parse(dataRow["T_jxcl"].ToString());
           }
           //F_jxcl int
           if(dataRow["F_jxcl"].ToString() != "")
           {
              temp_BasicData_UserEntity.F_jxcl = int.Parse(dataRow["F_jxcl"].ToString());
           }
           //E_jxcl int
           if(dataRow["E_jxcl"].ToString() != "")
           {
              temp_BasicData_UserEntity.E_jxcl = int.Parse(dataRow["E_jxcl"].ToString());
           }
           //Q_xxxd int
           if(dataRow["Q_xxxd"].ToString() != "")
           {
              temp_BasicData_UserEntity.Q_xxxd = int.Parse(dataRow["Q_xxxd"].ToString());
           }
           //T_xxxd int
           if(dataRow["T_xxxd"].ToString() != "")
           {
              temp_BasicData_UserEntity.T_xxxd = int.Parse(dataRow["T_xxxd"].ToString());
           }
           //F_xxxd int
           if(dataRow["F_xxxd"].ToString() != "")
           {
              temp_BasicData_UserEntity.F_xxxd = int.Parse(dataRow["F_xxxd"].ToString());
           }
           //E_xxxd int
           if(dataRow["E_xxxd"].ToString() != "")
           {
              temp_BasicData_UserEntity.E_xxxd = int.Parse(dataRow["E_xxxd"].ToString());
           }
           //Q_wtfx int
           if(dataRow["Q_wtfx"].ToString() != "")
           {
              temp_BasicData_UserEntity.Q_wtfx = int.Parse(dataRow["Q_wtfx"].ToString());
           }
           //T_wtfx int
           if(dataRow["T_wtfx"].ToString() != "")
           {
              temp_BasicData_UserEntity.T_wtfx = int.Parse(dataRow["T_wtfx"].ToString());
           }
           //F_wtfx int
           if(dataRow["F_wtfx"].ToString() != "")
           {
              temp_BasicData_UserEntity.F_wtfx = int.Parse(dataRow["F_wtfx"].ToString());
           }
           //E_wtfx int
           if(dataRow["E_wtfx"].ToString() != "")
           {
              temp_BasicData_UserEntity.E_wtfx = int.Parse(dataRow["E_wtfx"].ToString());
           }
           //Q_yxrz int
           if(dataRow["Q_yxrz"].ToString() != "")
           {
              temp_BasicData_UserEntity.Q_yxrz = int.Parse(dataRow["Q_yxrz"].ToString());
           }
           //T_yxrz int
           if(dataRow["T_yxrz"].ToString() != "")
           {
              temp_BasicData_UserEntity.T_yxrz = int.Parse(dataRow["T_yxrz"].ToString());
           }
           //F_yxrz int
           if(dataRow["F_yxrz"].ToString() != "")
           {
              temp_BasicData_UserEntity.F_yxrz = int.Parse(dataRow["F_yxrz"].ToString());
           }
           //E_yxrz int
           if(dataRow["E_yxrz"].ToString() != "")
           {
              temp_BasicData_UserEntity.E_yxrz = int.Parse(dataRow["E_yxrz"].ToString());
           }
           //Q_pxzj int
           if(dataRow["Q_pxzj"].ToString() != "")
           {
              temp_BasicData_UserEntity.Q_pxzj = int.Parse(dataRow["Q_pxzj"].ToString());
           }
           //T_pxzj int
           if(dataRow["T_pxzj"].ToString() != "")
           {
              temp_BasicData_UserEntity.T_pxzj = int.Parse(dataRow["T_pxzj"].ToString());
           }
           //F_pxzj int
           if(dataRow["F_pxzj"].ToString() != "")
           {
              temp_BasicData_UserEntity.F_pxzj = int.Parse(dataRow["F_pxzj"].ToString());
           }
           //E_pxzj int
           if(dataRow["E_pxzj"].ToString() != "")
           {
              temp_BasicData_UserEntity.E_pxzj = int.Parse(dataRow["E_pxzj"].ToString());
           }
           //作业是否完成 int
           if(dataRow["Finished"].ToString() != "")
           {
              temp_BasicData_UserEntity.Finished = int.Parse(dataRow["Finished"].ToString());
           }
           //获得课程学时 int
           if(dataRow["GetCoursePhase"].ToString() != "")
           {
              temp_BasicData_UserEntity.GetCoursePhase = int.Parse(dataRow["GetCoursePhase"].ToString());
           }
           //课程总学时 int
           if(dataRow["CoursePhase"].ToString() != "")
           {
              temp_BasicData_UserEntity.CoursePhase = int.Parse(dataRow["CoursePhase"].ToString());
           }
           //培训状态 nvarchar(10)
           temp_BasicData_UserEntity.StatusName = dataRow["StatusName"].ToString();
           //是否学习 int
           if(dataRow["IsStudy"].ToString() != "")
           {
              temp_BasicData_UserEntity.IsStudy = int.Parse(dataRow["IsStudy"].ToString());
           }
           //作业总学时 int
           if(dataRow["HomeWorkPhase"].ToString() != "")
           {
              temp_BasicData_UserEntity.HomeWorkPhase = int.Parse(dataRow["HomeWorkPhase"].ToString());
           }
           
           return temp_BasicData_UserEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="Temp_BasicData_UserEntity">objTemp_BasicData_UserEntity</returns>
        public static Temp_BasicData_UserEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           Temp_BasicData_UserEntity objTemp_BasicData_UserEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTemp_BasicData_UserEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTemp_BasicData_UserEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="Temp_BasicData_UserEntity[]">arrayEntitys</returns>
        public static Temp_BasicData_UserEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           Temp_BasicData_UserEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new Temp_BasicData_UserEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    Temp_BasicData_UserEntity objTemp_BasicData_UserEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTemp_BasicData_UserEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}