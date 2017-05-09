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
    ///RH_TrainingLevel ( RH_TrainingLevel ) Controller类
    ///</summary>
    public class TrainingLevelController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingLevel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingLevelAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            TrainingLevelEntity entity = new TrainingLevelEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            int result = 0;
            try
            {
               result = TrainingLevelBL.AddTrainingLevel(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingLevel(RH_TrainingLevel)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingLevel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingLevelModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            TrainingLevelEntity entity = new TrainingLevelEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingLevelBL.ModifyTrainingLevel(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingLevel(RH_TrainingLevel)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingLevel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingLevelView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingLevelEntity entity = new TrainingLevelEntity();
            try
            {
               entity = TrainingLevelBL.GatTrainingLevelDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingLevel(RH_TrainingLevel)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingLevel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingLevelRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingLevelBL.RemoveTrainingLevel(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingLevel(RH_TrainingLevel)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingLevel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingLevelList()
        {
            //TrainingLevelRH_TrainingLevel
            TrainingLevelEntityListResult listResult = new TrainingLevelEntityListResult();

            TrainingLevelSearcher Searcher = new TrainingLevelSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingLevelInfo> mPage = null;
            try
            {
               listResult = TrainingLevelBL.GetTrainingLevelEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingLevelList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingLevel(RH_TrainingLevel)出错" + DateTime.Now + "**************************");
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