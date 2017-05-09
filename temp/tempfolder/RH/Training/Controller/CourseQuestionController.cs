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
    ///RH_CourseQuestion ( RH_CourseQuestion ) Controller类
    ///</summary>
    public class CourseQuestionController : Controller
    {

        /// <summary>
        /// 添加RH_CourseQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseQuestionAdd()
        {
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            string Question = string.IsNullOrEmpty(Request["Question"])? "" : Request["Question"].ToString();
            int QType = string.IsNullOrEmpty(Request["QType"])? 0 : int.Parse(Request["QType"]);
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            CourseQuestionEntity entity = new CourseQuestionEntity();
            entity.CourseID = CourseID;
            entity.Question = Question;
            entity.QType = QType;
            entity.Sort = Sort;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = CourseQuestionBL.AddCourseQuestion(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseQuestion(RH_CourseQuestion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseQuestionModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            string Question = string.IsNullOrEmpty(Request["Question"])? "" : Request["Question"].ToString();
            int QType = string.IsNullOrEmpty(Request["QType"])? 0 : int.Parse(Request["QType"]);
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            CourseQuestionEntity entity = new CourseQuestionEntity();
            entity.CourseID = CourseID;
            entity.Question = Question;
            entity.QType = QType;
            entity.Sort = Sort;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseQuestionBL.ModifyCourseQuestion(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseQuestion(RH_CourseQuestion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseQuestionView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseQuestionEntity entity = new CourseQuestionEntity();
            try
            {
               entity = CourseQuestionBL.GatCourseQuestionDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseQuestion(RH_CourseQuestion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseQuestionRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseQuestionBL.RemoveCourseQuestion(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseQuestion(RH_CourseQuestion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseQuestionList()
        {
            //CourseQuestionRH_CourseQuestion
            CourseQuestionEntityListResult listResult = new CourseQuestionEntityListResult();

            CourseQuestionSearcher Searcher = new CourseQuestionSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseQuestionInfo> mPage = null;
            try
            {
               listResult = CourseQuestionBL.GetCourseQuestionEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseQuestionList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseQuestion(RH_CourseQuestion)出错" + DateTime.Now + "**************************");
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