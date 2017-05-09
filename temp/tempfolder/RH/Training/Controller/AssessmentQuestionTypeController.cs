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
    ///RH_AssessmentQuestionType ( RH_AssessmentQuestionType ) Controller类
    ///</summary>
    public class AssessmentQuestionTypeController : Controller
    {

        /// <summary>
        /// 添加RH_AssessmentQuestionType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentQuestionTypeAdd()
        {
            string TypeName = string.IsNullOrEmpty(Request["TypeName"])? "" : Request["TypeName"].ToString();

            ////构建实体对象
            AssessmentQuestionTypeEntity entity = new AssessmentQuestionTypeEntity();
            entity.TypeName = TypeName;
            int result = 0;
            try
            {
               result = AssessmentQuestionTypeBL.AddAssessmentQuestionType(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加AssessmentQuestionType(RH_AssessmentQuestionType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_AssessmentQuestionType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentQuestionTypeModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string TypeName = string.IsNullOrEmpty(Request["TypeName"])? "" : Request["TypeName"].ToString();

            ////构建实体对象
            AssessmentQuestionTypeEntity entity = new AssessmentQuestionTypeEntity();
            entity.TypeName = TypeName;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = AssessmentQuestionTypeBL.ModifyAssessmentQuestionType(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改AssessmentQuestionType(RH_AssessmentQuestionType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentQuestionTypeView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            AssessmentQuestionTypeEntity entity = new AssessmentQuestionTypeEntity();
            try
            {
               entity = AssessmentQuestionTypeBL.GatAssessmentQuestionTypeDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情AssessmentQuestionType(RH_AssessmentQuestionType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int AssessmentQuestionTypeRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = AssessmentQuestionTypeBL.RemoveAssessmentQuestionType(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentQuestionType(RH_AssessmentQuestionType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentQuestionTypeList()
        {
            //AssessmentQuestionTypeRH_AssessmentQuestionType
            AssessmentQuestionTypeEntityListResult listResult = new AssessmentQuestionTypeEntityListResult();

            AssessmentQuestionTypeSearcher Searcher = new AssessmentQuestionTypeSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<AssessmentQuestionTypeInfo> mPage = null;
            try
            {
               listResult = AssessmentQuestionTypeBL.GetAssessmentQuestionTypeEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.AssessmentQuestionTypeList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentQuestionType(RH_AssessmentQuestionType)出错" + DateTime.Now + "**************************");
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