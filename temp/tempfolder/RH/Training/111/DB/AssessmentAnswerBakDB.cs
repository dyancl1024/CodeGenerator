using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_AssessmentAnswerBak ( RH_AssessmentAnswerBak ) DB类
    ///</summary>
    public class AssessmentAnswerBakDB
    {

        /// <summary>
        /// 添加RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentAnswerBak(AssessmentAnswerBakEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentAnswerBak_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentAnswerBak(AssessmentAnswerBakEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentAnswerBak_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentAnswerBak(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentAnswerBak_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerBakEntity GetAssessmentAnswerBakDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_AssessmentAnswerBak_Detail", param, DBConnEnm.TRDBWrite);
            return (AssessmentAnswerBakEntity)ORMapping.MapSingleObject(typeof(AssessmentAnswerBakEntity),dt);
        }
    }
}