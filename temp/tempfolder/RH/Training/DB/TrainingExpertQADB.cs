using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingExpertQA ( RH_TrainingExpertQA ) DB类
    ///</summary>
    public class TrainingExpertQADB
    {

        /// <summary>
        /// 添加RH_TrainingExpertQA
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExpertQA(TrainingExpertQAEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TID",info.TID);
            param.Add("@i_QATitle",info.QATitle);
            param.Add("@i_QAContent",info.QAContent);
            param.Add("@i_ClickNum",info.ClickNum);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpertQA_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingExpertQA
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExpertQA(TrainingExpertQAEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TID",info.TID);
            param.Add("@i_QATitle",info.QATitle);
            param.Add("@i_QAContent",info.QAContent);
            param.Add("@i_ClickNum",info.ClickNum);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpertQA_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExpertQA(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpertQA_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQAInfo GetTrainingExpertQADetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingExpertQA_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingExpertQAInfo)ORMapping.MapSingleObject(typeof(TrainingExpertQAInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQAEntityListResult GetTrainingExpertQAEntityList(TrainingExpertQASearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingExpertQA_List", param, DBConnEnm.TRDBWrite);

            TrainingExpertQAEntityListResult Result= new TrainingExpertQAEntityListResult();
            Result.TrainingExpertQAList = (List<TrainingExpertQAInfo>)ORMapping.MapListObject(typeof(TrainingExpertQAInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}