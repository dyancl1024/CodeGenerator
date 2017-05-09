using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Temp_BasicData_TrainingSub ( RH_Temp_BasicData_TrainingSub ) BL类
    ///</summary>
    public class Temp_BasicData_TrainingSubBL
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTemp_BasicData_TrainingSub(Temp_BasicData_TrainingSubEntity info)
        {
            return Temp_BasicData_TrainingSubDB.AddTemp_BasicData_TrainingSub(info);
        }


        /// <summary>
        /// 修改RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTemp_BasicData_TrainingSub(Temp_BasicData_TrainingSubEntity info)
        {
            return Temp_BasicData_TrainingSubDB.ModifyTemp_BasicData_TrainingSub(info);
        }


        /// <summary>
        /// 删除RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTemp_BasicData_TrainingSub(int ID)
        {
            return Temp_BasicData_TrainingSubDB.RemoveTemp_BasicData_TrainingSub(ID);
        }

        /// <summary>
        /// 查看RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_TrainingSubEntity GetTemp_BasicData_TrainingSubDetail(int ID)
        {
            return Temp_BasicData_TrainingSubDB.GetTemp_BasicData_TrainingSubDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_TrainingSubEntityListResult GetTemp_BasicData_TrainingSubEntityList(Temp_BasicData_TrainingSubSearcher Searcher)
        {
            return Temp_BasicData_TrainingSubDB.GetTemp_BasicData_TrainingSubEntityList(Searcher);
        }
    }
}