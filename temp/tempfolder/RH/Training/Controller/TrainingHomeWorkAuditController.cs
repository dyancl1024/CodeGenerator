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
    ///RH_TrainingHomeWorkAudit ( RH_TrainingHomeWorkAudit ) Controller类
    ///</summary>
    public class TrainingHomeWorkAuditController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingHomeWorkAuditAdd()
        {
            int HomeWorkID = string.IsNullOrEmpty(Request["HomeWorkID"])? 0 : int.Parse(Request["HomeWorkID"]);
            int Auditor = string.IsNullOrEmpty(Request["Auditor"])? 0 : int.Parse(Request["Auditor"]);
            DateTime AuditTime = string.IsNullOrEmpty(Request["AuditTime"])? DateTime.Now : DateTime.Parse(Request["AuditTime"]);
            string AuditDesc = string.IsNullOrEmpty(Request["AuditDesc"])? "" : Request["AuditDesc"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            TrainingHomeWorkAuditEntity entity = new TrainingHomeWorkAuditEntity();
            entity.HomeWorkID = HomeWorkID;
            entity.Auditor = Auditor;
            entity.AuditTime = AuditTime;
            entity.AuditDesc = AuditDesc;
            entity.Status = Status;
            int result = 0;
            try
            {
               result = TrainingHomeWorkAuditBL.AddTrainingHomeWorkAudit(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingHomeWorkAudit(RH_TrainingHomeWorkAudit)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingHomeWorkAuditModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int HomeWorkID = string.IsNullOrEmpty(Request["HomeWorkID"])? 0 : int.Parse(Request["HomeWorkID"]);
            int Auditor = string.IsNullOrEmpty(Request["Auditor"])? 0 : int.Parse(Request["Auditor"]);
            DateTime AuditTime = string.IsNullOrEmpty(Request["AuditTime"])? DateTime.Now : DateTime.Parse(Request["AuditTime"]);
            string AuditDesc = string.IsNullOrEmpty(Request["AuditDesc"])? "" : Request["AuditDesc"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            TrainingHomeWorkAuditEntity entity = new TrainingHomeWorkAuditEntity();
            entity.HomeWorkID = HomeWorkID;
            entity.Auditor = Auditor;
            entity.AuditTime = AuditTime;
            entity.AuditDesc = AuditDesc;
            entity.Status = Status;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingHomeWorkAuditBL.ModifyTrainingHomeWorkAudit(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingHomeWorkAudit(RH_TrainingHomeWorkAudit)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingHomeWorkAuditView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingHomeWorkAuditEntity entity = new TrainingHomeWorkAuditEntity();
            try
            {
               entity = TrainingHomeWorkAuditBL.GatTrainingHomeWorkAuditDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingHomeWorkAudit(RH_TrainingHomeWorkAudit)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingHomeWorkAuditRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingHomeWorkAuditBL.RemoveTrainingHomeWorkAudit(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingHomeWorkAudit(RH_TrainingHomeWorkAudit)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingHomeWorkAuditList()
        {
            //TrainingHomeWorkAuditRH_TrainingHomeWorkAudit
            TrainingHomeWorkAuditEntityListResult listResult = new TrainingHomeWorkAuditEntityListResult();

            TrainingHomeWorkAuditSearcher Searcher = new TrainingHomeWorkAuditSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingHomeWorkAuditInfo> mPage = null;
            try
            {
               listResult = TrainingHomeWorkAuditBL.GetTrainingHomeWorkAuditEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingHomeWorkAuditList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingHomeWorkAudit(RH_TrainingHomeWorkAudit)出错" + DateTime.Now + "**************************");
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