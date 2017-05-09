using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_MngRoleRight ( RH_MngRoleRight ) DB类
    ///</summary>
    public class MngRoleRightDB
    {

        /// <summary>
        /// 添加RH_MngRoleRight
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngRoleRight(MngRoleRightEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_RoleCode",info.RoleCode);
            param.Add("@i_MenuCode",info.MenuCode);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngRoleRight_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_MngRoleRight
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngRoleRight(MngRoleRightEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_RoleCode",info.RoleCode);
            param.Add("@i_MenuCode",info.MenuCode);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngRoleRight_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngRoleRight(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngRoleRight_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngRoleRightInfo GetMngRoleRightDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_MngRoleRight_Detail", param, DBConnEnm.TRDBWrite);

            return (MngRoleRightInfo)ORMapping.MapSingleObject(typeof(MngRoleRightInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngRoleRightEntityListResult GetMngRoleRightEntityList(MngRoleRightSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_MngRoleRight_List", param, DBConnEnm.TRDBWrite);

            MngRoleRightEntityListResult Result= new MngRoleRightEntityListResult();
            Result.MngRoleRightList = (List<MngRoleRightInfo>)ORMapping.MapListObject(typeof(MngRoleRightInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}