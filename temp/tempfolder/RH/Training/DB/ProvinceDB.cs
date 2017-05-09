using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Province ( RH_Province ) DB类
    ///</summary>
    public class ProvinceDB
    {

        /// <summary>
        /// 添加RH_Province
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddProvince(ProvinceEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ProvinceName",info.ProvinceName);
            param.Add("@i_ProvincePY",info.ProvincePY);
            param.Add("@i_CountyID",info.CountyID);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Province_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Province
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyProvince(ProvinceEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_ProvinceName",info.ProvinceName);
            param.Add("@i_ProvincePY",info.ProvincePY);
            param.Add("@i_CountyID",info.CountyID);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Province_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveProvince(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Province_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProvinceInfo GetProvinceDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Province_Detail", param, DBConnEnm.TRDBWrite);

            return (ProvinceInfo)ORMapping.MapSingleObject(typeof(ProvinceInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProvinceEntityListResult GetProvinceEntityList(ProvinceSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Province_List", param, DBConnEnm.TRDBWrite);

            ProvinceEntityListResult Result= new ProvinceEntityListResult();
            Result.ProvinceList = (List<ProvinceInfo>)ORMapping.MapListObject(typeof(ProvinceInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}