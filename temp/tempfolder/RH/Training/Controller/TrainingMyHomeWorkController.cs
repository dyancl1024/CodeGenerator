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
    ///RH_TrainingMyHomeWork ( RH_TrainingMyHomeWork ) Controller类
    ///</summary>
    public class TrainingMyHomeWorkController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingMyHomeWorkAdd()
        {
            string HomeWorkTitle = string.IsNullOrEmpty(Request["HomeWorkTitle"])? "" : Request["HomeWorkTitle"].ToString();
            string HomeWorkContent = string.IsNullOrEmpty(Request["HomeWorkContent"])? "" : Request["HomeWorkContent"].ToString();
            int HomeWorkPhaseID = string.IsNullOrEmpty(Request["HomeWorkPhaseID"])? 0 : int.Parse(Request["HomeWorkPhaseID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            TrainingMyHomeWorkEntity entity = new TrainingMyHomeWorkEntity();
            entity.HomeWorkTitle = HomeWorkTitle;
            entity.HomeWorkContent = HomeWorkContent;
            entity.HomeWorkPhaseID = HomeWorkPhaseID;
            entity.SubTID = SubTID;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = TrainingMyHomeWorkBL.AddTrainingMyHomeWork(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingMyHomeWork(RH_TrainingMyHomeWork)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingMyHomeWorkModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string HomeWorkTitle = string.IsNullOrEmpty(Request["HomeWorkTitle"])? "" : Request["HomeWorkTitle"].ToString();
            string HomeWorkContent = string.IsNullOrEmpty(Request["HomeWorkContent"])? "" : Request["HomeWorkContent"].ToString();
            int HomeWorkPhaseID = string.IsNullOrEmpty(Request["HomeWorkPhaseID"])? 0 : int.Parse(Request["HomeWorkPhaseID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            TrainingMyHomeWorkEntity entity = new TrainingMyHomeWorkEntity();
            entity.HomeWorkTitle = HomeWorkTitle;
            entity.HomeWorkContent = HomeWorkContent;
            entity.HomeWorkPhaseID = HomeWorkPhaseID;
            entity.SubTID = SubTID;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingMyHomeWorkBL.ModifyTrainingMyHomeWork(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingMyHomeWork(RH_TrainingMyHomeWork)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingMyHomeWorkView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingMyHomeWorkEntity entity = new TrainingMyHomeWorkEntity();
            try
            {
               entity = TrainingMyHomeWorkBL.GatTrainingMyHomeWorkDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingMyHomeWork(RH_TrainingMyHomeWork)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingMyHomeWorkRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingMyHomeWorkBL.RemoveTrainingMyHomeWork(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingMyHomeWork(RH_TrainingMyHomeWork)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingMyHomeWorkList()
        {
            //TrainingMyHomeWorkRH_TrainingMyHomeWork
            TrainingMyHomeWorkEntityListResult listResult = new TrainingMyHomeWorkEntityListResult();

            TrainingMyHomeWorkSearcher Searcher = new TrainingMyHomeWorkSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingMyHomeWorkInfo> mPage = null;
            try
            {
               listResult = TrainingMyHomeWorkBL.GetTrainingMyHomeWorkEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingMyHomeWorkList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingMyHomeWork(RH_TrainingMyHomeWork)出错" + DateTime.Now + "**************************");
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