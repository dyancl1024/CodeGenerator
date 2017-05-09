using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Banner ( RH_Banner ) DB类
    ///</summary>
    public class BannerDB
    {

        /// <summary>
        /// 添加RH_Banner
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBanner(BannerEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ADTitle",info.ADTitle);
            param.Add("@i_AreaCode",info.AreaCode);
            param.Add("@i_ADPhotoUrl",info.ADPhotoUrl);
            param.Add("@i_ADContentType",info.ADContentType);
            param.Add("@i_ADContentURL",info.ADContentURL);
            param.Add("@i_ADContent",info.ADContent);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Banner_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Banner
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBanner(BannerEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_ADTitle",info.ADTitle);
            param.Add("@i_AreaCode",info.AreaCode);
            param.Add("@i_ADPhotoUrl",info.ADPhotoUrl);
            param.Add("@i_ADContentType",info.ADContentType);
            param.Add("@i_ADContentURL",info.ADContentURL);
            param.Add("@i_ADContent",info.ADContent);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Banner_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBanner(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Banner_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerInfo GetBannerDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Banner_Detail", param, DBConnEnm.TRDBWrite);

            return (BannerInfo)ORMapping.MapSingleObject(typeof(BannerInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerEntityListResult GetBannerEntityList(BannerSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Banner_List", param, DBConnEnm.TRDBWrite);

            BannerEntityListResult Result= new BannerEntityListResult();
            Result.BannerList = (List<BannerInfo>)ORMapping.MapListObject(typeof(BannerInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}