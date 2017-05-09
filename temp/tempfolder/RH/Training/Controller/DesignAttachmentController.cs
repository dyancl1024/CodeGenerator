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
    ///RH_DesignAttachment ( RH_DesignAttachment ) Controller类
    ///</summary>
    public class DesignAttachmentController : Controller
    {

        /// <summary>
        /// 添加RH_DesignAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignAttachmentAdd()
        {
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            string AttachmentName = string.IsNullOrEmpty(Request["AttachmentName"])? "" : Request["AttachmentName"].ToString();
            string AttachmentUrl = string.IsNullOrEmpty(Request["AttachmentUrl"])? "" : Request["AttachmentUrl"].ToString();
            int AttachmentType = string.IsNullOrEmpty(Request["AttachmentType"])? 0 : int.Parse(Request["AttachmentType"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignAttachmentEntity entity = new DesignAttachmentEntity();
            entity.DesignID = DesignID;
            entity.AttachmentName = AttachmentName;
            entity.AttachmentUrl = AttachmentUrl;
            entity.AttachmentType = AttachmentType;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = DesignAttachmentBL.AddDesignAttachment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加DesignAttachment(RH_DesignAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_DesignAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignAttachmentModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            string AttachmentName = string.IsNullOrEmpty(Request["AttachmentName"])? "" : Request["AttachmentName"].ToString();
            string AttachmentUrl = string.IsNullOrEmpty(Request["AttachmentUrl"])? "" : Request["AttachmentUrl"].ToString();
            int AttachmentType = string.IsNullOrEmpty(Request["AttachmentType"])? 0 : int.Parse(Request["AttachmentType"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignAttachmentEntity entity = new DesignAttachmentEntity();
            entity.DesignID = DesignID;
            entity.AttachmentName = AttachmentName;
            entity.AttachmentUrl = AttachmentUrl;
            entity.AttachmentType = AttachmentType;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = DesignAttachmentBL.ModifyDesignAttachment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改DesignAttachment(RH_DesignAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignAttachmentView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            DesignAttachmentEntity entity = new DesignAttachmentEntity();
            try
            {
               entity = DesignAttachmentBL.GatDesignAttachmentDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情DesignAttachment(RH_DesignAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DesignAttachmentRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = DesignAttachmentBL.RemoveDesignAttachment(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignAttachment(RH_DesignAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignAttachmentList()
        {
            //DesignAttachmentRH_DesignAttachment
            DesignAttachmentEntityListResult listResult = new DesignAttachmentEntityListResult();

            DesignAttachmentSearcher Searcher = new DesignAttachmentSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<DesignAttachmentInfo> mPage = null;
            try
            {
               listResult = DesignAttachmentBL.GetDesignAttachmentEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.DesignAttachmentList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignAttachment(RH_DesignAttachment)出错" + DateTime.Now + "**************************");
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