using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

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
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Product_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Product
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyProduct(ProductEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Product_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveProduct(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Product_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProductEntity GetProductDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Product_Detail", param, DBConnEnm.TRDBWrite);
            return (ProductEntity)ORMapping.MapSingleObject(typeof(ProductEntity),dt);
        }
    }
}