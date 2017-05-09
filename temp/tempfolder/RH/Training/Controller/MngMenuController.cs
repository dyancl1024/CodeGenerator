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
    ///RH_MngMenu ( RH_MngMenu ) Controller类
    ///</summary>
    public class MngMenuController : Controller
    {

        /// <summary>
        /// 添加RH_MngMenu
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int MngMenuAdd()
        {
            string MenuName = string.IsNullOrEmpty(Request["MenuName"])? "" : Request["MenuName"].ToString();
            string MenuUrl = string.IsNullOrEmpty(Request["MenuUrl"])? "" : Request["MenuUrl"].ToString();
            string MenuCode = string.IsNullOrEmpty(Request["MenuCode"])? "" : Request["MenuCode"].ToString();
            int MenuLevel = string.IsNullOrEmpty(Request["MenuLevel"])? 0 : int.Parse(Request["MenuLevel"]);
            int MenuSort = string.IsNullOrEmpty(Request["MenuSort"])? 0 : int.Parse(Request["MenuSort"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int ParentID = string.IsNullOrEmpty(Request["ParentID"])? 0 : int.Parse(Request["ParentID"]);

            ////构建实体对象
            MngMenuEntity entity = new MngMenuEntity();
            entity.MenuName = MenuName;
            entity.MenuUrl = MenuUrl;
            entity.MenuCode = MenuCode;
            entity.MenuLevel = MenuLevel;
            entity.MenuSort = MenuSort;
            entity.Status = Status;
            entity.ParentID = ParentID;
            int result = 0;
            try
            {
               result = MngMenuBL.AddMngMenu(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加MngMenu(RH_MngMenu)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_MngMenu
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int MngMenuModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string MenuName = string.IsNullOrEmpty(Request["MenuName"])? "" : Request["MenuName"].ToString();
            string MenuUrl = string.IsNullOrEmpty(Request["MenuUrl"])? "" : Request["MenuUrl"].ToString();
            string MenuCode = string.IsNullOrEmpty(Request["MenuCode"])? "" : Request["MenuCode"].ToString();
            int MenuLevel = string.IsNullOrEmpty(Request["MenuLevel"])? 0 : int.Parse(Request["MenuLevel"]);
            int MenuSort = string.IsNullOrEmpty(Request["MenuSort"])? 0 : int.Parse(Request["MenuSort"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int ParentID = string.IsNullOrEmpty(Request["ParentID"])? 0 : int.Parse(Request["ParentID"]);

            ////构建实体对象
            MngMenuEntity entity = new MngMenuEntity();
            entity.MenuName = MenuName;
            entity.MenuUrl = MenuUrl;
            entity.MenuCode = MenuCode;
            entity.MenuLevel = MenuLevel;
            entity.MenuSort = MenuSort;
            entity.Status = Status;
            entity.ParentID = ParentID;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = MngMenuBL.ModifyMngMenu(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改MngMenu(RH_MngMenu)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult MngMenuView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            MngMenuEntity entity = new MngMenuEntity();
            try
            {
               entity = MngMenuBL.GatMngMenuDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情MngMenu(RH_MngMenu)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int MngMenuRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = MngMenuBL.RemoveMngMenu(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除MngMenu(RH_MngMenu)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult MngMenuList()
        {
            //MngMenuRH_MngMenu
            MngMenuEntityListResult listResult = new MngMenuEntityListResult();

            MngMenuSearcher Searcher = new MngMenuSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<MngMenuInfo> mPage = null;
            try
            {
               listResult = MngMenuBL.GetMngMenuEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.MngMenuList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除MngMenu(RH_MngMenu)出错" + DateTime.Now + "**************************");
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