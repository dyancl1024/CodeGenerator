using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingClass ( RH_TrainingClass ) DB类
    ///</summary>
    public class TrainingClassDB
    {

        /// <summary>
        /// 添加RH_TrainingClass
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClass(TrainingClassEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_ClassNO",info.ClassNO);
            param.Add("@i_CName",info.CName);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClass_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingClass
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClass(TrainingClassEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_ClassNO",info.ClassNO);
            param.Add("@i_CName",info.CName);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClass_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClass(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClass_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassInfo GetTrainingClassDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingClass_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingClassInfo)ORMapping.MapSingleObject(typeof(TrainingClassInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassEntityListResult GetTrainingClassEntityList(TrainingClassSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingClass_List", param, DBConnEnm.TRDBWrite);

            TrainingClassEntityListResult Result= new TrainingClassEntityListResult();
            Result.TrainingClassList = (List<TrainingClassInfo>)ORMapping.MapListObject(typeof(TrainingClassInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}