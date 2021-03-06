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
    ///RH_TrainingStudyGroupComment ( RH_TrainingStudyGroupComment ) Controller类
    ///</summary>
    public class TrainingStudyGroupCommentController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingStudyGroupCommentAdd()
        {
            int StudyGroupID = string.IsNullOrEmpty(Request["StudyGroupID"])? 0 : int.Parse(Request["StudyGroupID"]);
            string CommentTitile = string.IsNullOrEmpty(Request["CommentTitile"])? "" : Request["CommentTitile"].ToString();
            string Comment = string.IsNullOrEmpty(Request["Comment"])? "" : Request["Comment"].ToString();
            string IPAdress = string.IsNullOrEmpty(Request["IPAdress"])? "" : Request["IPAdress"].ToString();
            int ParentID = string.IsNullOrEmpty(Request["ParentID"])? 0 : int.Parse(Request["ParentID"]);
            int IsExpert = string.IsNullOrEmpty(Request["IsExpert"])? 0 : int.Parse(Request["IsExpert"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            TrainingStudyGroupCommentEntity entity = new TrainingStudyGroupCommentEntity();
            entity.StudyGroupID = StudyGroupID;
            entity.CommentTitile = CommentTitile;
            entity.Comment = Comment;
            entity.IPAdress = IPAdress;
            entity.ParentID = ParentID;
            entity.IsExpert = IsExpert;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = TrainingStudyGroupCommentBL.AddTrainingStudyGroupComment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingStudyGroupComment(RH_TrainingStudyGroupComment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingStudyGroupCommentModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int StudyGroupID = string.IsNullOrEmpty(Request["StudyGroupID"])? 0 : int.Parse(Request["StudyGroupID"]);
            string CommentTitile = string.IsNullOrEmpty(Request["CommentTitile"])? "" : Request["CommentTitile"].ToString();
            string Comment = string.IsNullOrEmpty(Request["Comment"])? "" : Request["Comment"].ToString();
            string IPAdress = string.IsNullOrEmpty(Request["IPAdress"])? "" : Request["IPAdress"].ToString();
            int ParentID = string.IsNullOrEmpty(Request["ParentID"])? 0 : int.Parse(Request["ParentID"]);
            int IsExpert = string.IsNullOrEmpty(Request["IsExpert"])? 0 : int.Parse(Request["IsExpert"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            TrainingStudyGroupCommentEntity entity = new TrainingStudyGroupCommentEntity();
            entity.StudyGroupID = StudyGroupID;
            entity.CommentTitile = CommentTitile;
            entity.Comment = Comment;
            entity.IPAdress = IPAdress;
            entity.ParentID = ParentID;
            entity.IsExpert = IsExpert;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingStudyGroupCommentBL.ModifyTrainingStudyGroupComment(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingStudyGroupComment(RH_TrainingStudyGroupComment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingStudyGroupCommentView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingStudyGroupCommentEntity entity = new TrainingStudyGroupCommentEntity();
            try
            {
               entity = TrainingStudyGroupCommentBL.GatTrainingStudyGroupCommentDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingStudyGroupComment(RH_TrainingStudyGroupComment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingStudyGroupCommentRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingStudyGroupCommentBL.RemoveTrainingStudyGroupComment(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingStudyGroupComment(RH_TrainingStudyGroupComment)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingStudyGroupCommentList()
        {
            //TrainingStudyGroupCommentRH_TrainingStudyGroupComment
            TrainingStudyGroupCommentEntityListResult listResult = new TrainingStudyGroupCommentEntityListResult();

            TrainingStudyGroupCommentSearcher Searcher = new TrainingStudyGroupCommentSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingStudyGroupCommentInfo> mPage = null;
            try
            {
               listResult = TrainingStudyGroupCommentBL.GetTrainingStudyGroupCommentEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingStudyGroupCommentList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingStudyGroupComment(RH_TrainingStudyGroupComment)出错" + DateTime.Now + "**************************");
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