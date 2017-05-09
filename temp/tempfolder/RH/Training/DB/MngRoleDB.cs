using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_MngRole ( RH_MngRole ) DB类
    ///</summary>
    public class MngRoleDB
    {

        /// <summary>
        /// 添加RH_MngRole
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngRole(MngRoleEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_RoleName",info.RoleName);
            param.Add("@i_RoleCode",info.RoleCode);
            param.Add("@i_SortNum",info.SortNum);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngRole_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_MngRole
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngRole(MngRoleEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_RoleName",info.RoleName);
            param.Add("@i_RoleCode",info.RoleCode);
            param.Add("@i_SortNum",info.SortNum);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngRole_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngRole(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngRole_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngRoleInfo GetMngRoleDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_MngRole_Detail", param, DBConnEnm.TRDBWrite);

            return (MngRoleInfo)ORMapping.MapSingleObject(typeof(MngRoleInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngRoleEntityListResult GetMngRoleEntityList(MngRoleSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_MngRole_List", param, DBConnEnm.TRDBWrite);

            MngRoleEntityListResult Result= new MngRoleEntityListResult();
            Result.MngRoleList = (List<MngRoleInfo>)ORMapping.MapListObject(typeof(MngRoleInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}