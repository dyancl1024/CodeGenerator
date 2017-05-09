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
    ///RH_TrainingDynamic ( RH_TrainingDynamic ) Controller类
    ///</summary>
    public class TrainingDynamicController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingDynamic
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingDynamicAdd()
        {
            int ObjectID = string.IsNullOrEmpty(Request["ObjectID"])? 0 : int.Parse(Request["ObjectID"]);
            int MType = string.IsNullOrEmpty(Request["MType"])? 0 : int.Parse(Request["MType"]);
            string DyTitle = string.IsNullOrEmpty(Request["DyTitle"])? "" : Request["DyTitle"].ToString();
            int DyType = string.IsNullOrEmpty(Request["DyType"])? 0 : int.Parse(Request["DyType"]);
            string DyContent = string.IsNullOrEmpty(Request["DyContent"])? "" : Request["DyContent"].ToString();
            string DyLink = string.IsNullOrEmpty(Request["DyLink"])? "" : Request["DyLink"].ToString();
            string DyPicUrl = string.IsNullOrEmpty(Request["DyPicUrl"])? "" : Request["DyPicUrl"].ToString();
            int DState = string.IsNullOrEmpty(Request["DState"])? 0 : int.Parse(Request["DState"]);
            int CilckNum = string.IsNullOrEmpty(Request["CilckNum"])? 0 : int.Parse(Request["CilckNum"]);
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingDynamicEntity entity = new TrainingDynamicEntity();
            entity.ObjectID = ObjectID;
            entity.MType = MType;
            entity.DyTitle = DyTitle;
            entity.DyType = DyType;
            entity.DyContent = DyContent;
            entity.DyLink = DyLink;
            entity.DyPicUrl = DyPicUrl;
            entity.DState = DState;
            entity.CilckNum = CilckNum;
            entity.StaticUrl = StaticUrl;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingDynamicBL.AddTrainingDynamic(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingDynamic(RH_TrainingDynamic)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingDynamic
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingDynamicModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int ObjectID = string.IsNullOrEmpty(Request["ObjectID"])? 0 : int.Parse(Request["ObjectID"]);
            int MType = string.IsNullOrEmpty(Request["MType"])? 0 : int.Parse(Request["MType"]);
            string DyTitle = string.IsNullOrEmpty(Request["DyTitle"])? "" : Request["DyTitle"].ToString();
            int DyType = string.IsNullOrEmpty(Request["DyType"])? 0 : int.Parse(Request["DyType"]);
            string DyContent = string.IsNullOrEmpty(Request["DyContent"])? "" : Request["DyContent"].ToString();
            string DyLink = string.IsNullOrEmpty(Request["DyLink"])? "" : Request["DyLink"].ToString();
            string DyPicUrl = string.IsNullOrEmpty(Request["DyPicUrl"])? "" : Request["DyPicUrl"].ToString();
            int DState = string.IsNullOrEmpty(Request["DState"])? 0 : int.Parse(Request["DState"]);
            int CilckNum = string.IsNullOrEmpty(Request["CilckNum"])? 0 : int.Parse(Request["CilckNum"]);
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingDynamicEntity entity = new TrainingDynamicEntity();
            entity.ObjectID = ObjectID;
            entity.MType = MType;
            entity.DyTitle = DyTitle;
            entity.DyType = DyType;
            entity.DyContent = DyContent;
            entity.DyLink = DyLink;
            entity.DyPicUrl = DyPicUrl;
            entity.DState = DState;
            entity.CilckNum = CilckNum;
            entity.StaticUrl = StaticUrl;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingDynamicBL.ModifyTrainingDynamic(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingDynamic(RH_TrainingDynamic)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingDynamic
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingDynamicView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingDynamicEntity entity = new TrainingDynamicEntity();
            try
            {
               entity = TrainingDynamicBL.GatTrainingDynamicDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingDynamic(RH_TrainingDynamic)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingDynamic
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingDynamicRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingDynamicBL.RemoveTrainingDynamic(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingDynamic(RH_TrainingDynamic)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingDynamic
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingDynamicList()
        {
            //TrainingDynamicRH_TrainingDynamic
            TrainingDynamicEntityListResult listResult = new TrainingDynamicEntityListResult();

            TrainingDynamicSearcher Searcher = new TrainingDynamicSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingDynamicInfo> mPage = null;
            try
            {
               listResult = TrainingDynamicBL.GetTrainingDynamicEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingDynamicList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingDynamic(RH_TrainingDynamic)出错" + DateTime.Now + "**************************");
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