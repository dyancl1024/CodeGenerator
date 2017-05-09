using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_GradeSubjectRelation ( RH_GradeSubjectRelation ) BL类
    ///</summary>
    public class GradeSubjectRelationBL
    {

        /// <summary>
        /// 添加RH_GradeSubjectRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddGradeSubjectRelation(GradeSubjectRelationEntity info)
        {
            return GradeSubjectRelationDB.AddGradeSubjectRelation(info);
        }


        /// <summary>
        /// 修改RH_GradeSubjectRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyGradeSubjectRelation(GradeSubjectRelationEntity info)
        {
            return GradeSubjectRelationDB.ModifyGradeSubjectRelation(info);
        }


        /// <summary>
        /// 删除RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveGradeSubjectRelation(int ID)
        {
            return GradeSubjectRelationDB.RemoveGradeSubjectRelation(ID);
        }

        /// <summary>
        /// 查看RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static GradeSubjectRelationEntity GetGradeSubjectRelationDetail(int ID)
        {
            return GradeSubjectRelationDB.GetGradeSubjectRelationDetail(ID);
        }
    }
}