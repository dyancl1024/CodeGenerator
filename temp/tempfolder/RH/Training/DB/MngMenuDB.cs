using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_MngMenu ( RH_MngMenu ) DB类
    ///</summary>
    public class MngMenuDB
    {

        /// <summary>
        /// 添加RH_MngMenu
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngMenu(MngMenuEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_MenuName",info.MenuName);
            param.Add("@i_MenuUrl",info.MenuUrl);
            param.Add("@i_MenuCode",info.MenuCode);
            param.Add("@i_MenuLevel",info.MenuLevel);
            param.Add("@i_MenuSort",info.MenuSort);
            param.Add("@i_Status",info.Status);
            param.Add("@i_ParentID",info.ParentID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngMenu_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_MngMenu
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngMenu(MngMenuEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_MenuName",info.MenuName);
            param.Add("@i_MenuUrl",info.MenuUrl);
            param.Add("@i_MenuCode",info.MenuCode);
            param.Add("@i_MenuLevel",info.MenuLevel);
            param.Add("@i_MenuSort",info.MenuSort);
            param.Add("@i_Status",info.Status);
            param.Add("@i_ParentID",info.ParentID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngMenu_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngMenu(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_MngMenu_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngMenuInfo GetMngMenuDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_MngMenu_Detail", param, DBConnEnm.TRDBWrite);

            return (MngMenuInfo)ORMapping.MapSingleObject(typeof(MngMenuInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngMenuEntityListResult GetMngMenuEntityList(MngMenuSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_MngMenu_List", param, DBConnEnm.TRDBWrite);

            MngMenuEntityListResult Result= new MngMenuEntityListResult();
            Result.MngMenuList = (List<MngMenuInfo>)ORMapping.MapListObject(typeof(MngMenuInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}