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
    ///RH_Training ( RH_Training ) Controller类
    ///</summary>
    public class TrainingController : Controller
    {

        /// <summary>
        /// 添加RH_Training
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingAdd()
        {
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            string TName = string.IsNullOrEmpty(Request["TName"])? "" : Request["TName"].ToString();
            int TrainingPhase = string.IsNullOrEmpty(Request["TrainingPhase"])? 0 : int.Parse(Request["TrainingPhase"]);
            int TrainingNum = string.IsNullOrEmpty(Request["TrainingNum"])? 0 : int.Parse(Request["TrainingNum"]);
            string TrainingLevelCode = string.IsNullOrEmpty(Request["TrainingLevelCode"])? "" : Request["TrainingLevelCode"].ToString();
            string TrainingTypeCode = string.IsNullOrEmpty(Request["TrainingTypeCode"])? "" : Request["TrainingTypeCode"].ToString();
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            DateTime TrainingDateB = string.IsNullOrEmpty(Request["TrainingDateB"])? DateTime.Now : DateTime.Parse(Request["TrainingDateB"]);
            DateTime TrainingDateE = string.IsNullOrEmpty(Request["TrainingDateE"])? DateTime.Now : DateTime.Parse(Request["TrainingDateE"]);
            int IsStage = string.IsNullOrEmpty(Request["IsStage"])? 0 : int.Parse(Request["IsStage"]);
            string TrainingUrl = string.IsNullOrEmpty(Request["TrainingUrl"])? "" : Request["TrainingUrl"].ToString();
            string TrainingCode = string.IsNullOrEmpty(Request["TrainingCode"])? "" : Request["TrainingCode"].ToString();
            string TrainingHeadImg = string.IsNullOrEmpty(Request["TrainingHeadImg"])? "" : Request["TrainingHeadImg"].ToString();
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);
            int Publisher = string.IsNullOrEmpty(Request["Publisher"])? 0 : int.Parse(Request["Publisher"]);
            DateTime PublishDate = string.IsNullOrEmpty(Request["PublishDate"])? DateTime.Now : DateTime.Parse(Request["PublishDate"]);

            ////构建实体对象
            TrainingEntity entity = new TrainingEntity();
            entity.DesignID = DesignID;
            entity.TName = TName;
            entity.TrainingPhase = TrainingPhase;
            entity.TrainingNum = TrainingNum;
            entity.TrainingLevelCode = TrainingLevelCode;
            entity.TrainingTypeCode = TrainingTypeCode;
            entity.ProvinceID = ProvinceID;
            entity.CityID = CityID;
            entity.DistrictID = DistrictID;
            entity.TrainingDateB = TrainingDateB;
            entity.TrainingDateE = TrainingDateE;
            entity.IsStage = IsStage;
            entity.TrainingUrl = TrainingUrl;
            entity.TrainingCode = TrainingCode;
            entity.TrainingHeadImg = TrainingHeadImg;
            entity.StaticUrl = StaticUrl;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.Publisher = Publisher;
            entity.PublishDate = PublishDate;
            int result = 0;
            try
            {
               result = TrainingBL.AddTraining(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Training(RH_Training)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Training
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            string TName = string.IsNullOrEmpty(Request["TName"])? "" : Request["TName"].ToString();
            int TrainingPhase = string.IsNullOrEmpty(Request["TrainingPhase"])? 0 : int.Parse(Request["TrainingPhase"]);
            int TrainingNum = string.IsNullOrEmpty(Request["TrainingNum"])? 0 : int.Parse(Request["TrainingNum"]);
            string TrainingLevelCode = string.IsNullOrEmpty(Request["TrainingLevelCode"])? "" : Request["TrainingLevelCode"].ToString();
            string TrainingTypeCode = string.IsNullOrEmpty(Request["TrainingTypeCode"])? "" : Request["TrainingTypeCode"].ToString();
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            DateTime TrainingDateB = string.IsNullOrEmpty(Request["TrainingDateB"])? DateTime.Now : DateTime.Parse(Request["TrainingDateB"]);
            DateTime TrainingDateE = string.IsNullOrEmpty(Request["TrainingDateE"])? DateTime.Now : DateTime.Parse(Request["TrainingDateE"]);
            int IsStage = string.IsNullOrEmpty(Request["IsStage"])? 0 : int.Parse(Request["IsStage"]);
            string TrainingUrl = string.IsNullOrEmpty(Request["TrainingUrl"])? "" : Request["TrainingUrl"].ToString();
            string TrainingCode = string.IsNullOrEmpty(Request["TrainingCode"])? "" : Request["TrainingCode"].ToString();
            string TrainingHeadImg = string.IsNullOrEmpty(Request["TrainingHeadImg"])? "" : Request["TrainingHeadImg"].ToString();
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);
            int Publisher = string.IsNullOrEmpty(Request["Publisher"])? 0 : int.Parse(Request["Publisher"]);
            DateTime PublishDate = string.IsNullOrEmpty(Request["PublishDate"])? DateTime.Now : DateTime.Parse(Request["PublishDate"]);

            ////构建实体对象
            TrainingEntity entity = new TrainingEntity();
            entity.DesignID = DesignID;
            entity.TName = TName;
            entity.TrainingPhase = TrainingPhase;
            entity.TrainingNum = TrainingNum;
            entity.TrainingLevelCode = TrainingLevelCode;
            entity.TrainingTypeCode = TrainingTypeCode;
            entity.ProvinceID = ProvinceID;
            entity.CityID = CityID;
            entity.DistrictID = DistrictID;
            entity.TrainingDateB = TrainingDateB;
            entity.TrainingDateE = TrainingDateE;
            entity.IsStage = IsStage;
            entity.TrainingUrl = TrainingUrl;
            entity.TrainingCode = TrainingCode;
            entity.TrainingHeadImg = TrainingHeadImg;
            entity.StaticUrl = StaticUrl;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.Publisher = Publisher;
            entity.PublishDate = PublishDate;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingBL.ModifyTraining(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Training(RH_Training)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingEntity entity = new TrainingEntity();
            try
            {
               entity = TrainingBL.GatTrainingDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Training(RH_Training)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingBL.RemoveTraining(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Training(RH_Training)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingList()
        {
            //TrainingRH_Training
            TrainingEntityListResult listResult = new TrainingEntityListResult();

            TrainingSearcher Searcher = new TrainingSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingInfo> mPage = null;
            try
            {
               listResult = TrainingBL.GetTrainingEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Training(RH_Training)出错" + DateTime.Now + "**************************");
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