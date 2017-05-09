using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TempUser ( RH_TempUser ) DB类
    ///</summary>
    public class TempUserDB
    {

        /// <summary>
        /// 添加RH_TempUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTempUser(TempUserEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_UserName",info.UserName);
            param.Add("@i_Password",info.Password);
            param.Add("@i_TrueName",info.TrueName);
            param.Add("@i_Gender",info.Gender);
            param.Add("@i_PicUrl",info.PicUrl);
            param.Add("@i_Nation",info.Nation);
            param.Add("@i_IDNO",info.IDNO);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.Add("@i_CityID",info.CityID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_Mobile",info.Mobile);
            param.Add("@i_Email",info.Email);
            param.Add("@i_QQ",info.QQ);
            param.Add("@i_IPAddr",info.IPAddr);
            param.Add("@i_IsChange",info.IsChange);
            param.Add("@i_UserState",info.UserState);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.Add("@i_CUserName",info.CUserName);
            param.Add("@i_CPassword",info.CPassword);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_SchoolID",info.SchoolID);
            param.Add("@i_SchoolName",info.SchoolName);
            param.Add("@i_TempRemark",info.TempRemark);
            param.Add("@i_TempUserID",info.TempUserID);
            param.Add("@i_TempClassName",info.TempClassName);
            param.Add("@i_TempClassID",info.TempClassID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TempUser_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TempUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTempUser(TempUserEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_id",info.id);
            param.Add("@i_UserName",info.UserName);
            param.Add("@i_Password",info.Password);
            param.Add("@i_TrueName",info.TrueName);
            param.Add("@i_Gender",info.Gender);
            param.Add("@i_PicUrl",info.PicUrl);
            param.Add("@i_Nation",info.Nation);
            param.Add("@i_IDNO",info.IDNO);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.Add("@i_CityID",info.CityID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_Mobile",info.Mobile);
            param.Add("@i_Email",info.Email);
            param.Add("@i_QQ",info.QQ);
            param.Add("@i_IPAddr",info.IPAddr);
            param.Add("@i_IsChange",info.IsChange);
            param.Add("@i_UserState",info.UserState);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.Add("@i_CUserName",info.CUserName);
            param.Add("@i_CPassword",info.CPassword);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_SchoolID",info.SchoolID);
            param.Add("@i_SchoolName",info.SchoolName);
            param.Add("@i_TempRemark",info.TempRemark);
            param.Add("@i_TempUserID",info.TempUserID);
            param.Add("@i_TempClassName",info.TempClassName);
            param.Add("@i_TempClassID",info.TempClassID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TempUser_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTempUser(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_id",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TempUser_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TempUserInfo GetTempUserDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_id",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TempUser_Detail", param, DBConnEnm.TRDBWrite);

            return (TempUserInfo)ORMapping.MapSingleObject(typeof(TempUserInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TempUserEntityListResult GetTempUserEntityList(TempUserSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TempUser_List", param, DBConnEnm.TRDBWrite);

            TempUserEntityListResult Result= new TempUserEntityListResult();
            Result.TempUserList = (List<TempUserInfo>)ORMapping.MapListObject(typeof(TempUserInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}