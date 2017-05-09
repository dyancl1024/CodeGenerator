using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingLevel ( RH_TrainingLevel ) BL类
    ///</summary>
    public class TrainingLevelBL
    {

        /// <summary>
        /// 添加RH_TrainingLevel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingLevel(TrainingLevelEntity info)
        {
            return TrainingLevelDB.AddTrainingLevel(info);
        }


        /// <summary>
        /// 修改RH_TrainingLevel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingLevel(TrainingLevelEntity info)
        {
            return TrainingLevelDB.ModifyTrainingLevel(info);
        }


        /// <summary>
        /// 删除RH_TrainingLevel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingLevel(int ID)
        {
            return TrainingLevelDB.RemoveTrainingLevel(ID);
        }

        /// <summary>
        /// 查看RH_TrainingLevel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingLevelEntity GetTrainingLevelDetail(int ID)
        {
            return TrainingLevelDB.GetTrainingLevelDetail(ID);
        }
    }
}