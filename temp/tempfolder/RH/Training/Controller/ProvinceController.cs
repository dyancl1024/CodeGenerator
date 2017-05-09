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
    ///RH_Province ( RH_Province ) Controller类
    ///</summary>
    public class ProvinceController : Controller
    {

        /// <summary>
        /// 添加RH_Province
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ProvinceAdd()
        {
            string ProvinceName = string.IsNullOrEmpty(Request["ProvinceName"])? "" : Request["ProvinceName"].ToString();
            string ProvincePY = string.IsNullOrEmpty(Request["ProvincePY"])? "" : Request["ProvincePY"].ToString();
            int CountyID = string.IsNullOrEmpty(Request["CountyID"])? 0 : int.Parse(Request["CountyID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            ProvinceEntity entity = new ProvinceEntity();
            entity.ProvinceName = ProvinceName;
            entity.ProvincePY = ProvincePY;
            entity.CountyID = CountyID;
            entity.Status = Status;
            int result = 0;
            try
            {
               result = ProvinceBL.AddProvince(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Province(RH_Province)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Province
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ProvinceModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string ProvinceName = string.IsNullOrEmpty(Request["ProvinceName"])? "" : Request["ProvinceName"].ToString();
            string ProvincePY = string.IsNullOrEmpty(Request["ProvincePY"])? "" : Request["ProvincePY"].ToString();
            int CountyID = string.IsNullOrEmpty(Request["CountyID"])? 0 : int.Parse(Request["CountyID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            ProvinceEntity entity = new ProvinceEntity();
            entity.ProvinceName = ProvinceName;
            entity.ProvincePY = ProvincePY;
            entity.CountyID = CountyID;
            entity.Status = Status;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = ProvinceBL.ModifyProvince(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Province(RH_Province)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult ProvinceView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            ProvinceEntity entity = new ProvinceEntity();
            try
            {
               entity = ProvinceBL.GatProvinceDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Province(RH_Province)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int ProvinceRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = ProvinceBL.RemoveProvince(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Province(RH_Province)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult ProvinceList()
        {
            //ProvinceRH_Province
            ProvinceEntityListResult listResult = new ProvinceEntityListResult();

            ProvinceSearcher Searcher = new ProvinceSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<ProvinceInfo> mPage = null;
            try
            {
               listResult = ProvinceBL.GetProvinceEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.ProvinceList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Province(RH_Province)出错" + DateTime.Now + "**************************");
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