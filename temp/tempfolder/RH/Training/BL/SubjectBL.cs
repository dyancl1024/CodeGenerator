using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Subject ( RH_Subject ) BL类
    ///</summary>
    public class SubjectBL
    {

        /// <summary>
        /// 添加RH_Subject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddSubject(SubjectEntity info)
        {
            return SubjectDB.AddSubject(info);
        }


        /// <summary>
        /// 修改RH_Subject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifySubject(SubjectEntity info)
        {
            return SubjectDB.ModifySubject(info);
        }


        /// <summary>
        /// 删除RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveSubject(int ID)
        {
            return SubjectDB.RemoveSubject(ID);
        }

        /// <summary>
        /// 查看RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SubjectEntity GetSubjectDetail(int ID)
        {
            return SubjectDB.GetSubjectDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SubjectEntityListResult GetSubjectEntityList(SubjectSearcher Searcher)
        {
            return SubjectDB.GetSubjectEntityList(Searcher);
        }
    }
}