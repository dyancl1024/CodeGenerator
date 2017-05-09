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
    ///RH_CourseAnswer ( RH_CourseAnswer ) Controller类
    ///</summary>
    public class CourseAnswerController : Controller
    {

        /// <summary>
        /// 添加RH_CourseAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseAnswerAdd()
        {
            int QuestionID = string.IsNullOrEmpty(Request["QuestionID"])? 0 : int.Parse(Request["QuestionID"]);
            int OptionID = string.IsNullOrEmpty(Request["OptionID"])? 0 : int.Parse(Request["OptionID"]);
            int IsRight = string.IsNullOrEmpty(Request["IsRight"])? 0 : int.Parse(Request["IsRight"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            CourseAnswerEntity entity = new CourseAnswerEntity();
            entity.QuestionID = QuestionID;
            entity.OptionID = OptionID;
            entity.IsRight = IsRight;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = CourseAnswerBL.AddCourseAnswer(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseAnswer(RH_CourseAnswer)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseAnswerModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int QuestionID = string.IsNullOrEmpty(Request["QuestionID"])? 0 : int.Parse(Request["QuestionID"]);
            int OptionID = string.IsNullOrEmpty(Request["OptionID"])? 0 : int.Parse(Request["OptionID"]);
            int IsRight = string.IsNullOrEmpty(Request["IsRight"])? 0 : int.Parse(Request["IsRight"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            CourseAnswerEntity entity = new CourseAnswerEntity();
            entity.QuestionID = QuestionID;
            entity.OptionID = OptionID;
            entity.IsRight = IsRight;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseAnswerBL.ModifyCourseAnswer(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseAnswer(RH_CourseAnswer)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseAnswerView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseAnswerEntity entity = new CourseAnswerEntity();
            try
            {
               entity = CourseAnswerBL.GatCourseAnswerDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseAnswer(RH_CourseAnswer)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseAnswerRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseAnswerBL.RemoveCourseAnswer(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseAnswer(RH_CourseAnswer)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseAnswerList()
        {
            //CourseAnswerRH_CourseAnswer
            CourseAnswerEntityListResult listResult = new CourseAnswerEntityListResult();

            CourseAnswerSearcher Searcher = new CourseAnswerSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseAnswerInfo> mPage = null;
            try
            {
               listResult = CourseAnswerBL.GetCourseAnswerEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseAnswerList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseAnswer(RH_CourseAnswer)出错" + DateTime.Now + "**************************");
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