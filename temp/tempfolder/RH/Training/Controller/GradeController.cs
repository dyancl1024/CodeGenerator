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
    ///RH_Grade ( RH_Grade ) Controller类
    ///</summary>
    public class GradeController : Controller
    {

        /// <summary>
        /// 添加RH_Grade
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int GradeAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int ParentID = string.IsNullOrEmpty(Request["ParentID"])? 0 : int.Parse(Request["ParentID"]);

            ////构建实体对象
            GradeEntity entity = new GradeEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.ParentID = ParentID;
            int result = 0;
            try
            {
               result = GradeBL.AddGrade(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Grade(RH_Grade)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Grade
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int GradeModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int ParentID = string.IsNullOrEmpty(Request["ParentID"])? 0 : int.Parse(Request["ParentID"]);

            ////构建实体对象
            GradeEntity entity = new GradeEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.ParentID = ParentID;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = GradeBL.ModifyGrade(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Grade(RH_Grade)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult GradeView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            GradeEntity entity = new GradeEntity();
            try
            {
               entity = GradeBL.GatGradeDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Grade(RH_Grade)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int GradeRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = GradeBL.RemoveGrade(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Grade(RH_Grade)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult GradeList()
        {
            //GradeRH_Grade
            GradeEntityListResult listResult = new GradeEntityListResult();

            GradeSearcher Searcher = new GradeSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<GradeInfo> mPage = null;
            try
            {
               listResult = GradeBL.GetGradeEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.GradeList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Grade(RH_Grade)出错" + DateTime.Now + "**************************");
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