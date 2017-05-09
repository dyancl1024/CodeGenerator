using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Temp_BasicData_Class ( RH_Temp_BasicData_Class ) DB类
    ///</summary>
    public class Temp_BasicData_ClassDB
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTemp_BasicData_Class(Temp_BasicData_ClassEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Temp_BasicData_Class_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTemp_BasicData_Class(Temp_BasicData_ClassEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Temp_BasicData_Class_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTemp_BasicData_Class(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Temp_BasicData_Class_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_ClassEntity GetTemp_BasicData_ClassDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Temp_BasicData_Class_Detail", param, DBConnEnm.TRDBWrite);
            return (Temp_BasicData_ClassEntity)ORMapping.MapSingleObject(typeof(Temp_BasicData_ClassEntity),dt);
        }
    }
}