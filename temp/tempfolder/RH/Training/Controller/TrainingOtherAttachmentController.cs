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
    ///RH_TrainingOtherAttachment ( RH_TrainingOtherAttachment ) Controller类
    ///</summary>
    public class TrainingOtherAttachmentController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingOtherAttachmentAdd()
        {
            int TOID = string.IsNullOrEmpty(Request["TOID"])? 0 : int.Parse(Request["TOID"]);
            string AttachmentName = string.IsNullOrEmpty(Request["AttachmentName"])? "" : Request["AttachmentName"].ToString();
            string AttachmentURL = string.IsNullOrEmpty(Request["AttachmentURL"])? "" : Request["AttachmentURL"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingOtherAttachmentEntity entity = new TrainingOtherAttachmentEntity();
            entity.TOID = TOID;
            entity.AttachmentName = AttachmentName;
            entity.AttachmentURL = AttachmentURL;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingOtherAttachmentBL.AddTrainingOtherAttachment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingOtherAttachment(RH_TrainingOtherAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingOtherAttachmentModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int TOID = string.IsNullOrEmpty(Request["TOID"])? 0 : int.Parse(Request["TOID"]);
            string AttachmentName = string.IsNullOrEmpty(Request["AttachmentName"])? "" : Request["AttachmentName"].ToString();
            string AttachmentURL = string.IsNullOrEmpty(Request["AttachmentURL"])? "" : Request["AttachmentURL"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingOtherAttachmentEntity entity = new TrainingOtherAttachmentEntity();
            entity.TOID = TOID;
            entity.AttachmentName = AttachmentName;
            entity.AttachmentURL = AttachmentURL;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingOtherAttachmentBL.ModifyTrainingOtherAttachment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingOtherAttachment(RH_TrainingOtherAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingOtherAttachmentView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingOtherAttachmentEntity entity = new TrainingOtherAttachmentEntity();
            try
            {
               entity = TrainingOtherAttachmentBL.GatTrainingOtherAttachmentDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingOtherAttachment(RH_TrainingOtherAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingOtherAttachmentRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingOtherAttachmentBL.RemoveTrainingOtherAttachment(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingOtherAttachment(RH_TrainingOtherAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingOtherAttachmentList()
        {
            //TrainingOtherAttachmentRH_TrainingOtherAttachment
            TrainingOtherAttachmentEntityListResult listResult = new TrainingOtherAttachmentEntityListResult();

            TrainingOtherAttachmentSearcher Searcher = new TrainingOtherAttachmentSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingOtherAttachmentInfo> mPage = null;
            try
            {
               listResult = TrainingOtherAttachmentBL.GetTrainingOtherAttachmentEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingOtherAttachmentList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingOtherAttachment(RH_TrainingOtherAttachment)出错" + DateTime.Now + "**************************");
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