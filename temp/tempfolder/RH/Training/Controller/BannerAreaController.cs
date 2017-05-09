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
    ///RH_BannerArea ( RH_BannerArea ) Controller类
    ///</summary>
    public class BannerAreaController : Controller
    {

        /// <summary>
        /// 添加RH_BannerArea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int BannerAreaAdd()
        {
            string AreaCode = string.IsNullOrEmpty(Request["AreaCode"])? "" : Request["AreaCode"].ToString();
            string AreaName = string.IsNullOrEmpty(Request["AreaName"])? "" : Request["AreaName"].ToString();
            int AreaWidth = string.IsNullOrEmpty(Request["AreaWidth"])? 0 : int.Parse(Request["AreaWidth"]);
            int AreaHight = string.IsNullOrEmpty(Request["AreaHight"])? 0 : int.Parse(Request["AreaHight"]);
            int AreaType = string.IsNullOrEmpty(Request["AreaType"])? 0 : int.Parse(Request["AreaType"]);
            string AreaPicUrl = string.IsNullOrEmpty(Request["AreaPicUrl"])? "" : Request["AreaPicUrl"].ToString();

            ////构建实体对象
            BannerAreaEntity entity = new BannerAreaEntity();
            entity.AreaCode = AreaCode;
            entity.AreaName = AreaName;
            entity.AreaWidth = AreaWidth;
            entity.AreaHight = AreaHight;
            entity.AreaType = AreaType;
            entity.AreaPicUrl = AreaPicUrl;
            int result = 0;
            try
            {
               result = BannerAreaBL.AddBannerArea(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加BannerArea(RH_BannerArea)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_BannerArea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int BannerAreaModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string AreaCode = string.IsNullOrEmpty(Request["AreaCode"])? "" : Request["AreaCode"].ToString();
            string AreaName = string.IsNullOrEmpty(Request["AreaName"])? "" : Request["AreaName"].ToString();
            int AreaWidth = string.IsNullOrEmpty(Request["AreaWidth"])? 0 : int.Parse(Request["AreaWidth"]);
            int AreaHight = string.IsNullOrEmpty(Request["AreaHight"])? 0 : int.Parse(Request["AreaHight"]);
            int AreaType = string.IsNullOrEmpty(Request["AreaType"])? 0 : int.Parse(Request["AreaType"]);
            string AreaPicUrl = string.IsNullOrEmpty(Request["AreaPicUrl"])? "" : Request["AreaPicUrl"].ToString();

            ////构建实体对象
            BannerAreaEntity entity = new BannerAreaEntity();
            entity.AreaCode = AreaCode;
            entity.AreaName = AreaName;
            entity.AreaWidth = AreaWidth;
            entity.AreaHight = AreaHight;
            entity.AreaType = AreaType;
            entity.AreaPicUrl = AreaPicUrl;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = BannerAreaBL.ModifyBannerArea(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改BannerArea(RH_BannerArea)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult BannerAreaView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            BannerAreaEntity entity = new BannerAreaEntity();
            try
            {
               entity = BannerAreaBL.GatBannerAreaDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情BannerArea(RH_BannerArea)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int BannerAreaRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = BannerAreaBL.RemoveBannerArea(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除BannerArea(RH_BannerArea)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult BannerAreaList()
        {
            //BannerAreaRH_BannerArea
            BannerAreaEntityListResult listResult = new BannerAreaEntityListResult();

            BannerAreaSearcher Searcher = new BannerAreaSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<BannerAreaInfo> mPage = null;
            try
            {
               listResult = BannerAreaBL.GetBannerAreaEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.BannerAreaList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除BannerArea(RH_BannerArea)出错" + DateTime.Now + "**************************");
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