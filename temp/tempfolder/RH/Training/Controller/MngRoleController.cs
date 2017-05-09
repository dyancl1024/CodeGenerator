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
    ///RH_MngRole ( RH_MngRole ) Controller类
    ///</summary>
    public class MngRoleController : Controller
    {

        /// <summary>
        /// 添加RH_MngRole
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int MngRoleAdd()
        {
            string RoleName = string.IsNullOrEmpty(Request["RoleName"])? "" : Request["RoleName"].ToString();
            string RoleCode = string.IsNullOrEmpty(Request["RoleCode"])? "" : Request["RoleCode"].ToString();
            int SortNum = string.IsNullOrEmpty(Request["SortNum"])? 0 : int.Parse(Request["SortNum"]);

            ////构建实体对象
            MngRoleEntity entity = new MngRoleEntity();
            entity.RoleName = RoleName;
            entity.RoleCode = RoleCode;
            entity.SortNum = SortNum;
            int result = 0;
            try
            {
               result = MngRoleBL.AddMngRole(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加MngRole(RH_MngRole)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_MngRole
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int MngRoleModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string RoleName = string.IsNullOrEmpty(Request["RoleName"])? "" : Request["RoleName"].ToString();
            string RoleCode = string.IsNullOrEmpty(Request["RoleCode"])? "" : Request["RoleCode"].ToString();
            int SortNum = string.IsNullOrEmpty(Request["SortNum"])? 0 : int.Parse(Request["SortNum"]);

            ////构建实体对象
            MngRoleEntity entity = new MngRoleEntity();
            entity.RoleName = RoleName;
            entity.RoleCode = RoleCode;
            entity.SortNum = SortNum;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = MngRoleBL.ModifyMngRole(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改MngRole(RH_MngRole)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult MngRoleView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            MngRoleEntity entity = new MngRoleEntity();
            try
            {
               entity = MngRoleBL.GatMngRoleDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情MngRole(RH_MngRole)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int MngRoleRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = MngRoleBL.RemoveMngRole(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除MngRole(RH_MngRole)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult MngRoleList()
        {
            //MngRoleRH_MngRole
            MngRoleEntityListResult listResult = new MngRoleEntityListResult();

            MngRoleSearcher Searcher = new MngRoleSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<MngRoleInfo> mPage = null;
            try
            {
               listResult = MngRoleBL.GetMngRoleEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.MngRoleList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除MngRole(RH_MngRole)出错" + DateTime.Now + "**************************");
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