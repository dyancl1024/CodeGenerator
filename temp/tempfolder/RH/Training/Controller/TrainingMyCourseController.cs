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
    ///RH_TrainingMyCourse ( RH_TrainingMyCourse ) Controller类
    ///</summary>
    public class TrainingMyCourseController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingMyCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingMyCourseAdd()
        {
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int PCID = string.IsNullOrEmpty(Request["PCID"])? 0 : int.Parse(Request["PCID"]);
            int CID = string.IsNullOrEmpty(Request["CID"])? 0 : int.Parse(Request["CID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            TrainingMyCourseEntity entity = new TrainingMyCourseEntity();
            entity.SubTID = SubTID;
            entity.PCID = PCID;
            entity.CID = CID;
            entity.UserID = UserID;
            entity.CreateTime = CreateTime;
            entity.Status = Status;
            int result = 0;
            try
            {
               result = TrainingMyCourseBL.AddTrainingMyCourse(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingMyCourse(RH_TrainingMyCourse)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingMyCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingMyCourseModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int PCID = string.IsNullOrEmpty(Request["PCID"])? 0 : int.Parse(Request["PCID"]);
            int CID = string.IsNullOrEmpty(Request["CID"])? 0 : int.Parse(Request["CID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            TrainingMyCourseEntity entity = new TrainingMyCourseEntity();
            entity.SubTID = SubTID;
            entity.PCID = PCID;
            entity.CID = CID;
            entity.UserID = UserID;
            entity.CreateTime = CreateTime;
            entity.Status = Status;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingMyCourseBL.ModifyTrainingMyCourse(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingMyCourse(RH_TrainingMyCourse)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingMyCourseView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingMyCourseEntity entity = new TrainingMyCourseEntity();
            try
            {
               entity = TrainingMyCourseBL.GatTrainingMyCourseDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingMyCourse(RH_TrainingMyCourse)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingMyCourseRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingMyCourseBL.RemoveTrainingMyCourse(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingMyCourse(RH_TrainingMyCourse)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingMyCourseList()
        {
            //TrainingMyCourseRH_TrainingMyCourse
            TrainingMyCourseEntityListResult listResult = new TrainingMyCourseEntityListResult();

            TrainingMyCourseSearcher Searcher = new TrainingMyCourseSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingMyCourseInfo> mPage = null;
            try
            {
               listResult = TrainingMyCourseBL.GetTrainingMyCourseEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingMyCourseList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingMyCourse(RH_TrainingMyCourse)出错" + DateTime.Now + "**************************");
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