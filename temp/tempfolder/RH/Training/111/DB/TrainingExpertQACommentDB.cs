using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingExpertQAComment ( RH_TrainingExpertQAComment ) DB类
    ///</summary>
    public class TrainingExpertQACommentDB
    {

        /// <summary>
        /// 添加RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExpertQAComment(TrainingExpertQACommentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingExpertQAComment_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExpertQAComment(TrainingExpertQACommentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingExpertQAComment_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExpertQAComment(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingExpertQAComment_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQACommentEntity GetTrainingExpertQACommentDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingExpertQAComment_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingExpertQACommentEntity)ORMapping.MapSingleObject(typeof(TrainingExpertQACommentEntity),dt);
        }
    }
}