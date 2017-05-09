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
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) Controller类
    ///</summary>
    public class CourseLevelRelationController : Controller
    {

        /// <summary>
        /// 添加RH_CourseLevelRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseLevelRelationAdd()
        {
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            int CourseLevel = string.IsNullOrEmpty(Request["CourseLevel"])? 0 : int.Parse(Request["CourseLevel"]);

            ////构建实体对象
            CourseLevelRelationEntity entity = new CourseLevelRelationEntity();
            entity.CourseID = CourseID;
            entity.CourseLevel = CourseLevel;
            int result = 0;
            try
            {
               result = CourseLevelRelationBL.AddCourseLevelRelation(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseLevelRelation(RH_CourseLevelRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseLevelRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseLevelRelationModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            int CourseLevel = string.IsNullOrEmpty(Request["CourseLevel"])? 0 : int.Parse(Request["CourseLevel"]);

            ////构建实体对象
            CourseLevelRelationEntity entity = new CourseLevelRelationEntity();
            entity.CourseID = CourseID;
            entity.CourseLevel = CourseLevel;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseLevelRelationBL.ModifyCourseLevelRelation(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseLevelRelation(RH_CourseLevelRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseLevelRelationView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseLevelRelationEntity entity = new CourseLevelRelationEntity();
            try
            {
               entity = CourseLevelRelationBL.GatCourseLevelRelationDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseLevelRelation(RH_CourseLevelRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseLevelRelationRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseLevelRelationBL.RemoveCourseLevelRelation(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseLevelRelation(RH_CourseLevelRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseLevelRelationList()
        {
            //CourseLevelRelationRH_CourseLevelRelation
            CourseLevelRelationEntityListResult listResult = new CourseLevelRelationEntityListResult();

            CourseLevelRelationSearcher Searcher = new CourseLevelRelationSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseLevelRelationInfo> mPage = null;
            try
            {
               listResult = CourseLevelRelationBL.GetCourseLevelRelationEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseLevelRelationList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseLevelRelation(RH_CourseLevelRelation)出错" + DateTime.Now + "**************************");
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