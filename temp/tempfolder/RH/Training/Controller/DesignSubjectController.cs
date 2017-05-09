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
    ///RH_DesignSubject ( RH_DesignSubject ) Controller类
    ///</summary>
    public class DesignSubjectController : Controller
    {

        /// <summary>
        /// 添加RH_DesignSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignSubjectAdd()
        {
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignSubjectEntity entity = new DesignSubjectEntity();
            entity.DesignID = DesignID;
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = DesignSubjectBL.AddDesignSubject(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加DesignSubject(RH_DesignSubject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_DesignSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignSubjectModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            DesignSubjectEntity entity = new DesignSubjectEntity();
            entity.DesignID = DesignID;
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = DesignSubjectBL.ModifyDesignSubject(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改DesignSubject(RH_DesignSubject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignSubjectView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            DesignSubjectEntity entity = new DesignSubjectEntity();
            try
            {
               entity = DesignSubjectBL.GatDesignSubjectDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情DesignSubject(RH_DesignSubject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DesignSubjectRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = DesignSubjectBL.RemoveDesignSubject(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignSubject(RH_DesignSubject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignSubjectList()
        {
            //DesignSubjectRH_DesignSubject
            DesignSubjectEntityListResult listResult = new DesignSubjectEntityListResult();

            DesignSubjectSearcher Searcher = new DesignSubjectSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<DesignSubjectInfo> mPage = null;
            try
            {
               listResult = DesignSubjectBL.GetDesignSubjectEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.DesignSubjectList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignSubject(RH_DesignSubject)出错" + DateTime.Now + "**************************");
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