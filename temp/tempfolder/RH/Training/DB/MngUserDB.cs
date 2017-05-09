using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_MngUser ( RH_MngUser ) DB类
    ///</summary>
    public class MngUserDB
    {

        /// <summary>
        /// 添加RH_MngUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngUser(MngUserEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_UserName",info.UserName);
            param.Add("@i_Password",info.Password);
            param.Add("@i_TrueName",info.TrueName);
            param.Add("@i_RoleID",info.RoleID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngUser_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_MngUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngUser(MngUserEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_UserName",info.UserName);
            param.Add("@i_Password",info.Password);
            param.Add("@i_TrueName",info.TrueName);
            param.Add("@i_RoleID",info.RoleID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngUser_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngUser(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngUser_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngUserInfo GetMngUserDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_MngUser_Detail", param, DBConnEnm.TRDBWrite);

            return (MngUserInfo)ORMapping.MapSingleObject(typeof(MngUserInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngUserEntityListResult GetMngUserEntityList(MngUserSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_MngUser_List", param, DBConnEnm.TRDBWrite);

            MngUserEntityListResult Result= new MngUserEntityListResult();
            Result.MngUserList = (List<MngUserInfo>)ORMapping.MapListObject(typeof(MngUserInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}