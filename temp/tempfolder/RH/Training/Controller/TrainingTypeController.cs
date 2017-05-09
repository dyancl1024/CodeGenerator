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
    ///RH_TrainingType ( RH_TrainingType ) Controller类
    ///</summary>
    public class TrainingTypeController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingTypeAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            TrainingTypeEntity entity = new TrainingTypeEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            int result = 0;
            try
            {
               result = TrainingTypeBL.AddTrainingType(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingType(RH_TrainingType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingTypeModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            TrainingTypeEntity entity = new TrainingTypeEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingTypeBL.ModifyTrainingType(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingType(RH_TrainingType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingTypeView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingTypeEntity entity = new TrainingTypeEntity();
            try
            {
               entity = TrainingTypeBL.GatTrainingTypeDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingType(RH_TrainingType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingTypeRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingTypeBL.RemoveTrainingType(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingType(RH_TrainingType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingTypeList()
        {
            //TrainingTypeRH_TrainingType
            TrainingTypeEntityListResult listResult = new TrainingTypeEntityListResult();

            TrainingTypeSearcher Searcher = new TrainingTypeSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingTypeInfo> mPage = null;
            try
            {
               listResult = TrainingTypeBL.GetTrainingTypeEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingTypeList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingType(RH_TrainingType)出错" + DateTime.Now + "**************************");
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