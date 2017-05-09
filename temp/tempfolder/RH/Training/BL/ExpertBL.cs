using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Expert ( RH_Expert ) BL类
    ///</summary>
    public class ExpertBL
    {

        /// <summary>
        /// 添加RH_Expert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddExpert(ExpertEntity info)
        {
            return ExpertDB.AddExpert(info);
        }


        /// <summary>
        /// 修改RH_Expert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyExpert(ExpertEntity info)
        {
            return ExpertDB.ModifyExpert(info);
        }


        /// <summary>
        /// 删除RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveExpert(int ID)
        {
            return ExpertDB.RemoveExpert(ID);
        }

        /// <summary>
        /// 查看RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ExpertEntity GetExpertDetail(int ID)
        {
            return ExpertDB.GetExpertDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ExpertEntityListResult GetExpertEntityList(ExpertSearcher Searcher)
        {
            return ExpertDB.GetExpertEntityList(Searcher);
        }
    }
}