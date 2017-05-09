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
    ///RH_Country ( RH_Country ) Controller类
    ///</summary>
    public class CountryController : Controller
    {

        /// <summary>
        /// 添加RH_Country
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CountryAdd()
        {
            string CountryName = string.IsNullOrEmpty(Request["CountryName"])? "" : Request["CountryName"].ToString();
            string CountryPY = string.IsNullOrEmpty(Request["CountryPY"])? "" : Request["CountryPY"].ToString();

            ////构建实体对象
            CountryEntity entity = new CountryEntity();
            entity.CountryName = CountryName;
            entity.CountryPY = CountryPY;
            int result = 0;
            try
            {
               result = CountryBL.AddCountry(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Country(RH_Country)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Country
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CountryModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string CountryName = string.IsNullOrEmpty(Request["CountryName"])? "" : Request["CountryName"].ToString();
            string CountryPY = string.IsNullOrEmpty(Request["CountryPY"])? "" : Request["CountryPY"].ToString();

            ////构建实体对象
            CountryEntity entity = new CountryEntity();
            entity.CountryName = CountryName;
            entity.CountryPY = CountryPY;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CountryBL.ModifyCountry(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Country(RH_Country)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CountryView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CountryEntity entity = new CountryEntity();
            try
            {
               entity = CountryBL.GatCountryDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Country(RH_Country)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CountryRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CountryBL.RemoveCountry(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Country(RH_Country)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CountryList()
        {
            //CountryRH_Country
            CountryEntityListResult listResult = new CountryEntityListResult();

            CountrySearcher Searcher = new CountrySearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CountryInfo> mPage = null;
            try
            {
               listResult = CountryBL.GetCountryEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CountryList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Country(RH_Country)出错" + DateTime.Now + "**************************");
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