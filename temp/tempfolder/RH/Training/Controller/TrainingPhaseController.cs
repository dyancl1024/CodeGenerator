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
    ///RH_TrainingPhase ( RH_TrainingPhase ) Controller类
    ///</summary>
    public class TrainingPhaseController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingPhase
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingPhaseAdd()
        {
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int PType = string.IsNullOrEmpty(Request["PType"])? 0 : int.Parse(Request["PType"]);
            string HomeName = string.IsNullOrEmpty(Request["HomeName"])? "" : Request["HomeName"].ToString();
            string HomeWorkDesc = string.IsNullOrEmpty(Request["HomeWorkDesc"])? "" : Request["HomeWorkDesc"].ToString();
            string HomeWorkCode = string.IsNullOrEmpty(Request["HomeWorkCode"])? "" : Request["HomeWorkCode"].ToString();
            int Phase = string.IsNullOrEmpty(Request["Phase"])? 0 : int.Parse(Request["Phase"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingPhaseEntity entity = new TrainingPhaseEntity();
            entity.SubTID = SubTID;
            entity.PType = PType;
            entity.HomeName = HomeName;
            entity.HomeWorkDesc = HomeWorkDesc;
            entity.HomeWorkCode = HomeWorkCode;
            entity.Phase = Phase;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingPhaseBL.AddTrainingPhase(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingPhase(RH_TrainingPhase)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingPhase
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingPhaseModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int PType = string.IsNullOrEmpty(Request["PType"])? 0 : int.Parse(Request["PType"]);
            string HomeName = string.IsNullOrEmpty(Request["HomeName"])? "" : Request["HomeName"].ToString();
            string HomeWorkDesc = string.IsNullOrEmpty(Request["HomeWorkDesc"])? "" : Request["HomeWorkDesc"].ToString();
            string HomeWorkCode = string.IsNullOrEmpty(Request["HomeWorkCode"])? "" : Request["HomeWorkCode"].ToString();
            int Phase = string.IsNullOrEmpty(Request["Phase"])? 0 : int.Parse(Request["Phase"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingPhaseEntity entity = new TrainingPhaseEntity();
            entity.SubTID = SubTID;
            entity.PType = PType;
            entity.HomeName = HomeName;
            entity.HomeWorkDesc = HomeWorkDesc;
            entity.HomeWorkCode = HomeWorkCode;
            entity.Phase = Phase;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingPhaseBL.ModifyTrainingPhase(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingPhase(RH_TrainingPhase)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingPhaseView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingPhaseEntity entity = new TrainingPhaseEntity();
            try
            {
               entity = TrainingPhaseBL.GatTrainingPhaseDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingPhase(RH_TrainingPhase)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingPhaseRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingPhaseBL.RemoveTrainingPhase(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingPhase(RH_TrainingPhase)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingPhaseList()
        {
            //TrainingPhaseRH_TrainingPhase
            TrainingPhaseEntityListResult listResult = new TrainingPhaseEntityListResult();

            TrainingPhaseSearcher Searcher = new TrainingPhaseSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingPhaseInfo> mPage = null;
            try
            {
               listResult = TrainingPhaseBL.GetTrainingPhaseEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingPhaseList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingPhase(RH_TrainingPhase)出错" + DateTime.Now + "**************************");
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