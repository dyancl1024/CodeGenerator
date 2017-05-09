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
    ///RH_AssessmentAnswerBak ( RH_AssessmentAnswerBak ) Controller类
    ///</summary>
    public class AssessmentAnswerBakController : Controller
    {

        /// <summary>
        /// 添加RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentAnswerBakAdd()
        {
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int QID = string.IsNullOrEmpty(Request["QID"])? 0 : int.Parse(Request["QID"]);
            int QType = string.IsNullOrEmpty(Request["QType"])? 0 : int.Parse(Request["QType"]);
            int OptionID = string.IsNullOrEmpty(Request["OptionID"])? 0 : int.Parse(Request["OptionID"]);
            int Score = string.IsNullOrEmpty(Request["Score"])? 0 : int.Parse(Request["Score"]);

            ////构建实体对象
            AssessmentAnswerBakEntity entity = new AssessmentAnswerBakEntity();
            entity.SubTID = SubTID;
            entity.UserID = UserID;
            entity.QID = QID;
            entity.QType = QType;
            entity.OptionID = OptionID;
            entity.Score = Score;
            int result = 0;
            try
            {
               result = AssessmentAnswerBakBL.AddAssessmentAnswerBak(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加AssessmentAnswerBak(RH_AssessmentAnswerBak)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentAnswerBakModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int QID = string.IsNullOrEmpty(Request["QID"])? 0 : int.Parse(Request["QID"]);
            int QType = string.IsNullOrEmpty(Request["QType"])? 0 : int.Parse(Request["QType"]);
            int OptionID = string.IsNullOrEmpty(Request["OptionID"])? 0 : int.Parse(Request["OptionID"]);
            int Score = string.IsNullOrEmpty(Request["Score"])? 0 : int.Parse(Request["Score"]);

            ////构建实体对象
            AssessmentAnswerBakEntity entity = new AssessmentAnswerBakEntity();
            entity.SubTID = SubTID;
            entity.UserID = UserID;
            entity.QID = QID;
            entity.QType = QType;
            entity.OptionID = OptionID;
            entity.Score = Score;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = AssessmentAnswerBakBL.ModifyAssessmentAnswerBak(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改AssessmentAnswerBak(RH_AssessmentAnswerBak)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentAnswerBakView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            AssessmentAnswerBakEntity entity = new AssessmentAnswerBakEntity();
            try
            {
               entity = AssessmentAnswerBakBL.GatAssessmentAnswerBakDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情AssessmentAnswerBak(RH_AssessmentAnswerBak)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int AssessmentAnswerBakRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = AssessmentAnswerBakBL.RemoveAssessmentAnswerBak(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentAnswerBak(RH_AssessmentAnswerBak)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentAnswerBakList()
        {
            //AssessmentAnswerBakRH_AssessmentAnswerBak
            AssessmentAnswerBakEntityListResult listResult = new AssessmentAnswerBakEntityListResult();

            AssessmentAnswerBakSearcher Searcher = new AssessmentAnswerBakSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<AssessmentAnswerBakInfo> mPage = null;
            try
            {
               listResult = AssessmentAnswerBakBL.GetAssessmentAnswerBakEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.AssessmentAnswerBakList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentAnswerBak(RH_AssessmentAnswerBak)出错" + DateTime.Now + "**************************");
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