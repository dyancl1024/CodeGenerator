using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingHomeWorkAudit ( RH_TrainingHomeWorkAudit ) BL类
    ///</summary>
    public class TrainingHomeWorkAuditBL
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingHomeWorkAudit(TrainingHomeWorkAuditEntity info)
        {
            return TrainingHomeWorkAuditDB.AddTrainingHomeWorkAudit(info);
        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingHomeWorkAudit(TrainingHomeWorkAuditEntity info)
        {
            return TrainingHomeWorkAuditDB.ModifyTrainingHomeWorkAudit(info);
        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingHomeWorkAudit(int ID)
        {
            return TrainingHomeWorkAuditDB.RemoveTrainingHomeWorkAudit(ID);
        }

        /// <summary>
        /// 查看RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkAuditEntity GetTrainingHomeWorkAuditDetail(int ID)
        {
            return TrainingHomeWorkAuditDB.GetTrainingHomeWorkAuditDetail(ID);
        }
    }
}