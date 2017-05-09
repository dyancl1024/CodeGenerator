using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_AssessmentOptions ( RH_AssessmentOptions ) DB类
    ///</summary>
    public class AssessmentOptionsDB
    {

        /// <summary>
        /// 添加RH_AssessmentOptions
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentOptions(AssessmentOptionsEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentOptions_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_AssessmentOptions
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentOptions(AssessmentOptionsEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentOptions_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentOptions(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentOptions_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentOptionsEntity GetAssessmentOptionsDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_AssessmentOptions_Detail", param, DBConnEnm.TRDBWrite);
            return (AssessmentOptionsEntity)ORMapping.MapSingleObject(typeof(AssessmentOptionsEntity),dt);
        }
    }
}