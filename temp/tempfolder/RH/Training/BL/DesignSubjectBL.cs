using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_DesignSubject ( RH_DesignSubject ) BL类
    ///</summary>
    public class DesignSubjectBL
    {

        /// <summary>
        /// 添加RH_DesignSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignSubject(DesignSubjectEntity info)
        {
            return DesignSubjectDB.AddDesignSubject(info);
        }


        /// <summary>
        /// 修改RH_DesignSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignSubject(DesignSubjectEntity info)
        {
            return DesignSubjectDB.ModifyDesignSubject(info);
        }


        /// <summary>
        /// 删除RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignSubject(int ID)
        {
            return DesignSubjectDB.RemoveDesignSubject(ID);
        }

        /// <summary>
        /// 查看RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSubjectEntity GetDesignSubjectDetail(int ID)
        {
            return DesignSubjectDB.GetDesignSubjectDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSubjectEntityListResult GetDesignSubjectEntityList(DesignSubjectSearcher Searcher)
        {
            return DesignSubjectDB.GetDesignSubjectEntityList(Searcher);
        }
    }
}