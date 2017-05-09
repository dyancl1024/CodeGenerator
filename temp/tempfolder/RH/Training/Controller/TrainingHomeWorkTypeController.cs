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
    ///RH_TrainingHomeWorkType ( RH_TrainingHomeWorkType ) Controller类
    ///</summary>
    public class TrainingHomeWorkTypeController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingHomeWorkTypeAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            TrainingHomeWorkTypeEntity entity = new TrainingHomeWorkTypeEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            int result = 0;
            try
            {
               result = TrainingHomeWorkTypeBL.AddTrainingHomeWorkType(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingHomeWorkType(RH_TrainingHomeWorkType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingHomeWorkTypeModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            TrainingHomeWorkTypeEntity entity = new TrainingHomeWorkTypeEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingHomeWorkTypeBL.ModifyTrainingHomeWorkType(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingHomeWorkType(RH_TrainingHomeWorkType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingHomeWorkTypeView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingHomeWorkTypeEntity entity = new TrainingHomeWorkTypeEntity();
            try
            {
               entity = TrainingHomeWorkTypeBL.GatTrainingHomeWorkTypeDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingHomeWorkType(RH_TrainingHomeWorkType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingHomeWorkTypeRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingHomeWorkTypeBL.RemoveTrainingHomeWorkType(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingHomeWorkType(RH_TrainingHomeWorkType)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingHomeWorkTypeList()
        {
            //TrainingHomeWorkTypeRH_TrainingHomeWorkType
            TrainingHomeWorkTypeEntityListResult listResult = new TrainingHomeWorkTypeEntityListResult();

            TrainingHomeWorkTypeSearcher Searcher = new TrainingHomeWorkTypeSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingHomeWorkTypeInfo> mPage = null;
            try
            {
               listResult = TrainingHomeWorkTypeBL.GetTrainingHomeWorkTypeEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingHomeWorkTypeList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingHomeWorkType(RH_TrainingHomeWorkType)出错" + DateTime.Now + "**************************");
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