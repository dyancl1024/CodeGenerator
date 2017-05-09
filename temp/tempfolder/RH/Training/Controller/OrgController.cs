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
    ///RH_Org ( RH_Org ) Controller类
    ///</summary>
    public class OrgController : Controller
    {

        /// <summary>
        /// 添加RH_Org
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int OrgAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            OrgEntity entity = new OrgEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.Status = Status;
            int result = 0;
            try
            {
               result = OrgBL.AddOrg(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Org(RH_Org)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Org
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int OrgModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);

            ////构建实体对象
            OrgEntity entity = new OrgEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.Status = Status;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = OrgBL.ModifyOrg(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Org(RH_Org)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult OrgView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            OrgEntity entity = new OrgEntity();
            try
            {
               entity = OrgBL.GatOrgDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Org(RH_Org)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int OrgRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = OrgBL.RemoveOrg(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Org(RH_Org)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult OrgList()
        {
            //OrgRH_Org
            OrgEntityListResult listResult = new OrgEntityListResult();

            OrgSearcher Searcher = new OrgSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<OrgInfo> mPage = null;
            try
            {
               listResult = OrgBL.GetOrgEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.OrgList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Org(RH_Org)出错" + DateTime.Now + "**************************");
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