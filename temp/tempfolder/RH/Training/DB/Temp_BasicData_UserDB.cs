using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Temp_BasicData_User ( RH_Temp_BasicData_User ) DB类
    ///</summary>
    public class Temp_BasicData_UserDB
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTemp_BasicData_User(Temp_BasicData_UserEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_ClassID",info.ClassID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_Phase",info.Phase);
            param.Add("@i_Q_jxfs",info.Q_jxfs);
            param.Add("@i_T_jxfs",info.T_jxfs);
            param.Add("@i_F_jxfs",info.F_jxfs);
            param.Add("@i_E_jxfs",info.E_jxfs);
            param.Add("@i_Q_jxcl",info.Q_jxcl);
            param.Add("@i_T_jxcl",info.T_jxcl);
            param.Add("@i_F_jxcl",info.F_jxcl);
            param.Add("@i_E_jxcl",info.E_jxcl);
            param.Add("@i_Q_xxxd",info.Q_xxxd);
            param.Add("@i_T_xxxd",info.T_xxxd);
            param.Add("@i_F_xxxd",info.F_xxxd);
            param.Add("@i_E_xxxd",info.E_xxxd);
            param.Add("@i_Q_wtfx",info.Q_wtfx);
            param.Add("@i_T_wtfx",info.T_wtfx);
            param.Add("@i_F_wtfx",info.F_wtfx);
            param.Add("@i_E_wtfx",info.E_wtfx);
            param.Add("@i_Q_yxrz",info.Q_yxrz);
            param.Add("@i_T_yxrz",info.T_yxrz);
            param.Add("@i_F_yxrz",info.F_yxrz);
            param.Add("@i_E_yxrz",info.E_yxrz);
            param.Add("@i_Q_pxzj",info.Q_pxzj);
            param.Add("@i_T_pxzj",info.T_pxzj);
            param.Add("@i_F_pxzj",info.F_pxzj);
            param.Add("@i_E_pxzj",info.E_pxzj);
            param.Add("@i_Finished",info.Finished);
            param.Add("@i_GetCoursePhase",info.GetCoursePhase);
            param.Add("@i_CoursePhase",info.CoursePhase);
            param.Add("@i_StatusName",info.StatusName);
            param.Add("@i_IsStudy",info.IsStudy);
            param.Add("@i_HomeWorkPhase",info.HomeWorkPhase);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_User_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Temp_BasicData_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTemp_BasicData_User(Temp_BasicData_UserEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_ClassID",info.ClassID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_Phase",info.Phase);
            param.Add("@i_Q_jxfs",info.Q_jxfs);
            param.Add("@i_T_jxfs",info.T_jxfs);
            param.Add("@i_F_jxfs",info.F_jxfs);
            param.Add("@i_E_jxfs",info.E_jxfs);
            param.Add("@i_Q_jxcl",info.Q_jxcl);
            param.Add("@i_T_jxcl",info.T_jxcl);
            param.Add("@i_F_jxcl",info.F_jxcl);
            param.Add("@i_E_jxcl",info.E_jxcl);
            param.Add("@i_Q_xxxd",info.Q_xxxd);
            param.Add("@i_T_xxxd",info.T_xxxd);
            param.Add("@i_F_xxxd",info.F_xxxd);
            param.Add("@i_E_xxxd",info.E_xxxd);
            param.Add("@i_Q_wtfx",info.Q_wtfx);
            param.Add("@i_T_wtfx",info.T_wtfx);
            param.Add("@i_F_wtfx",info.F_wtfx);
            param.Add("@i_E_wtfx",info.E_wtfx);
            param.Add("@i_Q_yxrz",info.Q_yxrz);
            param.Add("@i_T_yxrz",info.T_yxrz);
            param.Add("@i_F_yxrz",info.F_yxrz);
            param.Add("@i_E_yxrz",info.E_yxrz);
            param.Add("@i_Q_pxzj",info.Q_pxzj);
            param.Add("@i_T_pxzj",info.T_pxzj);
            param.Add("@i_F_pxzj",info.F_pxzj);
            param.Add("@i_E_pxzj",info.E_pxzj);
            param.Add("@i_Finished",info.Finished);
            param.Add("@i_GetCoursePhase",info.GetCoursePhase);
            param.Add("@i_CoursePhase",info.CoursePhase);
            param.Add("@i_StatusName",info.StatusName);
            param.Add("@i_IsStudy",info.IsStudy);
            param.Add("@i_HomeWorkPhase",info.HomeWorkPhase);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_User_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTemp_BasicData_User(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_User_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_UserInfo GetTemp_BasicData_UserDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Temp_BasicData_User_Detail", param, DBConnEnm.TRDBWrite);

            return (Temp_BasicData_UserInfo)ORMapping.MapSingleObject(typeof(Temp_BasicData_UserInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_UserEntityListResult GetTemp_BasicData_UserEntityList(Temp_BasicData_UserSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Temp_BasicData_User_List", param, DBConnEnm.TRDBWrite);

            Temp_BasicData_UserEntityListResult Result= new Temp_BasicData_UserEntityListResult();
            Result.Temp_BasicData_UserList = (List<Temp_BasicData_UserInfo>)ORMapping.MapListObject(typeof(Temp_BasicData_UserInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}