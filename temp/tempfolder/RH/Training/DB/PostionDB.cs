using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Postion ( RH_Postion ) DB类
    ///</summary>
    public class PostionDB
    {

        /// <summary>
        /// 添加RH_Postion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddPostion(PostionEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Postion_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Postion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyPostion(PostionEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Postion_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemovePostion(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Postion_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static PostionInfo GetPostionDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Postion_Detail", param, DBConnEnm.TRDBWrite);

            return (PostionInfo)ORMapping.MapSingleObject(typeof(PostionInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static PostionEntityListResult GetPostionEntityList(PostionSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Postion_List", param, DBConnEnm.TRDBWrite);

            PostionEntityListResult Result= new PostionEntityListResult();
            Result.PostionList = (List<PostionInfo>)ORMapping.MapListObject(typeof(PostionInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}