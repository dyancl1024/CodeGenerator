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
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) Controller类
    ///</summary>
    public class CourseThemeRelationController : Controller
    {

        /// <summary>
        /// 添加RH_CourseThemeRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseThemeRelationAdd()
        {
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            string CourseThemeCode = string.IsNullOrEmpty(Request["CourseThemeCode"])? "" : Request["CourseThemeCode"].ToString();

            ////构建实体对象
            CourseThemeRelationEntity entity = new CourseThemeRelationEntity();
            entity.CourseID = CourseID;
            entity.CourseThemeCode = CourseThemeCode;
            int result = 0;
            try
            {
               result = CourseThemeRelationBL.AddCourseThemeRelation(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseThemeRelation(RH_CourseThemeRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseThemeRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseThemeRelationModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            string CourseThemeCode = string.IsNullOrEmpty(Request["CourseThemeCode"])? "" : Request["CourseThemeCode"].ToString();

            ////构建实体对象
            CourseThemeRelationEntity entity = new CourseThemeRelationEntity();
            entity.CourseID = CourseID;
            entity.CourseThemeCode = CourseThemeCode;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseThemeRelationBL.ModifyCourseThemeRelation(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseThemeRelation(RH_CourseThemeRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseThemeRelationView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseThemeRelationEntity entity = new CourseThemeRelationEntity();
            try
            {
               entity = CourseThemeRelationBL.GatCourseThemeRelationDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseThemeRelation(RH_CourseThemeRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseThemeRelationRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseThemeRelationBL.RemoveCourseThemeRelation(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseThemeRelation(RH_CourseThemeRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseThemeRelationList()
        {
            //CourseThemeRelationRH_CourseThemeRelation
            CourseThemeRelationEntityListResult listResult = new CourseThemeRelationEntityListResult();

            CourseThemeRelationSearcher Searcher = new CourseThemeRelationSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseThemeRelationInfo> mPage = null;
            try
            {
               listResult = CourseThemeRelationBL.GetCourseThemeRelationEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseThemeRelationList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseThemeRelation(RH_CourseThemeRelation)出错" + DateTime.Now + "**************************");
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