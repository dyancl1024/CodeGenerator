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
    ///RH_AssessmentAnswer ( RH_AssessmentAnswer ) Controller类
    ///</summary>
    public class AssessmentAnswerController : Controller
    {

        /// <summary>
        /// 添加RH_AssessmentAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentAnswerAdd()
        {
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int QID = string.IsNullOrEmpty(Request["QID"])? 0 : int.Parse(Request["QID"]);
            int QType = string.IsNullOrEmpty(Request["QType"])? 0 : int.Parse(Request["QType"]);
            int OptionID = string.IsNullOrEmpty(Request["OptionID"])? 0 : int.Parse(Request["OptionID"]);
            int Score = string.IsNullOrEmpty(Request["Score"])? 0 : int.Parse(Request["Score"]);

            ////构建实体对象
            AssessmentAnswerEntity entity = new AssessmentAnswerEntity();
            entity.SubTID = SubTID;
            entity.UserID = UserID;
            entity.QID = QID;
            entity.QType = QType;
            entity.OptionID = OptionID;
            entity.Score = Score;
            int result = 0;
            try
            {
               result = AssessmentAnswerBL.AddAssessmentAnswer(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加AssessmentAnswer(RH_AssessmentAnswer)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_AssessmentAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentAnswerModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int QID = string.IsNullOrEmpty(Request["QID"])? 0 : int.Parse(Request["QID"]);
            int QType = string.IsNullOrEmpty(Request["QType"])? 0 : int.Parse(Request["QType"]);
            int OptionID = string.IsNullOrEmpty(Request["OptionID"])? 0 : int.Parse(Request["OptionID"]);
            int Score = string.IsNullOrEmpty(Request["Score"])? 0 : int.Parse(Request["Score"]);

            ////构建实体对象
            AssessmentAnswerEntity entity = new AssessmentAnswerEntity();
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
               result = AssessmentAnswerBL.ModifyAssessmentAnswer(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改AssessmentAnswer(RH_AssessmentAnswer)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentAnswerView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            AssessmentAnswerEntity entity = new AssessmentAnswerEntity();
            try
            {
               entity = AssessmentAnswerBL.GatAssessmentAnswerDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情AssessmentAnswer(RH_AssessmentAnswer)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int AssessmentAnswerRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = AssessmentAnswerBL.RemoveAssessmentAnswer(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentAnswer(RH_AssessmentAnswer)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentAnswerList()
        {
            //AssessmentAnswerRH_AssessmentAnswer
            AssessmentAnswerEntityListResult listResult = new AssessmentAnswerEntityListResult();

            AssessmentAnswerSearcher Searcher = new AssessmentAnswerSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<AssessmentAnswerInfo> mPage = null;
            try
            {
               listResult = AssessmentAnswerBL.GetAssessmentAnswerEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.AssessmentAnswerList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentAnswer(RH_AssessmentAnswer)出错" + DateTime.Now + "**************************");
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