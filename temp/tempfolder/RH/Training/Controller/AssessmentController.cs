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
    ///RH_Assessment ( RH_Assessment ) Controller类
    ///</summary>
    public class AssessmentController : Controller
    {

        /// <summary>
        /// 添加RH_Assessment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentAdd()
        {
            string AName = string.IsNullOrEmpty(Request["AName"])? "" : Request["AName"].ToString();
            string ADesc = string.IsNullOrEmpty(Request["ADesc"])? "" : Request["ADesc"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            AssessmentEntity entity = new AssessmentEntity();
            entity.AName = AName;
            entity.ADesc = ADesc;
            entity.Status = Status;
            int result = 0;
            try
            {
               result = AssessmentBL.AddAssessment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Assessment(RH_Assessment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Assessment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string AName = string.IsNullOrEmpty(Request["AName"])? "" : Request["AName"].ToString();
            string ADesc = string.IsNullOrEmpty(Request["ADesc"])? "" : Request["ADesc"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            AssessmentEntity entity = new AssessmentEntity();
            entity.AName = AName;
            entity.ADesc = ADesc;
            entity.Status = Status;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = AssessmentBL.ModifyAssessment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Assessment(RH_Assessment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Assessment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            AssessmentEntity entity = new AssessmentEntity();
            try
            {
               entity = AssessmentBL.GatAssessmentDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Assessment(RH_Assessment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Assessment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int AssessmentRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = AssessmentBL.RemoveAssessment(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Assessment(RH_Assessment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Assessment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentList()
        {
            //AssessmentRH_Assessment
            AssessmentEntityListResult listResult = new AssessmentEntityListResult();

            AssessmentSearcher Searcher = new AssessmentSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<AssessmentInfo> mPage = null;
            try
            {
               listResult = AssessmentBL.GetAssessmentEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.AssessmentList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Assessment(RH_Assessment)出错" + DateTime.Now + "**************************");
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