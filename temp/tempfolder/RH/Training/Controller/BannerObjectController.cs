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
    ///RH_BannerObject ( RH_BannerObject ) Controller类
    ///</summary>
    public class BannerObjectController : Controller
    {

        /// <summary>
        /// 添加RH_BannerObject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int BannerObjectAdd()
        {
            int BannerID = string.IsNullOrEmpty(Request["BannerID"])? 0 : int.Parse(Request["BannerID"]);
            int ObjectID = string.IsNullOrEmpty(Request["ObjectID"])? 0 : int.Parse(Request["ObjectID"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            BannerObjectEntity entity = new BannerObjectEntity();
            entity.BannerID = BannerID;
            entity.ObjectID = ObjectID;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = BannerObjectBL.AddBannerObject(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加BannerObject(RH_BannerObject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_BannerObject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int BannerObjectModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int BannerID = string.IsNullOrEmpty(Request["BannerID"])? 0 : int.Parse(Request["BannerID"]);
            int ObjectID = string.IsNullOrEmpty(Request["ObjectID"])? 0 : int.Parse(Request["ObjectID"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            BannerObjectEntity entity = new BannerObjectEntity();
            entity.BannerID = BannerID;
            entity.ObjectID = ObjectID;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = BannerObjectBL.ModifyBannerObject(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改BannerObject(RH_BannerObject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult BannerObjectView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            BannerObjectEntity entity = new BannerObjectEntity();
            try
            {
               entity = BannerObjectBL.GatBannerObjectDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情BannerObject(RH_BannerObject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int BannerObjectRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = BannerObjectBL.RemoveBannerObject(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除BannerObject(RH_BannerObject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult BannerObjectList()
        {
            //BannerObjectRH_BannerObject
            BannerObjectEntityListResult listResult = new BannerObjectEntityListResult();

            BannerObjectSearcher Searcher = new BannerObjectSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<BannerObjectInfo> mPage = null;
            try
            {
               listResult = BannerObjectBL.GetBannerObjectEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.BannerObjectList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除BannerObject(RH_BannerObject)出错" + DateTime.Now + "**************************");
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