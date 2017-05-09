using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingSubSubject ( RH_TrainingSubSubject ) BL类
    ///</summary>
    public class TrainingSubSubjectBL
    {

        /// <summary>
        /// 添加RH_TrainingSubSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingSubSubject(TrainingSubSubjectEntity info)
        {
            return TrainingSubSubjectDB.AddTrainingSubSubject(info);
        }


        /// <summary>
        /// 修改RH_TrainingSubSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingSubSubject(TrainingSubSubjectEntity info)
        {
            return TrainingSubSubjectDB.ModifyTrainingSubSubject(info);
        }


        /// <summary>
        /// 删除RH_TrainingSubSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingSubSubject(int ID)
        {
            return TrainingSubSubjectDB.RemoveTrainingSubSubject(ID);
        }

        /// <summary>
        /// 查看RH_TrainingSubSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubSubjectEntity GetTrainingSubSubjectDetail(int ID)
        {
            return TrainingSubSubjectDB.GetTrainingSubSubjectDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingSubSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubSubjectEntityListResult GetTrainingSubSubjectEntityList(TrainingSubSubjectSearcher Searcher)
        {
            return TrainingSubSubjectDB.GetTrainingSubSubjectEntityList(Searcher);
        }
    }
}