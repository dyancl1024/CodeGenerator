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
    ///RH_AssessmentOptions ( RH_AssessmentOptions ) Controller类
    ///</summary>
    public class AssessmentOptionsController : Controller
    {

        /// <summary>
        /// 添加RH_AssessmentOptions
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentOptionsAdd()
        {
            int QID = string.IsNullOrEmpty(Request["QID"])? 0 : int.Parse(Request["QID"]);
            string Options = string.IsNullOrEmpty(Request["Options"])? "" : Request["Options"].ToString();
            int SortNO = string.IsNullOrEmpty(Request["SortNO"])? 0 : int.Parse(Request["SortNO"]);
            int Score = string.IsNullOrEmpty(Request["Score"])? 0 : int.Parse(Request["Score"]);

            ////构建实体对象
            AssessmentOptionsEntity entity = new AssessmentOptionsEntity();
            entity.QID = QID;
            entity.Options = Options;
            entity.SortNO = SortNO;
            entity.Score = Score;
            int result = 0;
            try
            {
               result = AssessmentOptionsBL.AddAssessmentOptions(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加AssessmentOptions(RH_AssessmentOptions)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_AssessmentOptions
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentOptionsModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int QID = string.IsNullOrEmpty(Request["QID"])? 0 : int.Parse(Request["QID"]);
            string Options = string.IsNullOrEmpty(Request["Options"])? "" : Request["Options"].ToString();
            int SortNO = string.IsNullOrEmpty(Request["SortNO"])? 0 : int.Parse(Request["SortNO"]);
            int Score = string.IsNullOrEmpty(Request["Score"])? 0 : int.Parse(Request["Score"]);

            ////构建实体对象
            AssessmentOptionsEntity entity = new AssessmentOptionsEntity();
            entity.QID = QID;
            entity.Options = Options;
            entity.SortNO = SortNO;
            entity.Score = Score;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = AssessmentOptionsBL.ModifyAssessmentOptions(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改AssessmentOptions(RH_AssessmentOptions)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentOptionsView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            AssessmentOptionsEntity entity = new AssessmentOptionsEntity();
            try
            {
               entity = AssessmentOptionsBL.GatAssessmentOptionsDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情AssessmentOptions(RH_AssessmentOptions)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int AssessmentOptionsRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = AssessmentOptionsBL.RemoveAssessmentOptions(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentOptions(RH_AssessmentOptions)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentOptionsList()
        {
            //AssessmentOptionsRH_AssessmentOptions
            AssessmentOptionsEntityListResult listResult = new AssessmentOptionsEntityListResult();

            AssessmentOptionsSearcher Searcher = new AssessmentOptionsSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<AssessmentOptionsInfo> mPage = null;
            try
            {
               listResult = AssessmentOptionsBL.GetAssessmentOptionsEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.AssessmentOptionsList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentOptions(RH_AssessmentOptions)出错" + DateTime.Now + "**************************");
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