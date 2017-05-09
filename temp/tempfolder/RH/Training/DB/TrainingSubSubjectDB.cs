using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingSubSubject ( RH_TrainingSubSubject ) DB类
    ///</summary>
    public class TrainingSubSubjectDB
    {

        /// <summary>
        /// 添加RH_TrainingSubSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingSubSubject(TrainingSubSubjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingSubSubject_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingSubSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingSubSubject(TrainingSubSubjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingSubSubject_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingSubSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingSubSubject(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingSubSubject_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingSubSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubSubjectInfo GetTrainingSubSubjectDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingSubSubject_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingSubSubjectInfo)ORMapping.MapSingleObject(typeof(TrainingSubSubjectInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingSubSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubSubjectEntityListResult GetTrainingSubSubjectEntityList(TrainingSubSubjectSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingSubSubject_List", param, DBConnEnm.TRDBWrite);

            TrainingSubSubjectEntityListResult Result= new TrainingSubSubjectEntityListResult();
            Result.TrainingSubSubjectList = (List<TrainingSubSubjectInfo>)ORMapping.MapListObject(typeof(TrainingSubSubjectInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}