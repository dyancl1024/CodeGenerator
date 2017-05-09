using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignSubject ( RH_DesignSubject ) DB类
    ///</summary>
    public class DesignSubjectDB
    {

        /// <summary>
        /// 添加RH_DesignSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignSubject(DesignSubjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignSubject_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignSubject(DesignSubjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignSubject_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignSubject(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignSubject_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSubjectInfo GetDesignSubjectDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_DesignSubject_Detail", param, DBConnEnm.TRDBWrite);

            return (DesignSubjectInfo)ORMapping.MapSingleObject(typeof(DesignSubjectInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSubjectEntityListResult GetDesignSubjectEntityList(DesignSubjectSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_DesignSubject_List", param, DBConnEnm.TRDBWrite);

            DesignSubjectEntityListResult Result= new DesignSubjectEntityListResult();
            Result.DesignSubjectList = (List<DesignSubjectInfo>)ORMapping.MapListObject(typeof(DesignSubjectInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}