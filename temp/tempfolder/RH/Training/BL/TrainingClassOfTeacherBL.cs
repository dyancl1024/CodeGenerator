using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) BL类
    ///</summary>
    public class TrainingClassOfTeacherBL
    {

        /// <summary>
        /// 添加RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClassOfTeacher(TrainingClassOfTeacherEntity info)
        {
            return TrainingClassOfTeacherDB.AddTrainingClassOfTeacher(info);
        }


        /// <summary>
        /// 修改RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClassOfTeacher(TrainingClassOfTeacherEntity info)
        {
            return TrainingClassOfTeacherDB.ModifyTrainingClassOfTeacher(info);
        }


        /// <summary>
        /// 删除RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClassOfTeacher(int ID)
        {
            return TrainingClassOfTeacherDB.RemoveTrainingClassOfTeacher(ID);
        }

        /// <summary>
        /// 查看RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassOfTeacherEntity GetTrainingClassOfTeacherDetail(int ID)
        {
            return TrainingClassOfTeacherDB.GetTrainingClassOfTeacherDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassOfTeacherEntityListResult GetTrainingClassOfTeacherEntityList(TrainingClassOfTeacherSearcher Searcher)
        {
            return TrainingClassOfTeacherDB.GetTrainingClassOfTeacherEntityList(Searcher);
        }
    }
}