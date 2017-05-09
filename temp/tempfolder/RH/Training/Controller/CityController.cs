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
    ///RH_City ( RH_City ) Controller类
    ///</summary>
    public class CityController : Controller
    {

        /// <summary>
        /// 添加RH_City
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CityAdd()
        {
            string CityName = string.IsNullOrEmpty(Request["CityName"])? "" : Request["CityName"].ToString();
            string CityPY = string.IsNullOrEmpty(Request["CityPY"])? "" : Request["CityPY"].ToString();
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);

            ////构建实体对象
            CityEntity entity = new CityEntity();
            entity.CityName = CityName;
            entity.CityPY = CityPY;
            entity.ProvinceID = ProvinceID;
            int result = 0;
            try
            {
               result = CityBL.AddCity(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加City(RH_City)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_City
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CityModify()
        {
            int id = string.IsNullOrEmpty(Request["id"])? 0 : int.Parse(Request["id"]);
            string CityName = string.IsNullOrEmpty(Request["CityName"])? "" : Request["CityName"].ToString();
            string CityPY = string.IsNullOrEmpty(Request["CityPY"])? "" : Request["CityPY"].ToString();
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);

            ////构建实体对象
            CityEntity entity = new CityEntity();
            entity.CityName = CityName;
            entity.CityPY = CityPY;
            entity.ProvinceID = ProvinceID;
            entity.id = id;
            int result = 0;
            try
            {
               result = CityBL.ModifyCity(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改City(RH_City)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CityView()
        {
            int id = string.IsNullOrEmpty(Request["id"])? 0 : int.Parse(Request["id"]);

            ////构建实体对象
            CityEntity entity = new CityEntity();
            try
            {
               entity = CityBL.GatCityDetail(id);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情City(RH_City)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CityRemove()
        {
            int id = string.IsNullOrEmpty(Request["id"])? 0 : int.Parse(Request["id"]);
            int result = 0;

            try
            {
               result = CityBL.RemoveCity(id);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除City(RH_City)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CityList()
        {
            //CityRH_City
            CityEntityListResult listResult = new CityEntityListResult();

            CitySearcher Searcher = new CitySearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CityInfo> mPage = null;
            try
            {
               listResult = CityBL.GetCityEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CityList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除City(RH_City)出错" + DateTime.Now + "**************************");
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