using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_BannerArea ( RH_BannerArea ) DB类
    ///</summary>
    public class BannerAreaDB
    {

        /// <summary>
        /// 添加RH_BannerArea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBannerArea(BannerAreaEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_AreaCode",info.AreaCode);
            param.Add("@i_AreaName",info.AreaName);
            param.Add("@i_AreaWidth",info.AreaWidth);
            param.Add("@i_AreaHight",info.AreaHight);
            param.Add("@i_AreaType",info.AreaType);
            param.Add("@i_AreaPicUrl",info.AreaPicUrl);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_BannerArea_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_BannerArea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBannerArea(BannerAreaEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_AreaCode",info.AreaCode);
            param.Add("@i_AreaName",info.AreaName);
            param.Add("@i_AreaWidth",info.AreaWidth);
            param.Add("@i_AreaHight",info.AreaHight);
            param.Add("@i_AreaType",info.AreaType);
            param.Add("@i_AreaPicUrl",info.AreaPicUrl);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_BannerArea_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBannerArea(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_BannerArea_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerAreaInfo GetBannerAreaDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_BannerArea_Detail", param, DBConnEnm.TRDBWrite);

            return (BannerAreaInfo)ORMapping.MapSingleObject(typeof(BannerAreaInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerAreaEntityListResult GetBannerAreaEntityList(BannerAreaSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_BannerArea_List", param, DBConnEnm.TRDBWrite);

            BannerAreaEntityListResult Result= new BannerAreaEntityListResult();
            Result.BannerAreaList = (List<BannerAreaInfo>)ORMapping.MapListObject(typeof(BannerAreaInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}