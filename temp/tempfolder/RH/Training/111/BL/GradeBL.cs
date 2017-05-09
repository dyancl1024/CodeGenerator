using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Grade ( RH_Grade ) BL类
    ///</summary>
    public class GradeBL
    {

        /// <summary>
        /// 添加RH_Grade
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddGrade(GradeEntity info)
        {
            return GradeDB.AddGrade(info);
        }


        /// <summary>
        /// 修改RH_Grade
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyGrade(GradeEntity info)
        {
            return GradeDB.ModifyGrade(info);
        }


        /// <summary>
        /// 删除RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveGrade(int ID)
        {
            return GradeDB.RemoveGrade(ID);
        }

        /// <summary>
        /// 查看RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static GradeEntity GetGradeDetail(int ID)
        {
            return GradeDB.GetGradeDetail(ID);
        }
    }
}