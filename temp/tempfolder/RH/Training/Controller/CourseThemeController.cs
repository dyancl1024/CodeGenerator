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
    ///RH_CourseTheme ( RH_CourseTheme ) Controller类
    ///</summary>
    public class CourseThemeController : Controller
    {

        /// <summary>
        /// 添加RH_CourseTheme
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseThemeAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int Type = string.IsNullOrEmpty(Request["Type"])? 0 : int.Parse(Request["Type"]);

            ////构建实体对象
            CourseThemeEntity entity = new CourseThemeEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.Type = Type;
            int result = 0;
            try
            {
               result = CourseThemeBL.AddCourseTheme(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseTheme(RH_CourseTheme)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseTheme
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseThemeModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int Type = string.IsNullOrEmpty(Request["Type"])? 0 : int.Parse(Request["Type"]);

            ////构建实体对象
            CourseThemeEntity entity = new CourseThemeEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.Type = Type;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseThemeBL.ModifyCourseTheme(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseTheme(RH_CourseTheme)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseThemeView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseThemeEntity entity = new CourseThemeEntity();
            try
            {
               entity = CourseThemeBL.GatCourseThemeDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseTheme(RH_CourseTheme)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseThemeRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseThemeBL.RemoveCourseTheme(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseTheme(RH_CourseTheme)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseThemeList()
        {
            //CourseThemeRH_CourseTheme
            CourseThemeEntityListResult listResult = new CourseThemeEntityListResult();

            CourseThemeSearcher Searcher = new CourseThemeSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseThemeInfo> mPage = null;
            try
            {
               listResult = CourseThemeBL.GetCourseThemeEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseThemeList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseTheme(RH_CourseTheme)出错" + DateTime.Now + "**************************");
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