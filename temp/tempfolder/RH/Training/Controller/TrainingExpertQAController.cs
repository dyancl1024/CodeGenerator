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
    ///RH_TrainingExpertQA ( RH_TrainingExpertQA ) Controller类
    ///</summary>
    public class TrainingExpertQAController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingExpertQA
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingExpertQAAdd()
        {
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);
            string QATitle = string.IsNullOrEmpty(Request["QATitle"])? "" : Request["QATitle"].ToString();
            string QAContent = string.IsNullOrEmpty(Request["QAContent"])? "" : Request["QAContent"].ToString();
            int ClickNum = string.IsNullOrEmpty(Request["ClickNum"])? 0 : int.Parse(Request["ClickNum"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingExpertQAEntity entity = new TrainingExpertQAEntity();
            entity.TID = TID;
            entity.QATitle = QATitle;
            entity.QAContent = QAContent;
            entity.ClickNum = ClickNum;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingExpertQABL.AddTrainingExpertQA(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingExpertQA(RH_TrainingExpertQA)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingExpertQA
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingExpertQAModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);
            string QATitle = string.IsNullOrEmpty(Request["QATitle"])? "" : Request["QATitle"].ToString();
            string QAContent = string.IsNullOrEmpty(Request["QAContent"])? "" : Request["QAContent"].ToString();
            int ClickNum = string.IsNullOrEmpty(Request["ClickNum"])? 0 : int.Parse(Request["ClickNum"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingExpertQAEntity entity = new TrainingExpertQAEntity();
            entity.TID = TID;
            entity.QATitle = QATitle;
            entity.QAContent = QAContent;
            entity.ClickNum = ClickNum;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingExpertQABL.ModifyTrainingExpertQA(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingExpertQA(RH_TrainingExpertQA)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingExpertQAView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingExpertQAEntity entity = new TrainingExpertQAEntity();
            try
            {
               entity = TrainingExpertQABL.GatTrainingExpertQADetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingExpertQA(RH_TrainingExpertQA)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingExpertQARemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingExpertQABL.RemoveTrainingExpertQA(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingExpertQA(RH_TrainingExpertQA)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingExpertQAList()
        {
            //TrainingExpertQARH_TrainingExpertQA
            TrainingExpertQAEntityListResult listResult = new TrainingExpertQAEntityListResult();

            TrainingExpertQASearcher Searcher = new TrainingExpertQASearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingExpertQAInfo> mPage = null;
            try
            {
               listResult = TrainingExpertQABL.GetTrainingExpertQAEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingExpertQAList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingExpertQA(RH_TrainingExpertQA)出错" + DateTime.Now + "**************************");
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