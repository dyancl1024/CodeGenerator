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
    ///RH_DesignBusiness ( RH_DesignBusiness ) Controller类
    ///</summary>
    public class DesignBusinessController : Controller
    {

        /// <summary>
        /// 添加RH_DesignBusiness
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignBusinessAdd()
        {
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignBusinessEntity entity = new DesignBusinessEntity();
            entity.DesignID = DesignID;
            entity.UserID = UserID;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = DesignBusinessBL.AddDesignBusiness(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加DesignBusiness(RH_DesignBusiness)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_DesignBusiness
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignBusinessModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignBusinessEntity entity = new DesignBusinessEntity();
            entity.DesignID = DesignID;
            entity.UserID = UserID;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = DesignBusinessBL.ModifyDesignBusiness(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改DesignBusiness(RH_DesignBusiness)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignBusinessView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            DesignBusinessEntity entity = new DesignBusinessEntity();
            try
            {
               entity = DesignBusinessBL.GatDesignBusinessDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情DesignBusiness(RH_DesignBusiness)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DesignBusinessRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = DesignBusinessBL.RemoveDesignBusiness(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignBusiness(RH_DesignBusiness)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignBusinessList()
        {
            //DesignBusinessRH_DesignBusiness
            DesignBusinessEntityListResult listResult = new DesignBusinessEntityListResult();

            DesignBusinessSearcher Searcher = new DesignBusinessSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<DesignBusinessInfo> mPage = null;
            try
            {
               listResult = DesignBusinessBL.GetDesignBusinessEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.DesignBusinessList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignBusiness(RH_DesignBusiness)出错" + DateTime.Now + "**************************");
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