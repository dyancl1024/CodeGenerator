using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignContent ( RH_DesignContent ) DB类
    ///</summary>
    public class DesignContentDB
    {

        /// <summary>
        /// 添加RH_DesignContent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignContent(DesignContentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_DType",info.DType);
            param.Add("@i_DName",info.DName);
            param.Add("@i_DContent",info.DContent);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignContent_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignContent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignContent(DesignContentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_DType",info.DType);
            param.Add("@i_DName",info.DName);
            param.Add("@i_DContent",info.DContent);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignContent_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignContent(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignContent_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentInfo GetDesignContentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_DesignContent_Detail", param, DBConnEnm.TRDBWrite);

            return (DesignContentInfo)ORMapping.MapSingleObject(typeof(DesignContentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentEntityListResult GetDesignContentEntityList(DesignContentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_DesignContent_List", param, DBConnEnm.TRDBWrite);

            DesignContentEntityListResult Result= new DesignContentEntityListResult();
            Result.DesignContentList = (List<DesignContentInfo>)ORMapping.MapListObject(typeof(DesignContentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}