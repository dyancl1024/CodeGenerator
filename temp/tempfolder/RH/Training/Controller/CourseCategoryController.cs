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
    ///RH_CourseCategory ( RH_CourseCategory ) Controller类
    ///</summary>
    public class CourseCategoryController : Controller
    {

        /// <summary>
        /// 添加RH_CourseCategory
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseCategoryAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Type = string.IsNullOrEmpty(Request["Type"])? 0 : int.Parse(Request["Type"]);
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            CourseCategoryEntity entity = new CourseCategoryEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Type = Type;
            entity.Sort = Sort;
            int result = 0;
            try
            {
               result = CourseCategoryBL.AddCourseCategory(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseCategory(RH_CourseCategory)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseCategory
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseCategoryModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Type = string.IsNullOrEmpty(Request["Type"])? 0 : int.Parse(Request["Type"]);
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            CourseCategoryEntity entity = new CourseCategoryEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Type = Type;
            entity.Sort = Sort;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseCategoryBL.ModifyCourseCategory(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseCategory(RH_CourseCategory)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseCategoryView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseCategoryEntity entity = new CourseCategoryEntity();
            try
            {
               entity = CourseCategoryBL.GatCourseCategoryDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseCategory(RH_CourseCategory)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseCategoryRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseCategoryBL.RemoveCourseCategory(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseCategory(RH_CourseCategory)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseCategoryList()
        {
            //CourseCategoryRH_CourseCategory
            CourseCategoryEntityListResult listResult = new CourseCategoryEntityListResult();

            CourseCategorySearcher Searcher = new CourseCategorySearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseCategoryInfo> mPage = null;
            try
            {
               listResult = CourseCategoryBL.GetCourseCategoryEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseCategoryList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseCategory(RH_CourseCategory)出错" + DateTime.Now + "**************************");
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