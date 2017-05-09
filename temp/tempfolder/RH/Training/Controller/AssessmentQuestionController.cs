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
    ///RH_AssessmentQuestion ( RH_AssessmentQuestion ) Controller类
    ///</summary>
    public class AssessmentQuestionController : Controller
    {

        /// <summary>
        /// 添加RH_AssessmentQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentQuestionAdd()
        {
            int AssessmentID = string.IsNullOrEmpty(Request["AssessmentID"])? 0 : int.Parse(Request["AssessmentID"]);
            string Question = string.IsNullOrEmpty(Request["Question"])? "" : Request["Question"].ToString();
            string QuestionDesc = string.IsNullOrEmpty(Request["QuestionDesc"])? "" : Request["QuestionDesc"].ToString();
            int TypeID = string.IsNullOrEmpty(Request["TypeID"])? 0 : int.Parse(Request["TypeID"]);
            int Dimensions = string.IsNullOrEmpty(Request["Dimensions"])? 0 : int.Parse(Request["Dimensions"]);
            int SortNo = string.IsNullOrEmpty(Request["SortNo"])? 0 : int.Parse(Request["SortNo"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            AssessmentQuestionEntity entity = new AssessmentQuestionEntity();
            entity.AssessmentID = AssessmentID;
            entity.Question = Question;
            entity.QuestionDesc = QuestionDesc;
            entity.TypeID = TypeID;
            entity.Dimensions = Dimensions;
            entity.SortNo = SortNo;
            entity.Status = Status;
            int result = 0;
            try
            {
               result = AssessmentQuestionBL.AddAssessmentQuestion(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加AssessmentQuestion(RH_AssessmentQuestion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_AssessmentQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AssessmentQuestionModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int AssessmentID = string.IsNullOrEmpty(Request["AssessmentID"])? 0 : int.Parse(Request["AssessmentID"]);
            string Question = string.IsNullOrEmpty(Request["Question"])? "" : Request["Question"].ToString();
            string QuestionDesc = string.IsNullOrEmpty(Request["QuestionDesc"])? "" : Request["QuestionDesc"].ToString();
            int TypeID = string.IsNullOrEmpty(Request["TypeID"])? 0 : int.Parse(Request["TypeID"]);
            int Dimensions = string.IsNullOrEmpty(Request["Dimensions"])? 0 : int.Parse(Request["Dimensions"]);
            int SortNo = string.IsNullOrEmpty(Request["SortNo"])? 0 : int.Parse(Request["SortNo"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            AssessmentQuestionEntity entity = new AssessmentQuestionEntity();
            entity.AssessmentID = AssessmentID;
            entity.Question = Question;
            entity.QuestionDesc = QuestionDesc;
            entity.TypeID = TypeID;
            entity.Dimensions = Dimensions;
            entity.SortNo = SortNo;
            entity.Status = Status;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = AssessmentQuestionBL.ModifyAssessmentQuestion(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改AssessmentQuestion(RH_AssessmentQuestion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_AssessmentQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentQuestionView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            AssessmentQuestionEntity entity = new AssessmentQuestionEntity();
            try
            {
               entity = AssessmentQuestionBL.GatAssessmentQuestionDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情AssessmentQuestion(RH_AssessmentQuestion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_AssessmentQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int AssessmentQuestionRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = AssessmentQuestionBL.RemoveAssessmentQuestion(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentQuestion(RH_AssessmentQuestion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_AssessmentQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult AssessmentQuestionList()
        {
            //AssessmentQuestionRH_AssessmentQuestion
            AssessmentQuestionEntityListResult listResult = new AssessmentQuestionEntityListResult();

            AssessmentQuestionSearcher Searcher = new AssessmentQuestionSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<AssessmentQuestionInfo> mPage = null;
            try
            {
               listResult = AssessmentQuestionBL.GetAssessmentQuestionEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.AssessmentQuestionList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除AssessmentQuestion(RH_AssessmentQuestion)出错" + DateTime.Now + "**************************");
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