using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_BannerObject ( RH_BannerObject ) DB类
    ///</summary>
    public class BannerObjectDB
    {

        /// <summary>
        /// 添加RH_BannerObject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBannerObject(BannerObjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_BannerID",info.BannerID);
            param.Add("@i_ObjectID",info.ObjectID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_BannerObject_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_BannerObject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBannerObject(BannerObjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_BannerID",info.BannerID);
            param.Add("@i_ObjectID",info.ObjectID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_BannerObject_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBannerObject(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_BannerObject_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerObjectInfo GetBannerObjectDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_BannerObject_Detail", param, DBConnEnm.TRDBWrite);

            return (BannerObjectInfo)ORMapping.MapSingleObject(typeof(BannerObjectInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerObjectEntityListResult GetBannerObjectEntityList(BannerObjectSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_BannerObject_List", param, DBConnEnm.TRDBWrite);

            BannerObjectEntityListResult Result= new BannerObjectEntityListResult();
            Result.BannerObjectList = (List<BannerObjectInfo>)ORMapping.MapListObject(typeof(BannerObjectInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}