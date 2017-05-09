using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Training.BL;
using RH.Training.Entity;
using Webdiyer.WebControls.Mvc;

namespace RH.Training.Web.Controllers
{
    ///<summary>
    ///RH_Product ( RH_Product ) Controller类
    ///</summary>
    public class ProductController : Controller
    {

        /// <summary>
        /// 添加RH_Product
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ProductAdd()
        {
            string ProductName = string.IsNullOrEmpty(Request["ProductName"])? "" : Request["ProductName"].ToString();
            string ProductCode = string.IsNullOrEmpty(Request["ProductCode"])? "" : Request["ProductCode"].ToString();
            int ProductLevel = string.IsNullOrEmpty(Request["ProductLevel"])? 0 : int.Parse(Request["ProductLevel"]);
            string ProductUrl = string.IsNullOrEmpty(Request["ProductUrl"])? "" : Request["ProductUrl"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            ProductEntity entity = new ProductEntity();
            entity.ProductName = ProductName;
            entity.ProductCode = ProductCode;
            entity.ProductLevel = ProductLevel;
            entity.ProductUrl = ProductUrl;
            entity.Status = Status;
            entity.ProvinceID = ProvinceID;
            entity.CityID = CityID;
            entity.DistrictID = DistrictID;
            entity.StaticUrl = StaticUrl;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = ProductBL.AddProduct(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Product(RH_Product)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Product
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ProductModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string ProductName = string.IsNullOrEmpty(Request["ProductName"])? "" : Request["ProductName"].ToString();
            string ProductCode = string.IsNullOrEmpty(Request["ProductCode"])? "" : Request["ProductCode"].ToString();
            int ProductLevel = string.IsNullOrEmpty(Request["ProductLevel"])? 0 : int.Parse(Request["ProductLevel"]);
            string ProductUrl = string.IsNullOrEmpty(Request["ProductUrl"])? "" : Request["ProductUrl"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            ProductEntity entity = new ProductEntity();
            entity.ProductName = ProductName;
            entity.ProductCode = ProductCode;
            entity.ProductLevel = ProductLevel;
            entity.ProductUrl = ProductUrl;
            entity.Status = Status;
            entity.ProvinceID = ProvinceID;
            entity.CityID = CityID;
            entity.DistrictID = DistrictID;
            entity.StaticUrl = StaticUrl;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = ProductBL.ModifyProduct(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Product(RH_Product)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult ProductView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            ProductEntity entity = new ProductEntity();
            try
            {
               entity = ProductBL.GatProductDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Product(RH_Product)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int ProductRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = ProductBL.RemoveProduct(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Product(RH_Product)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Product
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult ProductList()
        {
            //ProductRH_Product
            ProductEntityListResult listResult = new ProductEntityListResult();

            ProductSearcher Searcher = new ProductSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<ProductInfo> mPage = null;
            try
            {
               listResult = ProductBL.GetProductEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.ProductList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Product(RH_Product)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(mPage) ;

       }


        #region 属性
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex 
        { 
           get 
           { 
              if (string.IsNullOrEmpty(Request["page"])) 
              {
                 return 1;
              }
              else
              {
                 int i;
                 return int.TryParse(Request["page"], out i) ? int.Parse(Request["page"]) : 1;
              }
           }
        }

        /// <summary>
        /// 每页数量
        /// </summary>
        public int PageSize 
        { 
           get 
           { 
              if (string.IsNullOrEmpty(Request["PageSize"])) 
              {
                 return 10;
              }
              else
              {
                 int i;
                 return int.TryParse(Request["PageSize"], out i) ? int.Parse(Request["PageSize"]) : 10;
              }
           }
        }

        #endregion

    }
}