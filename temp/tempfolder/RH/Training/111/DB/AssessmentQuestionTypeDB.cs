using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_AssessmentQuestionType ( RH_AssessmentQuestionType ) DB类
    ///</summary>
    public class AssessmentQuestionTypeDB
    {

        /// <summary>
        /// 添加RH_AssessmentQuestionType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentQuestionType(AssessmentQuestionTypeEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentQuestionType_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_AssessmentQuestionType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentQuestionType(AssessmentQuestionTypeEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentQuestionType_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentQuestionType(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_AssessmentQuestionType_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentQuestionTypeEntity GetAssessmentQuestionTypeDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_AssessmentQuestionType_Detail", param, DBConnEnm.TRDBWrite);
            return (AssessmentQuestionTypeEntity)ORMapping.MapSingleObject(typeof(AssessmentQuestionTypeEntity),dt);
        }
    }
}