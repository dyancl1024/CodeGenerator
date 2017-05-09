using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) DB类
    ///</summary>
    public class TrainingClassOfTeacherDB
    {

        /// <summary>
        /// 添加RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClassOfTeacher(TrainingClassOfTeacherEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_ClassID",info.ClassID);
            param.Add("@i_TeacherID",info.TeacherID);
            param.Add("@i_Appointer",info.Appointer);
            param.Add("@i_AppointTime",info.AppointTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassOfTeacher_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClassOfTeacher(TrainingClassOfTeacherEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_ClassID",info.ClassID);
            param.Add("@i_TeacherID",info.TeacherID);
            param.Add("@i_Appointer",info.Appointer);
            param.Add("@i_AppointTime",info.AppointTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassOfTeacher_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClassOfTeacher(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassOfTeacher_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassOfTeacherInfo GetTrainingClassOfTeacherDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingClassOfTeacher_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingClassOfTeacherInfo)ORMapping.MapSingleObject(typeof(TrainingClassOfTeacherInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassOfTeacherEntityListResult GetTrainingClassOfTeacherEntityList(TrainingClassOfTeacherSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingClassOfTeacher_List", param, DBConnEnm.TRDBWrite);

            TrainingClassOfTeacherEntityListResult Result= new TrainingClassOfTeacherEntityListResult();
            Result.TrainingClassOfTeacherList = (List<TrainingClassOfTeacherInfo>)ORMapping.MapListObject(typeof(TrainingClassOfTeacherInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}