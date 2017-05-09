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
    ///RH_UserInfo ( RH_UserInfo ) Controller类
    ///</summary>
    public class UserInfoController : Controller
    {

        /// <summary>
        /// 添加RH_UserInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int UserInfoAdd()
        {
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int SchoolID = string.IsNullOrEmpty(Request["SchoolID"])? 0 : int.Parse(Request["SchoolID"]);
            string CUserName = string.IsNullOrEmpty(Request["CUserName"])? "" : Request["CUserName"].ToString();
            string CPassword = string.IsNullOrEmpty(Request["CPassword"])? "" : Request["CPassword"].ToString();
            int CSource = string.IsNullOrEmpty(Request["CSource"])? 0 : int.Parse(Request["CSource"]);

            ////构建实体对象
            UserInfoEntity entity = new UserInfoEntity();
            entity.UserID = UserID;
            entity.SchoolID = SchoolID;
            entity.CUserName = CUserName;
            entity.CPassword = CPassword;
            entity.CSource = CSource;
            int result = 0;
            try
            {
               result = UserInfoBL.AddUserInfo(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加UserInfo(RH_UserInfo)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_UserInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int UserInfoModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int SchoolID = string.IsNullOrEmpty(Request["SchoolID"])? 0 : int.Parse(Request["SchoolID"]);
            string CUserName = string.IsNullOrEmpty(Request["CUserName"])? "" : Request["CUserName"].ToString();
            string CPassword = string.IsNullOrEmpty(Request["CPassword"])? "" : Request["CPassword"].ToString();
            int CSource = string.IsNullOrEmpty(Request["CSource"])? 0 : int.Parse(Request["CSource"]);

            ////构建实体对象
            UserInfoEntity entity = new UserInfoEntity();
            entity.UserID = UserID;
            entity.SchoolID = SchoolID;
            entity.CUserName = CUserName;
            entity.CPassword = CPassword;
            entity.CSource = CSource;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = UserInfoBL.ModifyUserInfo(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改UserInfo(RH_UserInfo)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult UserInfoView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            UserInfoEntity entity = new UserInfoEntity();
            try
            {
               entity = UserInfoBL.GatUserInfoDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情UserInfo(RH_UserInfo)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int UserInfoRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = UserInfoBL.RemoveUserInfo(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除UserInfo(RH_UserInfo)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult UserInfoList()
        {
            //UserInfoRH_UserInfo
            UserInfoEntityListResult listResult = new UserInfoEntityListResult();

            UserInfoSearcher Searcher = new UserInfoSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<UserInfoInfo> mPage = null;
            try
            {
               listResult = UserInfoBL.GetUserInfoEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.UserInfoList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除UserInfo(RH_UserInfo)出错" + DateTime.Now + "**************************");
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