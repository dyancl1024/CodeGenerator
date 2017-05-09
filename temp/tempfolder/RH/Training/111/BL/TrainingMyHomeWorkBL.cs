using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingMyHomeWork ( RH_TrainingMyHomeWork ) BL类
    ///</summary>
    public class TrainingMyHomeWorkBL
    {

        /// <summary>
        /// 添加RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingMyHomeWork(TrainingMyHomeWorkEntity info)
        {
            return TrainingMyHomeWorkDB.AddTrainingMyHomeWork(info);
        }


        /// <summary>
        /// 修改RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingMyHomeWork(TrainingMyHomeWorkEntity info)
        {
            return TrainingMyHomeWorkDB.ModifyTrainingMyHomeWork(info);
        }


        /// <summary>
        /// 删除RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingMyHomeWork(int ID)
        {
            return TrainingMyHomeWorkDB.RemoveTrainingMyHomeWork(ID);
        }

        /// <summary>
        /// 查看RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyHomeWorkEntity GetTrainingMyHomeWorkDetail(int ID)
        {
            return TrainingMyHomeWorkDB.GetTrainingMyHomeWorkDetail(ID);
        }
    }
}