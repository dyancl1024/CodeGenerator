using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Temp_BasicData_TrainingSub ( RH_Temp_BasicData_TrainingSub ) DB类
    ///</summary>
    public class Temp_BasicData_TrainingSubDB
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTemp_BasicData_TrainingSub(Temp_BasicData_TrainingSubEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_tid",info.tid);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_TeacherNum",info.TeacherNum);
            param.Add("@i_ClassNum",info.ClassNum);
            param.Add("@i_FinishedNum",info.FinishedNum);
            param.Add("@i_StudyNum",info.StudyNum);
            param.Add("@i_UserNum",info.UserNum);
            param.Add("@i_FinishedRate",info.FinishedRate);
            param.Add("@i_StudyRate",info.StudyRate);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_TrainingSub_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTemp_BasicData_TrainingSub(Temp_BasicData_TrainingSubEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_tid",info.tid);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_TeacherNum",info.TeacherNum);
            param.Add("@i_ClassNum",info.ClassNum);
            param.Add("@i_FinishedNum",info.FinishedNum);
            param.Add("@i_StudyNum",info.StudyNum);
            param.Add("@i_UserNum",info.UserNum);
            param.Add("@i_FinishedRate",info.FinishedRate);
            param.Add("@i_StudyRate",info.StudyRate);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_TrainingSub_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTemp_BasicData_TrainingSub(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_TrainingSub_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_TrainingSubInfo GetTemp_BasicData_TrainingSubDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Temp_BasicData_TrainingSub_Detail", param, DBConnEnm.TRDBWrite);

            return (Temp_BasicData_TrainingSubInfo)ORMapping.MapSingleObject(typeof(Temp_BasicData_TrainingSubInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_TrainingSubEntityListResult GetTemp_BasicData_TrainingSubEntityList(Temp_BasicData_TrainingSubSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Temp_BasicData_TrainingSub_List", param, DBConnEnm.TRDBWrite);

            Temp_BasicData_TrainingSubEntityListResult Result= new Temp_BasicData_TrainingSubEntityListResult();
            Result.Temp_BasicData_TrainingSubList = (List<Temp_BasicData_TrainingSubInfo>)ORMapping.MapListObject(typeof(Temp_BasicData_TrainingSubInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}