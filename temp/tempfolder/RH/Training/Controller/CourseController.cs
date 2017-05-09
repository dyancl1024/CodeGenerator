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
    ///RH_Course ( RH_Course ) Controller类
    ///</summary>
    public class CourseController : Controller
    {

        /// <summary>
        /// 添加RH_Course
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseAdd()
        {
            string CourseName = string.IsNullOrEmpty(Request["CourseName"])? "" : Request["CourseName"].ToString();
            int CoursePharse = string.IsNullOrEmpty(Request["CoursePharse"])? 0 : int.Parse(Request["CoursePharse"]);
            string CourseCategoryCode = string.IsNullOrEmpty(Request["CourseCategoryCode"])? "" : Request["CourseCategoryCode"].ToString();
            string CourseDesc = string.IsNullOrEmpty(Request["CourseDesc"])? "" : Request["CourseDesc"].ToString();
            string CourseUrl = string.IsNullOrEmpty(Request["CourseUrl"])? "" : Request["CourseUrl"].ToString();
            string TeacherDesc = string.IsNullOrEmpty(Request["TeacherDesc"])? "" : Request["TeacherDesc"].ToString();
            string TeacherName = string.IsNullOrEmpty(Request["TeacherName"])? "" : Request["TeacherName"].ToString();
            string TeacherTitle = string.IsNullOrEmpty(Request["TeacherTitle"])? "" : Request["TeacherTitle"].ToString();
            string CourseLabel = string.IsNullOrEmpty(Request["CourseLabel"])? "" : Request["CourseLabel"].ToString();
            string CourseCode = string.IsNullOrEmpty(Request["CourseCode"])? "" : Request["CourseCode"].ToString();
            int IsPractice = string.IsNullOrEmpty(Request["IsPractice"])? 0 : int.Parse(Request["IsPractice"]);
            string CourseCompany = string.IsNullOrEmpty(Request["CourseCompany"])? "" : Request["CourseCompany"].ToString();
            string CourseStyle = string.IsNullOrEmpty(Request["CourseStyle"])? "" : Request["CourseStyle"].ToString();
            int IsSpecialTeacher = string.IsNullOrEmpty(Request["IsSpecialTeacher"])? 0 : int.Parse(Request["IsSpecialTeacher"]);
            int VideoDuration = string.IsNullOrEmpty(Request["VideoDuration"])? 0 : int.Parse(Request["VideoDuration"]);
            int IsApp = string.IsNullOrEmpty(Request["IsApp"])? 0 : int.Parse(Request["IsApp"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            CourseEntity entity = new CourseEntity();
            entity.CourseName = CourseName;
            entity.CoursePharse = CoursePharse;
            entity.CourseCategoryCode = CourseCategoryCode;
            entity.CourseDesc = CourseDesc;
            entity.CourseUrl = CourseUrl;
            entity.TeacherDesc = TeacherDesc;
            entity.TeacherName = TeacherName;
            entity.TeacherTitle = TeacherTitle;
            entity.CourseLabel = CourseLabel;
            entity.CourseCode = CourseCode;
            entity.IsPractice = IsPractice;
            entity.CourseCompany = CourseCompany;
            entity.CourseStyle = CourseStyle;
            entity.IsSpecialTeacher = IsSpecialTeacher;
            entity.VideoDuration = VideoDuration;
            entity.IsApp = IsApp;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = CourseBL.AddCourse(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Course(RH_Course)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Course
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string CourseName = string.IsNullOrEmpty(Request["CourseName"])? "" : Request["CourseName"].ToString();
            int CoursePharse = string.IsNullOrEmpty(Request["CoursePharse"])? 0 : int.Parse(Request["CoursePharse"]);
            string CourseCategoryCode = string.IsNullOrEmpty(Request["CourseCategoryCode"])? "" : Request["CourseCategoryCode"].ToString();
            string CourseDesc = string.IsNullOrEmpty(Request["CourseDesc"])? "" : Request["CourseDesc"].ToString();
            string CourseUrl = string.IsNullOrEmpty(Request["CourseUrl"])? "" : Request["CourseUrl"].ToString();
            string TeacherDesc = string.IsNullOrEmpty(Request["TeacherDesc"])? "" : Request["TeacherDesc"].ToString();
            string TeacherName = string.IsNullOrEmpty(Request["TeacherName"])? "" : Request["TeacherName"].ToString();
            string TeacherTitle = string.IsNullOrEmpty(Request["TeacherTitle"])? "" : Request["TeacherTitle"].ToString();
            string CourseLabel = string.IsNullOrEmpty(Request["CourseLabel"])? "" : Request["CourseLabel"].ToString();
            string CourseCode = string.IsNullOrEmpty(Request["CourseCode"])? "" : Request["CourseCode"].ToString();
            int IsPractice = string.IsNullOrEmpty(Request["IsPractice"])? 0 : int.Parse(Request["IsPractice"]);
            string CourseCompany = string.IsNullOrEmpty(Request["CourseCompany"])? "" : Request["CourseCompany"].ToString();
            string CourseStyle = string.IsNullOrEmpty(Request["CourseStyle"])? "" : Request["CourseStyle"].ToString();
            int IsSpecialTeacher = string.IsNullOrEmpty(Request["IsSpecialTeacher"])? 0 : int.Parse(Request["IsSpecialTeacher"]);
            int VideoDuration = string.IsNullOrEmpty(Request["VideoDuration"])? 0 : int.Parse(Request["VideoDuration"]);
            int IsApp = string.IsNullOrEmpty(Request["IsApp"])? 0 : int.Parse(Request["IsApp"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            CourseEntity entity = new CourseEntity();
            entity.CourseName = CourseName;
            entity.CoursePharse = CoursePharse;
            entity.CourseCategoryCode = CourseCategoryCode;
            entity.CourseDesc = CourseDesc;
            entity.CourseUrl = CourseUrl;
            entity.TeacherDesc = TeacherDesc;
            entity.TeacherName = TeacherName;
            entity.TeacherTitle = TeacherTitle;
            entity.CourseLabel = CourseLabel;
            entity.CourseCode = CourseCode;
            entity.IsPractice = IsPractice;
            entity.CourseCompany = CourseCompany;
            entity.CourseStyle = CourseStyle;
            entity.IsSpecialTeacher = IsSpecialTeacher;
            entity.VideoDuration = VideoDuration;
            entity.IsApp = IsApp;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseBL.ModifyCourse(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Course(RH_Course)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseEntity entity = new CourseEntity();
            try
            {
               entity = CourseBL.GatCourseDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Course(RH_Course)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseBL.RemoveCourse(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Course(RH_Course)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseList()
        {
            //CourseRH_Course
            CourseEntityListResult listResult = new CourseEntityListResult();

            CourseSearcher Searcher = new CourseSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseInfo> mPage = null;
            try
            {
               listResult = CourseBL.GetCourseEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Course(RH_Course)出错" + DateTime.Now + "**************************");
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