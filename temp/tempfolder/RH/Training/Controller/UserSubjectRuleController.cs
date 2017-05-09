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
    ///RH_UserSubjectRule ( RH_UserSubjectRule ) Controller类
    ///</summary>
    public class UserSubjectRuleController : Controller
    {

        /// <summary>
        /// 添加RH_UserSubjectRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int UserSubjectRuleAdd()
        {
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);

            ////构建实体对象
            UserSubjectRuleEntity entity = new UserSubjectRuleEntity();
            entity.UserID = UserID;
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.TID = TID;
            int result = 0;
            try
            {
               result = UserSubjectRuleBL.AddUserSubjectRule(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加UserSubjectRule(RH_UserSubjectRule)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_UserSubjectRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int UserSubjectRuleModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            int TID = string.IsNullOrEmpty(Request["TID"])? 0 : int.Parse(Request["TID"]);

            ////构建实体对象
            UserSubjectRuleEntity entity = new UserSubjectRuleEntity();
            entity.UserID = UserID;
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.TID = TID;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = UserSubjectRuleBL.ModifyUserSubjectRule(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改UserSubjectRule(RH_UserSubjectRule)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult UserSubjectRuleView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            UserSubjectRuleEntity entity = new UserSubjectRuleEntity();
            try
            {
               entity = UserSubjectRuleBL.GatUserSubjectRuleDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情UserSubjectRule(RH_UserSubjectRule)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int UserSubjectRuleRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = UserSubjectRuleBL.RemoveUserSubjectRule(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除UserSubjectRule(RH_UserSubjectRule)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_UserSubjectRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult UserSubjectRuleList()
        {
            //UserSubjectRuleRH_UserSubjectRule
            UserSubjectRuleEntityListResult listResult = new UserSubjectRuleEntityListResult();

            UserSubjectRuleSearcher Searcher = new UserSubjectRuleSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<UserSubjectRuleInfo> mPage = null;
            try
            {
               listResult = UserSubjectRuleBL.GetUserSubjectRuleEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.UserSubjectRuleList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除UserSubjectRule(RH_UserSubjectRule)出错" + DateTime.Now + "**************************");
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