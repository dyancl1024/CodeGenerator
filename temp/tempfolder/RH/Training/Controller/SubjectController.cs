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
    ///RH_Subject ( RH_Subject ) Controller类
    ///</summary>
    public class SubjectController : Controller
    {

        /// <summary>
        /// 添加RH_Subject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int SubjectAdd()
        {
            string SubjectName = string.IsNullOrEmpty(Request["SubjectName"])? "" : Request["SubjectName"].ToString();
            string SubCode = string.IsNullOrEmpty(Request["SubCode"])? "" : Request["SubCode"].ToString();
            string SubjectSort = string.IsNullOrEmpty(Request["SubjectSort"])? "" : Request["SubjectSort"].ToString();

            ////构建实体对象
            SubjectEntity entity = new SubjectEntity();
            entity.SubjectName = SubjectName;
            entity.SubCode = SubCode;
            entity.SubjectSort = SubjectSort;
            int result = 0;
            try
            {
               result = SubjectBL.AddSubject(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Subject(RH_Subject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Subject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int SubjectModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string SubjectName = string.IsNullOrEmpty(Request["SubjectName"])? "" : Request["SubjectName"].ToString();
            string SubCode = string.IsNullOrEmpty(Request["SubCode"])? "" : Request["SubCode"].ToString();
            string SubjectSort = string.IsNullOrEmpty(Request["SubjectSort"])? "" : Request["SubjectSort"].ToString();

            ////构建实体对象
            SubjectEntity entity = new SubjectEntity();
            entity.SubjectName = SubjectName;
            entity.SubCode = SubCode;
            entity.SubjectSort = SubjectSort;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = SubjectBL.ModifySubject(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Subject(RH_Subject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult SubjectView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            SubjectEntity entity = new SubjectEntity();
            try
            {
               entity = SubjectBL.GatSubjectDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Subject(RH_Subject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int SubjectRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = SubjectBL.RemoveSubject(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Subject(RH_Subject)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult SubjectList()
        {
            //SubjectRH_Subject
            SubjectEntityListResult listResult = new SubjectEntityListResult();

            SubjectSearcher Searcher = new SubjectSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<SubjectInfo> mPage = null;
            try
            {
               listResult = SubjectBL.GetSubjectEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.SubjectList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Subject(RH_Subject)出错" + DateTime.Now + "**************************");
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