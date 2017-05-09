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
    ///RH_TrainingStudyStatus ( RH_TrainingStudyStatus ) Controller类
    ///</summary>
    public class TrainingStudyStatusController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingStudyStatus
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingStudyStatusAdd()
        {
            int PCID = string.IsNullOrEmpty(Request["PCID"])? 0 : int.Parse(Request["PCID"]);
            int CID = string.IsNullOrEmpty(Request["CID"])? 0 : int.Parse(Request["CID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);

            ////构建实体对象
            TrainingStudyStatusEntity entity = new TrainingStudyStatusEntity();
            entity.PCID = PCID;
            entity.CID = CID;
            entity.SubTID = SubTID;
            entity.Status = Status;
            entity.UserID = UserID;
            int result = 0;
            try
            {
               result = TrainingStudyStatusBL.AddTrainingStudyStatus(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingStudyStatus(RH_TrainingStudyStatus)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingStudyStatus
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingStudyStatusModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int PCID = string.IsNullOrEmpty(Request["PCID"])? 0 : int.Parse(Request["PCID"]);
            int CID = string.IsNullOrEmpty(Request["CID"])? 0 : int.Parse(Request["CID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);

            ////构建实体对象
            TrainingStudyStatusEntity entity = new TrainingStudyStatusEntity();
            entity.PCID = PCID;
            entity.CID = CID;
            entity.SubTID = SubTID;
            entity.Status = Status;
            entity.UserID = UserID;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingStudyStatusBL.ModifyTrainingStudyStatus(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingStudyStatus(RH_TrainingStudyStatus)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingStudyStatusView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingStudyStatusEntity entity = new TrainingStudyStatusEntity();
            try
            {
               entity = TrainingStudyStatusBL.GatTrainingStudyStatusDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingStudyStatus(RH_TrainingStudyStatus)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingStudyStatusRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingStudyStatusBL.RemoveTrainingStudyStatus(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingStudyStatus(RH_TrainingStudyStatus)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingStudyStatusList()
        {
            //TrainingStudyStatusRH_TrainingStudyStatus
            TrainingStudyStatusEntityListResult listResult = new TrainingStudyStatusEntityListResult();

            TrainingStudyStatusSearcher Searcher = new TrainingStudyStatusSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingStudyStatusInfo> mPage = null;
            try
            {
               listResult = TrainingStudyStatusBL.GetTrainingStudyStatusEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingStudyStatusList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingStudyStatus(RH_TrainingStudyStatus)出错" + DateTime.Now + "**************************");
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