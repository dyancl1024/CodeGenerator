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
    ///RH_District ( RH_District ) Controller类
    ///</summary>
    public class DistrictController : Controller
    {

        /// <summary>
        /// 添加RH_District
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DistrictAdd()
        {
            string DistrictName = string.IsNullOrEmpty(Request["DistrictName"])? "" : Request["DistrictName"].ToString();
            string DistrictPY = string.IsNullOrEmpty(Request["DistrictPY"])? "" : Request["DistrictPY"].ToString();
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);

            ////构建实体对象
            DistrictEntity entity = new DistrictEntity();
            entity.DistrictName = DistrictName;
            entity.DistrictPY = DistrictPY;
            entity.CityID = CityID;
            int result = 0;
            try
            {
               result = DistrictBL.AddDistrict(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加District(RH_District)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_District
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DistrictModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string DistrictName = string.IsNullOrEmpty(Request["DistrictName"])? "" : Request["DistrictName"].ToString();
            string DistrictPY = string.IsNullOrEmpty(Request["DistrictPY"])? "" : Request["DistrictPY"].ToString();
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);

            ////构建实体对象
            DistrictEntity entity = new DistrictEntity();
            entity.DistrictName = DistrictName;
            entity.DistrictPY = DistrictPY;
            entity.CityID = CityID;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = DistrictBL.ModifyDistrict(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改District(RH_District)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DistrictView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            DistrictEntity entity = new DistrictEntity();
            try
            {
               entity = DistrictBL.GatDistrictDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情District(RH_District)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DistrictRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = DistrictBL.RemoveDistrict(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除District(RH_District)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DistrictList()
        {
            //DistrictRH_District
            DistrictEntityListResult listResult = new DistrictEntityListResult();

            DistrictSearcher Searcher = new DistrictSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<DistrictInfo> mPage = null;
            try
            {
               listResult = DistrictBL.GetDistrictEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.DistrictList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除District(RH_District)出错" + DateTime.Now + "**************************");
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