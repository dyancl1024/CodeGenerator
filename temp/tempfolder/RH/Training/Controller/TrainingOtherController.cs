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
    ///RH_TrainingOther ( RH_TrainingOther ) Controller类
    ///</summary>
    public class TrainingOtherController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingOther
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingOtherAdd()
        {
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            string TTitle = string.IsNullOrEmpty(Request["TTitle"])? "" : Request["TTitle"].ToString();
            int TType = string.IsNullOrEmpty(Request["TType"])? 0 : int.Parse(Request["TType"]);
            string TContent = string.IsNullOrEmpty(Request["TContent"])? "" : Request["TContent"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingOtherEntity entity = new TrainingOtherEntity();
            entity.TID = TID;
            entity.SubTID = SubTID;
            entity.TTitle = TTitle;
            entity.TType = TType;
            entity.TContent = TContent;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingOtherBL.AddTrainingOther(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingOther(RH_TrainingOther)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingOther
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingOtherModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            string TTitle = string.IsNullOrEmpty(Request["TTitle"])? "" : Request["TTitle"].ToString();
            int TType = string.IsNullOrEmpty(Request["TType"])? 0 : int.Parse(Request["TType"]);
            string TContent = string.IsNullOrEmpty(Request["TContent"])? "" : Request["TContent"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingOtherEntity entity = new TrainingOtherEntity();
            entity.TID = TID;
            entity.SubTID = SubTID;
            entity.TTitle = TTitle;
            entity.TType = TType;
            entity.TContent = TContent;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingOtherBL.ModifyTrainingOther(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingOther(RH_TrainingOther)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingOther
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingOtherView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingOtherEntity entity = new TrainingOtherEntity();
            try
            {
               entity = TrainingOtherBL.GatTrainingOtherDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingOther(RH_TrainingOther)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingOther
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingOtherRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingOtherBL.RemoveTrainingOther(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingOther(RH_TrainingOther)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingOther
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingOtherList()
        {
            //TrainingOtherRH_TrainingOther
            TrainingOtherEntityListResult listResult = new TrainingOtherEntityListResult();

            TrainingOtherSearcher Searcher = new TrainingOtherSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingOtherInfo> mPage = null;
            try
            {
               listResult = TrainingOtherBL.GetTrainingOtherEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingOtherList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingOther(RH_TrainingOther)出错" + DateTime.Now + "**************************");
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