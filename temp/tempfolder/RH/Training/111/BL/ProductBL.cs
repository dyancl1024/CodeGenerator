using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Product ( RH_Product ) BL类
    ///</summary>
    public class ProductBL
    {

        /// <summary>
        /// 添加RH_Product
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddProduct(ProductEntity info)
        {
            return ProductDB.AddProduct(info);
        }


        /// <summary>
        /// 修改RH_Product
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyProduct(ProductEntity info)
        {
            return ProductDB.ModifyProduct(info);
        }


        /// <summary>
        /// 删除RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveProduct(int ID)
        {
            return ProductDB.RemoveProduct(ID);
        }

        /// <summary>
        /// 查看RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProductEntity GetProductDetail(int ID)
        {
            return ProductDB.GetProductDetail(ID);
        }
    }
}