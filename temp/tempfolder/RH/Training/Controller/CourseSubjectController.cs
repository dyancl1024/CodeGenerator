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
    ///RH_CourseSubject ( RH_CourseSubject ) Controller类
    ///</summary>
    public class CourseSubjectController : Controller
    {

        /// <summary>
        /// 添加RH_CourseSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseSubjectAdd()
        {
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            CourseSubjectEntity entity = new CourseSubjectEntity();
            entity.CourseID = CourseID;
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = CourseSubjectBL.AddCourseSubject(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseSubject(RH_CourseSubject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseSubjectModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            CourseSubjectEntity entity = new CourseSubjectEntity();
            entity.CourseID = CourseID;
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseSubjectBL.ModifyCourseSubject(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseSubject(RH_CourseSubject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseSubjectView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseSubjectEntity entity = new CourseSubjectEntity();
            try
            {
               entity = CourseSubjectBL.GatCourseSubjectDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseSubject(RH_CourseSubject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseSubjectRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseSubjectBL.RemoveCourseSubject(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseSubject(RH_CourseSubject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseSubjectList()
        {
            //CourseSubjectRH_CourseSubject
            CourseSubjectEntityListResult listResult = new CourseSubjectEntityListResult();

            CourseSubjectSearcher Searcher = new CourseSubjectSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseSubjectInfo> mPage = null;
            try
            {
               listResult = CourseSubjectBL.GetCourseSubjectEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseSubjectList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseSubject(RH_CourseSubject)出错" + DateTime.Now + "**************************");
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