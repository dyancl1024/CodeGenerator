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
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) Controller类
    ///</summary>
    public class CoursePreSetListController : Controller
    {

        /// <summary>
        /// 添加RH_CoursePreSetList
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CoursePreSetListAdd()
        {
            int PreSetID = string.IsNullOrEmpty(Request["PreSetID"])? 0 : int.Parse(Request["PreSetID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);

            ////构建实体对象
            CoursePreSetListEntity entity = new CoursePreSetListEntity();
            entity.PreSetID = PreSetID;
            entity.CourseID = CourseID;
            int result = 0;
            try
            {
               result = CoursePreSetListBL.AddCoursePreSetList(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CoursePreSetList(RH_CoursePreSetList)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CoursePreSetList
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CoursePreSetListModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int PreSetID = string.IsNullOrEmpty(Request["PreSetID"])? 0 : int.Parse(Request["PreSetID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);

            ////构建实体对象
            CoursePreSetListEntity entity = new CoursePreSetListEntity();
            entity.PreSetID = PreSetID;
            entity.CourseID = CourseID;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CoursePreSetListBL.ModifyCoursePreSetList(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CoursePreSetList(RH_CoursePreSetList)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CoursePreSetListView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CoursePreSetListEntity entity = new CoursePreSetListEntity();
            try
            {
               entity = CoursePreSetListBL.GatCoursePreSetListDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CoursePreSetList(RH_CoursePreSetList)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CoursePreSetListRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CoursePreSetListBL.RemoveCoursePreSetList(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CoursePreSetList(RH_CoursePreSetList)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CoursePreSetListList()
        {
            //CoursePreSetListRH_CoursePreSetList
            CoursePreSetListEntityListResult listResult = new CoursePreSetListEntityListResult();

            CoursePreSetListSearcher Searcher = new CoursePreSetListSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CoursePreSetListInfo> mPage = null;
            try
            {
               listResult = CoursePreSetListBL.GetCoursePreSetListEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CoursePreSetListList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CoursePreSetList(RH_CoursePreSetList)出错" + DateTime.Now + "**************************");
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