using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_School ( RH_School ) DB类
    ///</summary>
    public class SchoolDB
    {

        /// <summary>
        /// 添加RH_School
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddSchool(SchoolEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_School_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_School
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifySchool(SchoolEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_School_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveSchool(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_School_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SchoolEntity GetSchoolDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_School_Detail", param, DBConnEnm.TRDBWrite);
            return (SchoolEntity)ORMapping.MapSingleObject(typeof(SchoolEntity),dt);
        }
    }
}