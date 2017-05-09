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
    ///RH_CourseOption ( RH_CourseOption ) Controller类
    ///</summary>
    public class CourseOptionController : Controller
    {

        /// <summary>
        /// 添加RH_CourseOption
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseOptionAdd()
        {
            int QuestionID = string.IsNullOrEmpty(Request["QuestionID"])? 0 : int.Parse(Request["QuestionID"]);
            string QOption = string.IsNullOrEmpty(Request["QOption"])? "" : Request["QOption"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int IsRight = string.IsNullOrEmpty(Request["IsRight"])? 0 : int.Parse(Request["IsRight"]);

            ////构建实体对象
            CourseOptionEntity entity = new CourseOptionEntity();
            entity.QuestionID = QuestionID;
            entity.QOption = QOption;
            entity.Sort = Sort;
            entity.IsRight = IsRight;
            int result = 0;
            try
            {
               result = CourseOptionBL.AddCourseOption(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseOption(RH_CourseOption)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseOption
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseOptionModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int QuestionID = string.IsNullOrEmpty(Request["QuestionID"])? 0 : int.Parse(Request["QuestionID"]);
            string QOption = string.IsNullOrEmpty(Request["QOption"])? "" : Request["QOption"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int IsRight = string.IsNullOrEmpty(Request["IsRight"])? 0 : int.Parse(Request["IsRight"]);

            ////构建实体对象
            CourseOptionEntity entity = new CourseOptionEntity();
            entity.QuestionID = QuestionID;
            entity.QOption = QOption;
            entity.Sort = Sort;
            entity.IsRight = IsRight;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseOptionBL.ModifyCourseOption(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseOption(RH_CourseOption)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseOptionView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseOptionEntity entity = new CourseOptionEntity();
            try
            {
               entity = CourseOptionBL.GatCourseOptionDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseOption(RH_CourseOption)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseOptionRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseOptionBL.RemoveCourseOption(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseOption(RH_CourseOption)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseOptionList()
        {
            //CourseOptionRH_CourseOption
            CourseOptionEntityListResult listResult = new CourseOptionEntityListResult();

            CourseOptionSearcher Searcher = new CourseOptionSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseOptionInfo> mPage = null;
            try
            {
               listResult = CourseOptionBL.GetCourseOptionEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseOptionList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseOption(RH_CourseOption)出错" + DateTime.Now + "**************************");
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