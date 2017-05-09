using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Product ( RH_Product ) DB类
    ///</summary>
    public class ProductDB
    {

        /// <summary>
        /// 添加RH_Product
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddProduct(ProductEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ProductName",info.ProductName);
            param.Add("@i_ProductCode",info.ProductCode);
            param.Add("@i_ProductLevel",info.ProductLevel);
            param.Add("@i_ProductUrl",info.ProductUrl);
            param.Add("@i_Status",info.Status);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.Add("@i_CityID",info.CityID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Product_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Product
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyProduct(ProductEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_ProductName",info.ProductName);
            param.Add("@i_ProductCode",info.ProductCode);
            param.Add("@i_ProductLevel",info.ProductLevel);
            param.Add("@i_ProductUrl",info.ProductUrl);
            param.Add("@i_Status",info.Status);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.Add("@i_CityID",info.CityID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Product_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveProduct(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Product_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProductInfo GetProductDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Product_Detail", param, DBConnEnm.TRDBWrite);

            return (ProductInfo)ORMapping.MapSingleObject(typeof(ProductInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProductEntityListResult GetProductEntityList(ProductSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Product_List", param, DBConnEnm.TRDBWrite);

            ProductEntityListResult Result= new ProductEntityListResult();
            Result.ProductList = (List<ProductInfo>)ORMapping.MapListObject(typeof(ProductInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}