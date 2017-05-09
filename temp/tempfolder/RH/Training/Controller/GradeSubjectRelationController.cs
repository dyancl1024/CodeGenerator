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
    ///RH_GradeSubjectRelation ( RH_GradeSubjectRelation ) Controller类
    ///</summary>
    public class GradeSubjectRelationController : Controller
    {

        /// <summary>
        /// 添加RH_GradeSubjectRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int GradeSubjectRelationAdd()
        {
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();

            ////构建实体对象
            GradeSubjectRelationEntity entity = new GradeSubjectRelationEntity();
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            int result = 0;
            try
            {
               result = GradeSubjectRelationBL.AddGradeSubjectRelation(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加GradeSubjectRelation(RH_GradeSubjectRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_GradeSubjectRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int GradeSubjectRelationModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();

            ////构建实体对象
            GradeSubjectRelationEntity entity = new GradeSubjectRelationEntity();
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = GradeSubjectRelationBL.ModifyGradeSubjectRelation(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改GradeSubjectRelation(RH_GradeSubjectRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult GradeSubjectRelationView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            GradeSubjectRelationEntity entity = new GradeSubjectRelationEntity();
            try
            {
               entity = GradeSubjectRelationBL.GatGradeSubjectRelationDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情GradeSubjectRelation(RH_GradeSubjectRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int GradeSubjectRelationRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = GradeSubjectRelationBL.RemoveGradeSubjectRelation(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除GradeSubjectRelation(RH_GradeSubjectRelation)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult GradeSubjectRelationList()
        {
            //GradeSubjectRelationRH_GradeSubjectRelation
            GradeSubjectRelationEntityListResult listResult = new GradeSubjectRelationEntityListResult();

            GradeSubjectRelationSearcher Searcher = new GradeSubjectRelationSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<GradeSubjectRelationInfo> mPage = null;
            try
            {
               listResult = GradeSubjectRelationBL.GetGradeSubjectRelationEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.GradeSubjectRelationList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除GradeSubjectRelation(RH_GradeSubjectRelation)出错" + DateTime.Now + "**************************");
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