using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Expert ( RH_Expert ) DB类
    ///</summary>
    public class ExpertDB
    {

        /// <summary>
        /// 添加RH_Expert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddExpert(ExpertEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Expert_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Expert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyExpert(ExpertEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Expert_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveExpert(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Expert_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ExpertEntity GetExpertDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Expert_Detail", param, DBConnEnm.TRDBWrite);
            return (ExpertEntity)ORMapping.MapSingleObject(typeof(ExpertEntity),dt);
        }
    }
}