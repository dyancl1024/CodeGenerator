using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_UserSubjectRule ( RH_UserSubjectRule ) DB类
    ///</summary>
    public class UserSubjectRuleDB
    {

        /// <summary>
        /// 添加RH_UserSubjectRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddUserSubjectRule(UserSubjectRuleEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_UserSubjectRule_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_UserSubjectRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyUserSubjectRule(UserSubjectRuleEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_UserSubjectRule_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveUserSubjectRule(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_UserSubjectRule_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserSubjectRuleEntity GetUserSubjectRuleDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_UserSubjectRule_Detail", param, DBConnEnm.TRDBWrite);
            return (UserSubjectRuleEntity)ORMapping.MapSingleObject(typeof(UserSubjectRuleEntity),dt);
        }
    }
}