using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingTeacher ( RH_TrainingTeacher ) BL类
    ///</summary>
    public class TrainingTeacherBL
    {

        /// <summary>
        /// 添加RH_TrainingTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingTeacher(TrainingTeacherEntity info)
        {
            return TrainingTeacherDB.AddTrainingTeacher(info);
        }


        /// <summary>
        /// 修改RH_TrainingTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingTeacher(TrainingTeacherEntity info)
        {
            return TrainingTeacherDB.ModifyTrainingTeacher(info);
        }


        /// <summary>
        /// 删除RH_TrainingTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingTeacher(int ID)
        {
            return TrainingTeacherDB.RemoveTrainingTeacher(ID);
        }

        /// <summary>
        /// 查看RH_TrainingTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherEntity GetTrainingTeacherDetail(int ID)
        {
            return TrainingTeacherDB.GetTrainingTeacherDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherEntityListResult GetTrainingTeacherEntityList(TrainingTeacherSearcher Searcher)
        {
            return TrainingTeacherDB.GetTrainingTeacherEntityList(Searcher);
        }
    }
}