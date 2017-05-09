using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

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
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_UserID",info.UserID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_TID",info.TID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_UserSubjectRule_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_UserSubjectRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyUserSubjectRule(UserSubjectRuleEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_TID",info.TID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_UserSubjectRule_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveUserSubjectRule(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_UserSubjectRule_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserSubjectRuleInfo GetUserSubjectRuleDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_UserSubjectRule_Detail", param, DBConnEnm.TRDBWrite);

            return (UserSubjectRuleInfo)ORMapping.MapSingleObject(typeof(UserSubjectRuleInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserSubjectRuleEntityListResult GetUserSubjectRuleEntityList(UserSubjectRuleSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_UserSubjectRule_List", param, DBConnEnm.TRDBWrite);

            UserSubjectRuleEntityListResult Result= new UserSubjectRuleEntityListResult();
            Result.UserSubjectRuleList = (List<UserSubjectRuleInfo>)ORMapping.MapListObject(typeof(UserSubjectRuleInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}