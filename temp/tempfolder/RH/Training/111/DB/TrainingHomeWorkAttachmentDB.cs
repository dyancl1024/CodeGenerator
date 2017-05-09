using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingHomeWorkAttachment ( RH_TrainingHomeWorkAttachment ) DB类
    ///</summary>
    public class TrainingHomeWorkAttachmentDB
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingHomeWorkAttachment(TrainingHomeWorkAttachmentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingHomeWorkAttachment_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingHomeWorkAttachment(TrainingHomeWorkAttachmentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingHomeWorkAttachment_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingHomeWorkAttachment(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingHomeWorkAttachment_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkAttachmentEntity GetTrainingHomeWorkAttachmentDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingHomeWorkAttachment_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingHomeWorkAttachmentEntity)ORMapping.MapSingleObject(typeof(TrainingHomeWorkAttachmentEntity),dt);
        }
    }
}