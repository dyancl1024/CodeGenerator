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
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) Controller类
    ///</summary>
    public class TrainingTeacherSummaryController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingTeacherSummaryAdd()
        {
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int Ttype = string.IsNullOrEmpty(Request["Ttype"])? 0 : int.Parse(Request["Ttype"]);
            string TeacherSummaryTitle = string.IsNullOrEmpty(Request["TeacherSummaryTitle"])? "" : Request["TeacherSummaryTitle"].ToString();
            string TeacherSummaryContent = string.IsNullOrEmpty(Request["TeacherSummaryContent"])? "" : Request["TeacherSummaryContent"].ToString();
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingTeacherSummaryEntity entity = new TrainingTeacherSummaryEntity();
            entity.TID = TID;
            entity.SubTID = SubTID;
            entity.Ttype = Ttype;
            entity.TeacherSummaryTitle = TeacherSummaryTitle;
            entity.TeacherSummaryContent = TeacherSummaryContent;
            entity.StaticUrl = StaticUrl;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingTeacherSummaryBL.AddTrainingTeacherSummary(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingTeacherSummary(RH_TrainingTeacherSummary)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingTeacherSummaryModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int Ttype = string.IsNullOrEmpty(Request["Ttype"])? 0 : int.Parse(Request["Ttype"]);
            string TeacherSummaryTitle = string.IsNullOrEmpty(Request["TeacherSummaryTitle"])? "" : Request["TeacherSummaryTitle"].ToString();
            string TeacherSummaryContent = string.IsNullOrEmpty(Request["TeacherSummaryContent"])? "" : Request["TeacherSummaryContent"].ToString();
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingTeacherSummaryEntity entity = new TrainingTeacherSummaryEntity();
            entity.TID = TID;
            entity.SubTID = SubTID;
            entity.Ttype = Ttype;
            entity.TeacherSummaryTitle = TeacherSummaryTitle;
            entity.TeacherSummaryContent = TeacherSummaryContent;
            entity.StaticUrl = StaticUrl;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingTeacherSummaryBL.ModifyTrainingTeacherSummary(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingTeacherSummary(RH_TrainingTeacherSummary)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingTeacherSummaryView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingTeacherSummaryEntity entity = new TrainingTeacherSummaryEntity();
            try
            {
               entity = TrainingTeacherSummaryBL.GatTrainingTeacherSummaryDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingTeacherSummary(RH_TrainingTeacherSummary)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingTeacherSummaryRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingTeacherSummaryBL.RemoveTrainingTeacherSummary(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingTeacherSummary(RH_TrainingTeacherSummary)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingTeacherSummaryList()
        {
            //TrainingTeacherSummaryRH_TrainingTeacherSummary
            TrainingTeacherSummaryEntityListResult listResult = new TrainingTeacherSummaryEntityListResult();

            TrainingTeacherSummarySearcher Searcher = new TrainingTeacherSummarySearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingTeacherSummaryInfo> mPage = null;
            try
            {
               listResult = TrainingTeacherSummaryBL.GetTrainingTeacherSummaryEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingTeacherSummaryList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingTeacherSummary(RH_TrainingTeacherSummary)出错" + DateTime.Now + "**************************");
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