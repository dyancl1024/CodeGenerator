using System;

namespace RH.Training.MapUtil
{
    ///<summary>
    ///Temp_BasicData_ClassEntity 的摘要说明
    ///</summary>
    public class Temp_BasicData_ClassMapUtil
    {
        ///<summary>
        ///实体映射
        ///</summary>
        ///<param name="dataRow" type="DataRow"></param>
        ///<returns type="Temp_BasicData_ClassEntity">temp_BasicData_ClassEntity;</returns>
        public static Temp_BasicData_ClassEntity ParseDataRowToEntity(DataRow dataRow)
        {
           Temp_BasicData_ClassEntity temp_BasicData_ClassEntity =new Temp_BasicData_ClassEntity();

           //ID int
           if(dataRow["ID"].ToString() != "")
           {
              temp_BasicData_ClassEntity.ID = int.Parse(dataRow["ID"].ToString());
           }
           //SubTID int
           if(dataRow["SubTID"].ToString() != "")
           {
              temp_BasicData_ClassEntity.SubTID = int.Parse(dataRow["SubTID"].ToString());
           }
           //ClassID int
           if(dataRow["ClassID"].ToString() != "")
           {
              temp_BasicData_ClassEntity.ClassID = int.Parse(dataRow["ClassID"].ToString());
           }
           //优秀作业数量 int
           if(dataRow["YX_HW"].ToString() != "")
           {
              temp_BasicData_ClassEntity.YX_HW = int.Parse(dataRow["YX_HW"].ToString());
           }
           //提交作业数量 int
           if(dataRow["TJ_HW"].ToString() != "")
           {
              temp_BasicData_ClassEntity.TJ_HW = int.Parse(dataRow["TJ_HW"].ToString());
           }
           //学习人数 int
           if(dataRow["StudyNum"].ToString() != "")
           {
              temp_BasicData_ClassEntity.StudyNum = int.Parse(dataRow["StudyNum"].ToString());
           }
           //合格的人数 int
           if(dataRow["FinishedNum"].ToString() != "")
           {
              temp_BasicData_ClassEntity.FinishedNum = int.Parse(dataRow["FinishedNum"].ToString());
           }
           //班级人数 int
           if(dataRow["UserNum"].ToString() != "")
           {
              temp_BasicData_ClassEntity.UserNum = int.Parse(dataRow["UserNum"].ToString());
           }
           //班级合格率 decimal(7,3)
           if(dataRow["ClassRate"].ToString() != "")
           {
              temp_BasicData_ClassEntity.ClassRate = decimal.Parse(dataRow["ClassRate"].ToString());
           }
           //合格作业数量（审批状态为合格和优秀） int
           if(dataRow["HG_HW"].ToString() != "")
           {
              temp_BasicData_ClassEntity.HG_HW = int.Parse(dataRow["HG_HW"].ToString());
           }
           //未审批作业数 int
           if(dataRow["No_Num"].ToString() != "")
           {
              temp_BasicData_ClassEntity.No_Num = int.Parse(dataRow["No_Num"].ToString());
           }
           
           return temp_BasicData_ClassEntity;
        }

        ///<summary>
        ///映射单个实体
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="Temp_BasicData_ClassEntity">objTemp_BasicData_ClassEntity</returns>
        public static Temp_BasicData_ClassEntity MapDataTableToSingleEntity(DataTable objDataTable)
        {
           Temp_BasicData_ClassEntity objTemp_BasicData_ClassEntity = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 objTemp_BasicData_ClassEntity = ParseDataRowToEntity(dataRows[0]);
              }
           }
           return objTemp_BasicData_ClassEntity;
        }

        ///<summary>
        ///解析DataTable为对象数组
        ///</summary>
        ///<param name="objDataTable"<>/param>
        ///<returns type="Temp_BasicData_ClassEntity[]">arrayEntitys</returns>
        public static Temp_BasicData_ClassEntity[] MapDataTableToEntityArray(DataTable objDataTable)
        {
           Temp_BasicData_ClassEntity[] arrayEntitys = null;
           if(objDataTable != null && objDataTable.Rows.Count > 0)
           {
              System.Data.DataRow[] dataRows = objDataTable.Select();
              if (dataRows != null)
              {
                 arrayEntitys = new Temp_BasicData_ClassEntity[dataRows.Length];
                 for (int i = 0; i < dataRows.Length; i++)
                 {
                    Temp_BasicData_ClassEntity objTemp_BasicData_ClassEntity= ParseDataRowToEntity(dataRows[i]);
                    arrayEntitys[i] = objTemp_BasicData_ClassEntity;
                 }
              }
           }
           return arrayEntitys;
        }
    }
}