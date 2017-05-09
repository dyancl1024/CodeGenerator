using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Design ( RH_Design ) DB类
    ///</summary>
    public class DesignDB
    {

        /// <summary>
        /// 添加RH_Design
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesign(DesignEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignName",info.DesignName);
            param.Add("@i_TrainingLevelCode",info.TrainingLevelCode);
            param.Add("@i_TrainingTypeCode",info.TrainingTypeCode);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.Add("@i_CityID",info.CityID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_OrgCode",info.OrgCode);
            param.Add("@i_TrainingNum",info.TrainingNum);
            param.Add("@i_TrainingPhase",info.TrainingPhase);
            param.Add("@i_TrainingDateB",info.TrainingDateB);
            param.Add("@i_TrainingDateE",info.TrainingDateE);
            param.Add("@i_DesignDesc",info.DesignDesc);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Design_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Design
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesign(DesignEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignName",info.DesignName);
            param.Add("@i_TrainingLevelCode",info.TrainingLevelCode);
            param.Add("@i_TrainingTypeCode",info.TrainingTypeCode);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.Add("@i_CityID",info.CityID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_OrgCode",info.OrgCode);
            param.Add("@i_TrainingNum",info.TrainingNum);
            param.Add("@i_TrainingPhase",info.TrainingPhase);
            param.Add("@i_TrainingDateB",info.TrainingDateB);
            param.Add("@i_TrainingDateE",info.TrainingDateE);
            param.Add("@i_DesignDesc",info.DesignDesc);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Design_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesign(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Design_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignInfo GetDesignDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Design_Detail", param, DBConnEnm.TRDBWrite);

            return (DesignInfo)ORMapping.MapSingleObject(typeof(DesignInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignEntityListResult GetDesignEntityList(DesignSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Design_List", param, DBConnEnm.TRDBWrite);

            DesignEntityListResult Result= new DesignEntityListResult();
            Result.DesignList = (List<DesignInfo>)ORMapping.MapListObject(typeof(DesignInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}