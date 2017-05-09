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
    ///RH_Expert ( RH_Expert ) Controller类
    ///</summary>
    public class ExpertController : Controller
    {

        /// <summary>
        /// 添加RH_Expert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ExpertAdd()
        {
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            ExpertEntity entity = new ExpertEntity();
            entity.UserID = UserID;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = ExpertBL.AddExpert(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Expert(RH_Expert)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Expert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ExpertModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            ExpertEntity entity = new ExpertEntity();
            entity.UserID = UserID;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = ExpertBL.ModifyExpert(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Expert(RH_Expert)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult ExpertView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            ExpertEntity entity = new ExpertEntity();
            try
            {
               entity = ExpertBL.GatExpertDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Expert(RH_Expert)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int ExpertRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = ExpertBL.RemoveExpert(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Expert(RH_Expert)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult ExpertList()
        {
            //ExpertRH_Expert
            ExpertEntityListResult listResult = new ExpertEntityListResult();

            ExpertSearcher Searcher = new ExpertSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<ExpertInfo> mPage = null;
            try
            {
               listResult = ExpertBL.GetExpertEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.ExpertList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Expert(RH_Expert)出错" + DateTime.Now + "**************************");
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