using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Org ( RH_Org ) DB类
    ///</summary>
    public class OrgDB
    {

        /// <summary>
        /// 添加RH_Org
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddOrg(OrgEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Org_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Org
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyOrg(OrgEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Org_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveOrg(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Org_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static OrgInfo GetOrgDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Org_Detail", param, DBConnEnm.TRDBWrite);

            return (OrgInfo)ORMapping.MapSingleObject(typeof(OrgInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static OrgEntityListResult GetOrgEntityList(OrgSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Org_List", param, DBConnEnm.TRDBWrite);

            OrgEntityListResult Result= new OrgEntityListResult();
            Result.OrgList = (List<OrgInfo>)ORMapping.MapListObject(typeof(OrgInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}