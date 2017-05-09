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
    ///RH_CourseAttachment ( RH_CourseAttachment ) Controller类
    ///</summary>
    public class CourseAttachmentController : Controller
    {

        /// <summary>
        /// 添加RH_CourseAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseAttachmentAdd()
        {
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            string AttachmentName = string.IsNullOrEmpty(Request["AttachmentName"])? "" : Request["AttachmentName"].ToString();
            string AttachmentUrl = string.IsNullOrEmpty(Request["AttachmentUrl"])? "" : Request["AttachmentUrl"].ToString();
            int AttachmentType = string.IsNullOrEmpty(Request["AttachmentType"])? 0 : int.Parse(Request["AttachmentType"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            CourseAttachmentEntity entity = new CourseAttachmentEntity();
            entity.CourseID = CourseID;
            entity.AttachmentName = AttachmentName;
            entity.AttachmentUrl = AttachmentUrl;
            entity.AttachmentType = AttachmentType;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = CourseAttachmentBL.AddCourseAttachment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CourseAttachment(RH_CourseAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CourseAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CourseAttachmentModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            string AttachmentName = string.IsNullOrEmpty(Request["AttachmentName"])? "" : Request["AttachmentName"].ToString();
            string AttachmentUrl = string.IsNullOrEmpty(Request["AttachmentUrl"])? "" : Request["AttachmentUrl"].ToString();
            int AttachmentType = string.IsNullOrEmpty(Request["AttachmentType"])? 0 : int.Parse(Request["AttachmentType"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            CourseAttachmentEntity entity = new CourseAttachmentEntity();
            entity.CourseID = CourseID;
            entity.AttachmentName = AttachmentName;
            entity.AttachmentUrl = AttachmentUrl;
            entity.AttachmentType = AttachmentType;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CourseAttachmentBL.ModifyCourseAttachment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CourseAttachment(RH_CourseAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseAttachmentView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CourseAttachmentEntity entity = new CourseAttachmentEntity();
            try
            {
               entity = CourseAttachmentBL.GatCourseAttachmentDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CourseAttachment(RH_CourseAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CourseAttachmentRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CourseAttachmentBL.RemoveCourseAttachment(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseAttachment(RH_CourseAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CourseAttachmentList()
        {
            //CourseAttachmentRH_CourseAttachment
            CourseAttachmentEntityListResult listResult = new CourseAttachmentEntityListResult();

            CourseAttachmentSearcher Searcher = new CourseAttachmentSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CourseAttachmentInfo> mPage = null;
            try
            {
               listResult = CourseAttachmentBL.GetCourseAttachmentEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CourseAttachmentList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CourseAttachment(RH_CourseAttachment)出错" + DateTime.Now + "**************************");
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