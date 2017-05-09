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
    ///RH_DesignContentAttachment ( RH_DesignContentAttachment ) Controller类
    ///</summary>
    public class DesignContentAttachmentController : Controller
    {

        /// <summary>
        /// 添加RH_DesignContentAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignContentAttachmentAdd()
        {
            int DesignContentID = string.IsNullOrEmpty(Request["DesignContentID"])? 0 : int.Parse(Request["DesignContentID"]);
            string AttachementName = string.IsNullOrEmpty(Request["AttachementName"])? "" : Request["AttachementName"].ToString();
            string AttachmentUrl = string.IsNullOrEmpty(Request["AttachmentUrl"])? "" : Request["AttachmentUrl"].ToString();
            string Version = string.IsNullOrEmpty(Request["Version"])? "" : Request["Version"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignContentAttachmentEntity entity = new DesignContentAttachmentEntity();
            entity.DesignContentID = DesignContentID;
            entity.AttachementName = AttachementName;
            entity.AttachmentUrl = AttachmentUrl;
            entity.Version = Version;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = DesignContentAttachmentBL.AddDesignContentAttachment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加DesignContentAttachment(RH_DesignContentAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_DesignContentAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignContentAttachmentModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int DesignContentID = string.IsNullOrEmpty(Request["DesignContentID"])? 0 : int.Parse(Request["DesignContentID"]);
            string AttachementName = string.IsNullOrEmpty(Request["AttachementName"])? "" : Request["AttachementName"].ToString();
            string AttachmentUrl = string.IsNullOrEmpty(Request["AttachmentUrl"])? "" : Request["AttachmentUrl"].ToString();
            string Version = string.IsNullOrEmpty(Request["Version"])? "" : Request["Version"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignContentAttachmentEntity entity = new DesignContentAttachmentEntity();
            entity.DesignContentID = DesignContentID;
            entity.AttachementName = AttachementName;
            entity.AttachmentUrl = AttachmentUrl;
            entity.Version = Version;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = DesignContentAttachmentBL.ModifyDesignContentAttachment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改DesignContentAttachment(RH_DesignContentAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignContentAttachmentView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            DesignContentAttachmentEntity entity = new DesignContentAttachmentEntity();
            try
            {
               entity = DesignContentAttachmentBL.GatDesignContentAttachmentDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情DesignContentAttachment(RH_DesignContentAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DesignContentAttachmentRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = DesignContentAttachmentBL.RemoveDesignContentAttachment(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignContentAttachment(RH_DesignContentAttachment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignContentAttachmentList()
        {
            //DesignContentAttachmentRH_DesignContentAttachment
            DesignContentAttachmentEntityListResult listResult = new DesignContentAttachmentEntityListResult();

            DesignContentAttachmentSearcher Searcher = new DesignContentAttachmentSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<DesignContentAttachmentInfo> mPage = null;
            try
            {
               listResult = DesignContentAttachmentBL.GetDesignContentAttachmentEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.DesignContentAttachmentList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignContentAttachment(RH_DesignContentAttachment)出错" + DateTime.Now + "**************************");
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