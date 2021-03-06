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
    ///RH_MngUser ( RH_MngUser ) Controller类
    ///</summary>
    public class MngUserController : Controller
    {

        /// <summary>
        /// 添加RH_MngUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int MngUserAdd()
        {
            string UserName = string.IsNullOrEmpty(Request["UserName"])? "" : Request["UserName"].ToString();
            string Password = string.IsNullOrEmpty(Request["Password"])? "" : Request["Password"].ToString();
            string TrueName = string.IsNullOrEmpty(Request["TrueName"])? "" : Request["TrueName"].ToString();
            int RoleID = string.IsNullOrEmpty(Request["RoleID"])? 0 : int.Parse(Request["RoleID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            MngUserEntity entity = new MngUserEntity();
            entity.UserName = UserName;
            entity.Password = Password;
            entity.TrueName = TrueName;
            entity.RoleID = RoleID;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = MngUserBL.AddMngUser(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加MngUser(RH_MngUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_MngUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int MngUserModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string UserName = string.IsNullOrEmpty(Request["UserName"])? "" : Request["UserName"].ToString();
            string Password = string.IsNullOrEmpty(Request["Password"])? "" : Request["Password"].ToString();
            string TrueName = string.IsNullOrEmpty(Request["TrueName"])? "" : Request["TrueName"].ToString();
            int RoleID = string.IsNullOrEmpty(Request["RoleID"])? 0 : int.Parse(Request["RoleID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            MngUserEntity entity = new MngUserEntity();
            entity.UserName = UserName;
            entity.Password = Password;
            entity.TrueName = TrueName;
            entity.RoleID = RoleID;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = MngUserBL.ModifyMngUser(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改MngUser(RH_MngUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult MngUserView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            MngUserEntity entity = new MngUserEntity();
            try
            {
               entity = MngUserBL.GatMngUserDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情MngUser(RH_MngUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int MngUserRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = MngUserBL.RemoveMngUser(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除MngUser(RH_MngUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult MngUserList()
        {
            //MngUserRH_MngUser
            MngUserEntityListResult listResult = new MngUserEntityListResult();

            MngUserSearcher Searcher = new MngUserSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<MngUserInfo> mPage = null;
            try
            {
               listResult = MngUserBL.GetMngUserEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.MngUserList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除MngUser(RH_MngUser)出错" + DateTime.Now + "**************************");
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