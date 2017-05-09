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
    ///RH_TrainingStudyGroup ( RH_TrainingStudyGroup ) Controller类
    ///</summary>
    public class TrainingStudyGroupController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroup
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingStudyGroupAdd()
        {
            string StudyGroupName = string.IsNullOrEmpty(Request["StudyGroupName"])? "" : Request["StudyGroupName"].ToString();
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int CID = string.IsNullOrEmpty(Request["CID"])? 0 : int.Parse(Request["CID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingStudyGroupEntity entity = new TrainingStudyGroupEntity();
            entity.StudyGroupName = StudyGroupName;
            entity.SubTID = SubTID;
            entity.CID = CID;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingStudyGroupBL.AddTrainingStudyGroup(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingStudyGroup(RH_TrainingStudyGroup)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingStudyGroup
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingStudyGroupModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string StudyGroupName = string.IsNullOrEmpty(Request["StudyGroupName"])? "" : Request["StudyGroupName"].ToString();
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int CID = string.IsNullOrEmpty(Request["CID"])? 0 : int.Parse(Request["CID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingStudyGroupEntity entity = new TrainingStudyGroupEntity();
            entity.StudyGroupName = StudyGroupName;
            entity.SubTID = SubTID;
            entity.CID = CID;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingStudyGroupBL.ModifyTrainingStudyGroup(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingStudyGroup(RH_TrainingStudyGroup)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingStudyGroupView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingStudyGroupEntity entity = new TrainingStudyGroupEntity();
            try
            {
               entity = TrainingStudyGroupBL.GatTrainingStudyGroupDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingStudyGroup(RH_TrainingStudyGroup)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingStudyGroupRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingStudyGroupBL.RemoveTrainingStudyGroup(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingStudyGroup(RH_TrainingStudyGroup)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingStudyGroupList()
        {
            //TrainingStudyGroupRH_TrainingStudyGroup
            TrainingStudyGroupEntityListResult listResult = new TrainingStudyGroupEntityListResult();

            TrainingStudyGroupSearcher Searcher = new TrainingStudyGroupSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingStudyGroupInfo> mPage = null;
            try
            {
               listResult = TrainingStudyGroupBL.GetTrainingStudyGroupEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingStudyGroupList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingStudyGroup(RH_TrainingStudyGroup)出错" + DateTime.Now + "**************************");
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