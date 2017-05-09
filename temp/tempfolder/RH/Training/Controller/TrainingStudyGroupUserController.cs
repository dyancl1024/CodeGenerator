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
    ///RH_TrainingStudyGroupUser ( RH_TrainingStudyGroupUser ) Controller类
    ///</summary>
    public class TrainingStudyGroupUserController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingStudyGroupUserAdd()
        {
            int StudyGroupID = string.IsNullOrEmpty(Request["StudyGroupID"])? 0 : int.Parse(Request["StudyGroupID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            TrainingStudyGroupUserEntity entity = new TrainingStudyGroupUserEntity();
            entity.StudyGroupID = StudyGroupID;
            entity.UserID = UserID;
            entity.Status = Status;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = TrainingStudyGroupUserBL.AddTrainingStudyGroupUser(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingStudyGroupUser(RH_TrainingStudyGroupUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingStudyGroupUserModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int StudyGroupID = string.IsNullOrEmpty(Request["StudyGroupID"])? 0 : int.Parse(Request["StudyGroupID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            TrainingStudyGroupUserEntity entity = new TrainingStudyGroupUserEntity();
            entity.StudyGroupID = StudyGroupID;
            entity.UserID = UserID;
            entity.Status = Status;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingStudyGroupUserBL.ModifyTrainingStudyGroupUser(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingStudyGroupUser(RH_TrainingStudyGroupUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingStudyGroupUserView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingStudyGroupUserEntity entity = new TrainingStudyGroupUserEntity();
            try
            {
               entity = TrainingStudyGroupUserBL.GatTrainingStudyGroupUserDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingStudyGroupUser(RH_TrainingStudyGroupUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingStudyGroupUserRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingStudyGroupUserBL.RemoveTrainingStudyGroupUser(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingStudyGroupUser(RH_TrainingStudyGroupUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingStudyGroupUserList()
        {
            //TrainingStudyGroupUserRH_TrainingStudyGroupUser
            TrainingStudyGroupUserEntityListResult listResult = new TrainingStudyGroupUserEntityListResult();

            TrainingStudyGroupUserSearcher Searcher = new TrainingStudyGroupUserSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingStudyGroupUserInfo> mPage = null;
            try
            {
               listResult = TrainingStudyGroupUserBL.GetTrainingStudyGroupUserEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingStudyGroupUserList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingStudyGroupUser(RH_TrainingStudyGroupUser)出错" + DateTime.Now + "**************************");
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