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
    ///RH_MngRoleRight ( RH_MngRoleRight ) Controller类
    ///</summary>
    public class MngRoleRightController : Controller
    {

        /// <summary>
        /// 添加RH_MngRoleRight
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int MngRoleRightAdd()
        {
            string RoleCode = string.IsNullOrEmpty(Request["RoleCode"])? "" : Request["RoleCode"].ToString();
            string MenuCode = string.IsNullOrEmpty(Request["MenuCode"])? "" : Request["MenuCode"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            MngRoleRightEntity entity = new MngRoleRightEntity();
            entity.RoleCode = RoleCode;
            entity.MenuCode = MenuCode;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            int result = 0;
            try
            {
               result = MngRoleRightBL.AddMngRoleRight(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加MngRoleRight(RH_MngRoleRight)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_MngRoleRight
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int MngRoleRightModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string RoleCode = string.IsNullOrEmpty(Request["RoleCode"])? "" : Request["RoleCode"].ToString();
            string MenuCode = string.IsNullOrEmpty(Request["MenuCode"])? "" : Request["MenuCode"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);

            ////构建实体对象
            MngRoleRightEntity entity = new MngRoleRightEntity();
            entity.RoleCode = RoleCode;
            entity.MenuCode = MenuCode;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = MngRoleRightBL.ModifyMngRoleRight(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改MngRoleRight(RH_MngRoleRight)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult MngRoleRightView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            MngRoleRightEntity entity = new MngRoleRightEntity();
            try
            {
               entity = MngRoleRightBL.GatMngRoleRightDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情MngRoleRight(RH_MngRoleRight)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int MngRoleRightRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = MngRoleRightBL.RemoveMngRoleRight(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除MngRoleRight(RH_MngRoleRight)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult MngRoleRightList()
        {
            //MngRoleRightRH_MngRoleRight
            MngRoleRightEntityListResult listResult = new MngRoleRightEntityListResult();

            MngRoleRightSearcher Searcher = new MngRoleRightSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<MngRoleRightInfo> mPage = null;
            try
            {
               listResult = MngRoleRightBL.GetMngRoleRightEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.MngRoleRightList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除MngRoleRight(RH_MngRoleRight)出错" + DateTime.Now + "**************************");
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