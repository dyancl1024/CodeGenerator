using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingMyCourseRecord ( RH_TrainingMyCourseRecord ) BL类
    ///</summary>
    public class TrainingMyCourseRecordBL
    {

        /// <summary>
        /// 添加RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingMyCourseRecord(TrainingMyCourseRecordEntity info)
        {
            return TrainingMyCourseRecordDB.AddTrainingMyCourseRecord(info);
        }


        /// <summary>
        /// 修改RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingMyCourseRecord(TrainingMyCourseRecordEntity info)
        {
            return TrainingMyCourseRecordDB.ModifyTrainingMyCourseRecord(info);
        }


        /// <summary>
        /// 删除RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingMyCourseRecord(int ID)
        {
            return TrainingMyCourseRecordDB.RemoveTrainingMyCourseRecord(ID);
        }

        /// <summary>
        /// 查看RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyCourseRecordEntity GetTrainingMyCourseRecordDetail(int ID)
        {
            return TrainingMyCourseRecordDB.GetTrainingMyCourseRecordDetail(ID);
        }
    }
}