using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_UserSubjectRule ( RH_UserSubjectRule ) BL类
    ///</summary>
    public class UserSubjectRuleBL
    {

        /// <summary>
        /// 添加RH_UserSubjectRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddUserSubjectRule(UserSubjectRuleEntity info)
        {
            return UserSubjectRuleDB.AddUserSubjectRule(info);
        }


        /// <summary>
        /// 修改RH_UserSubjectRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyUserSubjectRule(UserSubjectRuleEntity info)
        {
            return UserSubjectRuleDB.ModifyUserSubjectRule(info);
        }


        /// <summary>
        /// 删除RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveUserSubjectRule(int ID)
        {
            return UserSubjectRuleDB.RemoveUserSubjectRule(ID);
        }

        /// <summary>
        /// 查看RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserSubjectRuleEntity GetUserSubjectRuleDetail(int ID)
        {
            return UserSubjectRuleDB.GetUserSubjectRuleDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserSubjectRuleEntityListResult GetUserSubjectRuleEntityList(UserSubjectRuleSearcher Searcher)
        {
            return UserSubjectRuleDB.GetUserSubjectRuleEntityList(Searcher);
        }
    }
}