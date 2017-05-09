using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingMyHomeWork ( RH_TrainingMyHomeWork ) DB类
    ///</summary>
    public class TrainingMyHomeWorkDB
    {

        /// <summary>
        /// 添加RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingMyHomeWork(TrainingMyHomeWorkEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_HomeWorkTitle",info.HomeWorkTitle);
            param.Add("@i_HomeWorkContent",info.HomeWorkContent);
            param.Add("@i_HomeWorkPhaseID",info.HomeWorkPhaseID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyHomeWork_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingMyHomeWork(TrainingMyHomeWorkEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_HomeWorkTitle",info.HomeWorkTitle);
            param.Add("@i_HomeWorkContent",info.HomeWorkContent);
            param.Add("@i_HomeWorkPhaseID",info.HomeWorkPhaseID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyHomeWork_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingMyHomeWork(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyHomeWork_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyHomeWorkInfo GetTrainingMyHomeWorkDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingMyHomeWork_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingMyHomeWorkInfo)ORMapping.MapSingleObject(typeof(TrainingMyHomeWorkInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyHomeWorkEntityListResult GetTrainingMyHomeWorkEntityList(TrainingMyHomeWorkSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingMyHomeWork_List", param, DBConnEnm.TRDBWrite);

            TrainingMyHomeWorkEntityListResult Result= new TrainingMyHomeWorkEntityListResult();
            Result.TrainingMyHomeWorkList = (List<TrainingMyHomeWorkInfo>)ORMapping.MapListObject(typeof(TrainingMyHomeWorkInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}