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
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) Controller类
    ///</summary>
    public class TrainingBriefingController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingBriefing
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingBriefingAdd()
        {
            int ObjectID = string.IsNullOrEmpty(Request["ObjectID"])? 0 : int.Parse(Request["ObjectID"]);
            int MType = string.IsNullOrEmpty(Request["MType"])? 0 : int.Parse(Request["MType"]);
            string Periods = string.IsNullOrEmpty(Request["Periods"])? "" : Request["Periods"].ToString();
            string Title = string.IsNullOrEmpty(Request["Title"])? "" : Request["Title"].ToString();
            string BContnet = string.IsNullOrEmpty(Request["BContnet"])? "" : Request["BContnet"].ToString();
            int ClickNum = string.IsNullOrEmpty(Request["ClickNum"])? 0 : int.Parse(Request["ClickNum"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();

            ////构建实体对象
            TrainingBriefingEntity entity = new TrainingBriefingEntity();
            entity.ObjectID = ObjectID;
            entity.MType = MType;
            entity.Periods = Periods;
            entity.Title = Title;
            entity.BContnet = BContnet;
            entity.ClickNum = ClickNum;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.StaticUrl = StaticUrl;
            int result = 0;
            try
            {
               result = TrainingBriefingBL.AddTrainingBriefing(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingBriefing(RH_TrainingBriefing)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingBriefing
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingBriefingModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int ObjectID = string.IsNullOrEmpty(Request["ObjectID"])? 0 : int.Parse(Request["ObjectID"]);
            int MType = string.IsNullOrEmpty(Request["MType"])? 0 : int.Parse(Request["MType"]);
            string Periods = string.IsNullOrEmpty(Request["Periods"])? "" : Request["Periods"].ToString();
            string Title = string.IsNullOrEmpty(Request["Title"])? "" : Request["Title"].ToString();
            string BContnet = string.IsNullOrEmpty(Request["BContnet"])? "" : Request["BContnet"].ToString();
            int ClickNum = string.IsNullOrEmpty(Request["ClickNum"])? 0 : int.Parse(Request["ClickNum"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();

            ////构建实体对象
            TrainingBriefingEntity entity = new TrainingBriefingEntity();
            entity.ObjectID = ObjectID;
            entity.MType = MType;
            entity.Periods = Periods;
            entity.Title = Title;
            entity.BContnet = BContnet;
            entity.ClickNum = ClickNum;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.StaticUrl = StaticUrl;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingBriefingBL.ModifyTrainingBriefing(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingBriefing(RH_TrainingBriefing)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingBriefingView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingBriefingEntity entity = new TrainingBriefingEntity();
            try
            {
               entity = TrainingBriefingBL.GatTrainingBriefingDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingBriefing(RH_TrainingBriefing)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingBriefingRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingBriefingBL.RemoveTrainingBriefing(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingBriefing(RH_TrainingBriefing)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingBriefingList()
        {
            //TrainingBriefingRH_TrainingBriefing
            TrainingBriefingEntityListResult listResult = new TrainingBriefingEntityListResult();

            TrainingBriefingSearcher Searcher = new TrainingBriefingSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingBriefingInfo> mPage = null;
            try
            {
               listResult = TrainingBriefingBL.GetTrainingBriefingEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingBriefingList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingBriefing(RH_TrainingBriefing)出错" + DateTime.Now + "**************************");
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