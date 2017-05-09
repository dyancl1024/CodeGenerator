using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) BL类
    ///</summary>
    public class CourseLevelRelationBL
    {

        /// <summary>
        /// 添加RH_CourseLevelRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseLevelRelation(CourseLevelRelationEntity info)
        {
            return CourseLevelRelationDB.AddCourseLevelRelation(info);
        }


        /// <summary>
        /// 修改RH_CourseLevelRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseLevelRelation(CourseLevelRelationEntity info)
        {
            return CourseLevelRelationDB.ModifyCourseLevelRelation(info);
        }


        /// <summary>
        /// 删除RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseLevelRelation(int ID)
        {
            return CourseLevelRelationDB.RemoveCourseLevelRelation(ID);
        }

        /// <summary>
        /// 查看RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseLevelRelationEntity GetCourseLevelRelationDetail(int ID)
        {
            return CourseLevelRelationDB.GetCourseLevelRelationDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseLevelRelationEntityListResult GetCourseLevelRelationEntityList(CourseLevelRelationSearcher Searcher)
        {
            return CourseLevelRelationDB.GetCourseLevelRelationEntityList(Searcher);
        }
    }
}