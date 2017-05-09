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
    ///RH_TrainingMyCourseRecord ( RH_TrainingMyCourseRecord ) Controller类
    ///</summary>
    public class TrainingMyCourseRecordController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingMyCourseRecordAdd()
        {
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int PCID = string.IsNullOrEmpty(Request["PCID"])? 0 : int.Parse(Request["PCID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            int WatchTime = string.IsNullOrEmpty(Request["WatchTime"])? 0 : int.Parse(Request["WatchTime"]);
            int TotalWatchTime = string.IsNullOrEmpty(Request["TotalWatchTime"])? 0 : int.Parse(Request["TotalWatchTime"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            TrainingMyCourseRecordEntity entity = new TrainingMyCourseRecordEntity();
            entity.UserID = UserID;
            entity.SubTID = SubTID;
            entity.PCID = PCID;
            entity.CourseID = CourseID;
            entity.WatchTime = WatchTime;
            entity.TotalWatchTime = TotalWatchTime;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = TrainingMyCourseRecordBL.AddTrainingMyCourseRecord(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingMyCourseRecord(RH_TrainingMyCourseRecord)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingMyCourseRecordModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int PCID = string.IsNullOrEmpty(Request["PCID"])? 0 : int.Parse(Request["PCID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            int WatchTime = string.IsNullOrEmpty(Request["WatchTime"])? 0 : int.Parse(Request["WatchTime"]);
            int TotalWatchTime = string.IsNullOrEmpty(Request["TotalWatchTime"])? 0 : int.Parse(Request["TotalWatchTime"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            TrainingMyCourseRecordEntity entity = new TrainingMyCourseRecordEntity();
            entity.UserID = UserID;
            entity.SubTID = SubTID;
            entity.PCID = PCID;
            entity.CourseID = CourseID;
            entity.WatchTime = WatchTime;
            entity.TotalWatchTime = TotalWatchTime;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingMyCourseRecordBL.ModifyTrainingMyCourseRecord(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingMyCourseRecord(RH_TrainingMyCourseRecord)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingMyCourseRecordView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingMyCourseRecordEntity entity = new TrainingMyCourseRecordEntity();
            try
            {
               entity = TrainingMyCourseRecordBL.GatTrainingMyCourseRecordDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingMyCourseRecord(RH_TrainingMyCourseRecord)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingMyCourseRecordRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingMyCourseRecordBL.RemoveTrainingMyCourseRecord(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingMyCourseRecord(RH_TrainingMyCourseRecord)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingMyCourseRecordList()
        {
            //TrainingMyCourseRecordRH_TrainingMyCourseRecord
            TrainingMyCourseRecordEntityListResult listResult = new TrainingMyCourseRecordEntityListResult();

            TrainingMyCourseRecordSearcher Searcher = new TrainingMyCourseRecordSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingMyCourseRecordInfo> mPage = null;
            try
            {
               listResult = TrainingMyCourseRecordBL.GetTrainingMyCourseRecordEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingMyCourseRecordList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingMyCourseRecord(RH_TrainingMyCourseRecord)出错" + DateTime.Now + "**************************");
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