using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Subject ( RH_Subject ) DB类
    ///</summary>
    public class SubjectDB
    {

        /// <summary>
        /// 添加RH_Subject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddSubject(SubjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubjectName",info.SubjectName);
            param.Add("@i_SubCode",info.SubCode);
            param.Add("@i_SubjectSort",info.SubjectSort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Subject_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Subject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifySubject(SubjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubjectName",info.SubjectName);
            param.Add("@i_SubCode",info.SubCode);
            param.Add("@i_SubjectSort",info.SubjectSort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Subject_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveSubject(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Subject_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SubjectInfo GetSubjectDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Subject_Detail", param, DBConnEnm.TRDBWrite);

            return (SubjectInfo)ORMapping.MapSingleObject(typeof(SubjectInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SubjectEntityListResult GetSubjectEntityList(SubjectSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Subject_List", param, DBConnEnm.TRDBWrite);

            SubjectEntityListResult Result= new SubjectEntityListResult();
            Result.SubjectList = (List<SubjectInfo>)ORMapping.MapListObject(typeof(SubjectInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}