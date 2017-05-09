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
    ///RH_DesignSuggest ( RH_DesignSuggest ) Controller类
    ///</summary>
    public class DesignSuggestController : Controller
    {

        /// <summary>
        /// 添加RH_DesignSuggest
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignSuggestAdd()
        {
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            string DSuggest = string.IsNullOrEmpty(Request["DSuggest"])? "" : Request["DSuggest"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignSuggestEntity entity = new DesignSuggestEntity();
            entity.DesignID = DesignID;
            entity.DSuggest = DSuggest;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = DesignSuggestBL.AddDesignSuggest(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加DesignSuggest(RH_DesignSuggest)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_DesignSuggest
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignSuggestModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            string DSuggest = string.IsNullOrEmpty(Request["DSuggest"])? "" : Request["DSuggest"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignSuggestEntity entity = new DesignSuggestEntity();
            entity.DesignID = DesignID;
            entity.DSuggest = DSuggest;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = DesignSuggestBL.ModifyDesignSuggest(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改DesignSuggest(RH_DesignSuggest)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignSuggestView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            DesignSuggestEntity entity = new DesignSuggestEntity();
            try
            {
               entity = DesignSuggestBL.GatDesignSuggestDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情DesignSuggest(RH_DesignSuggest)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DesignSuggestRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = DesignSuggestBL.RemoveDesignSuggest(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignSuggest(RH_DesignSuggest)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignSuggestList()
        {
            //DesignSuggestRH_DesignSuggest
            DesignSuggestEntityListResult listResult = new DesignSuggestEntityListResult();

            DesignSuggestSearcher Searcher = new DesignSuggestSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<DesignSuggestInfo> mPage = null;
            try
            {
               listResult = DesignSuggestBL.GetDesignSuggestEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.DesignSuggestList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignSuggest(RH_DesignSuggest)出错" + DateTime.Now + "**************************");
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