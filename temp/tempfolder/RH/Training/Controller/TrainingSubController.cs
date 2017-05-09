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
    ///RH_TrainingSub ( RH_TrainingSub ) Controller类
    ///</summary>
    public class TrainingSubController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingSubAdd()
        {
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);
            string TName = string.IsNullOrEmpty(Request["TName"])? "" : Request["TName"].ToString();
            int TrainingNum = string.IsNullOrEmpty(Request["TrainingNum"])? 0 : int.Parse(Request["TrainingNum"]);
            string TrainingLevelCode = string.IsNullOrEmpty(Request["TrainingLevelCode"])? "" : Request["TrainingLevelCode"].ToString();
            string TrainingTypeCode = string.IsNullOrEmpty(Request["TrainingTypeCode"])? "" : Request["TrainingTypeCode"].ToString();
            int TMethod = string.IsNullOrEmpty(Request["TMethod"])? 0 : int.Parse(Request["TMethod"]);
            int IsGP = string.IsNullOrEmpty(Request["IsGP"])? 0 : int.Parse(Request["IsGP"]);
            string OrgCode = string.IsNullOrEmpty(Request["OrgCode"])? "" : Request["OrgCode"].ToString();
            DateTime TrainingDateB = string.IsNullOrEmpty(Request["TrainingDateB"])? DateTime.Now : DateTime.Parse(Request["TrainingDateB"]);
            DateTime TrainingDateE = string.IsNullOrEmpty(Request["TrainingDateE"])? DateTime.Now : DateTime.Parse(Request["TrainingDateE"]);
            int SignupRule = string.IsNullOrEmpty(Request["SignupRule"])? 0 : int.Parse(Request["SignupRule"]);
            string ClassRule = string.IsNullOrEmpty(Request["ClassRule"])? "" : Request["ClassRule"].ToString();
            int IsStage = string.IsNullOrEmpty(Request["IsStage"])? 0 : int.Parse(Request["IsStage"]);
            string TrainingUrl = string.IsNullOrEmpty(Request["TrainingUrl"])? "" : Request["TrainingUrl"].ToString();
            string TrainingHeadImg = string.IsNullOrEmpty(Request["TrainingHeadImg"])? "" : Request["TrainingHeadImg"].ToString();
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            string AskTel = string.IsNullOrEmpty(Request["AskTel"])? "" : Request["AskTel"].ToString();
            int IsShowQQ = string.IsNullOrEmpty(Request["IsShowQQ"])? 0 : int.Parse(Request["IsShowQQ"]);
            int TestMethod = string.IsNullOrEmpty(Request["TestMethod"])? 0 : int.Parse(Request["TestMethod"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);
            int Publisher = string.IsNullOrEmpty(Request["Publisher"])? 0 : int.Parse(Request["Publisher"]);
            DateTime PublishDate = string.IsNullOrEmpty(Request["PublishDate"])? DateTime.Now : DateTime.Parse(Request["PublishDate"]);

            ////构建实体对象
            TrainingSubEntity entity = new TrainingSubEntity();
            entity.TID = TID;
            entity.TName = TName;
            entity.TrainingNum = TrainingNum;
            entity.TrainingLevelCode = TrainingLevelCode;
            entity.TrainingTypeCode = TrainingTypeCode;
            entity.TMethod = TMethod;
            entity.IsGP = IsGP;
            entity.OrgCode = OrgCode;
            entity.TrainingDateB = TrainingDateB;
            entity.TrainingDateE = TrainingDateE;
            entity.SignupRule = SignupRule;
            entity.ClassRule = ClassRule;
            entity.IsStage = IsStage;
            entity.TrainingUrl = TrainingUrl;
            entity.TrainingHeadImg = TrainingHeadImg;
            entity.StaticUrl = StaticUrl;
            entity.Status = Status;
            entity.AskTel = AskTel;
            entity.IsShowQQ = IsShowQQ;
            entity.TestMethod = TestMethod;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.Publisher = Publisher;
            entity.PublishDate = PublishDate;
            int result = 0;
            try
            {
               result = TrainingSubBL.AddTrainingSub(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingSub(RH_TrainingSub)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingSubModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);
            string TName = string.IsNullOrEmpty(Request["TName"])? "" : Request["TName"].ToString();
            int TrainingNum = string.IsNullOrEmpty(Request["TrainingNum"])? 0 : int.Parse(Request["TrainingNum"]);
            string TrainingLevelCode = string.IsNullOrEmpty(Request["TrainingLevelCode"])? "" : Request["TrainingLevelCode"].ToString();
            string TrainingTypeCode = string.IsNullOrEmpty(Request["TrainingTypeCode"])? "" : Request["TrainingTypeCode"].ToString();
            int TMethod = string.IsNullOrEmpty(Request["TMethod"])? 0 : int.Parse(Request["TMethod"]);
            int IsGP = string.IsNullOrEmpty(Request["IsGP"])? 0 : int.Parse(Request["IsGP"]);
            string OrgCode = string.IsNullOrEmpty(Request["OrgCode"])? "" : Request["OrgCode"].ToString();
            DateTime TrainingDateB = string.IsNullOrEmpty(Request["TrainingDateB"])? DateTime.Now : DateTime.Parse(Request["TrainingDateB"]);
            DateTime TrainingDateE = string.IsNullOrEmpty(Request["TrainingDateE"])? DateTime.Now : DateTime.Parse(Request["TrainingDateE"]);
            int SignupRule = string.IsNullOrEmpty(Request["SignupRule"])? 0 : int.Parse(Request["SignupRule"]);
            string ClassRule = string.IsNullOrEmpty(Request["ClassRule"])? "" : Request["ClassRule"].ToString();
            int IsStage = string.IsNullOrEmpty(Request["IsStage"])? 0 : int.Parse(Request["IsStage"]);
            string TrainingUrl = string.IsNullOrEmpty(Request["TrainingUrl"])? "" : Request["TrainingUrl"].ToString();
            string TrainingHeadImg = string.IsNullOrEmpty(Request["TrainingHeadImg"])? "" : Request["TrainingHeadImg"].ToString();
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            string AskTel = string.IsNullOrEmpty(Request["AskTel"])? "" : Request["AskTel"].ToString();
            int IsShowQQ = string.IsNullOrEmpty(Request["IsShowQQ"])? 0 : int.Parse(Request["IsShowQQ"]);
            int TestMethod = string.IsNullOrEmpty(Request["TestMethod"])? 0 : int.Parse(Request["TestMethod"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);
            int Publisher = string.IsNullOrEmpty(Request["Publisher"])? 0 : int.Parse(Request["Publisher"]);
            DateTime PublishDate = string.IsNullOrEmpty(Request["PublishDate"])? DateTime.Now : DateTime.Parse(Request["PublishDate"]);

            ////构建实体对象
            TrainingSubEntity entity = new TrainingSubEntity();
            entity.TID = TID;
            entity.TName = TName;
            entity.TrainingNum = TrainingNum;
            entity.TrainingLevelCode = TrainingLevelCode;
            entity.TrainingTypeCode = TrainingTypeCode;
            entity.TMethod = TMethod;
            entity.IsGP = IsGP;
            entity.OrgCode = OrgCode;
            entity.TrainingDateB = TrainingDateB;
            entity.TrainingDateE = TrainingDateE;
            entity.SignupRule = SignupRule;
            entity.ClassRule = ClassRule;
            entity.IsStage = IsStage;
            entity.TrainingUrl = TrainingUrl;
            entity.TrainingHeadImg = TrainingHeadImg;
            entity.StaticUrl = StaticUrl;
            entity.Status = Status;
            entity.AskTel = AskTel;
            entity.IsShowQQ = IsShowQQ;
            entity.TestMethod = TestMethod;
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
               result = TrainingSubBL.ModifyTrainingSub(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingSub(RH_TrainingSub)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingSubView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingSubEntity entity = new TrainingSubEntity();
            try
            {
               entity = TrainingSubBL.GatTrainingSubDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingSub(RH_TrainingSub)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingSubRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingSubBL.RemoveTrainingSub(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingSub(RH_TrainingSub)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingSubList()
        {
            //TrainingSubRH_TrainingSub
            TrainingSubEntityListResult listResult = new TrainingSubEntityListResult();

            TrainingSubSearcher Searcher = new TrainingSubSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingSubInfo> mPage = null;
            try
            {
               listResult = TrainingSubBL.GetTrainingSubEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingSubList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingSub(RH_TrainingSub)出错" + DateTime.Now + "**************************");
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