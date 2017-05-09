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
    ///RH_DesignContent ( RH_DesignContent ) Controller类
    ///</summary>
    public class DesignContentController : Controller
    {

        /// <summary>
        /// 添加RH_DesignContent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignContentAdd()
        {
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            int DType = string.IsNullOrEmpty(Request["DType"])? 0 : int.Parse(Request["DType"]);
            string DName = string.IsNullOrEmpty(Request["DName"])? "" : Request["DName"].ToString();
            string DContent = string.IsNullOrEmpty(Request["DContent"])? "" : Request["DContent"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            DesignContentEntity entity = new DesignContentEntity();
            entity.DesignID = DesignID;
            entity.DType = DType;
            entity.DName = DName;
            entity.DContent = DContent;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = DesignContentBL.AddDesignContent(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加DesignContent(RH_DesignContent)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_DesignContent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignContentModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int DesignID = string.IsNullOrEmpty(Request["DesignID"])? 0 : int.Parse(Request["DesignID"]);
            int DType = string.IsNullOrEmpty(Request["DType"])? 0 : int.Parse(Request["DType"]);
            string DName = string.IsNullOrEmpty(Request["DName"])? "" : Request["DName"].ToString();
            string DContent = string.IsNullOrEmpty(Request["DContent"])? "" : Request["DContent"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            DesignContentEntity entity = new DesignContentEntity();
            entity.DesignID = DesignID;
            entity.DType = DType;
            entity.DName = DName;
            entity.DContent = DContent;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = DesignContentBL.ModifyDesignContent(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改DesignContent(RH_DesignContent)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignContentView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            DesignContentEntity entity = new DesignContentEntity();
            try
            {
               entity = DesignContentBL.GatDesignContentDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情DesignContent(RH_DesignContent)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DesignContentRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = DesignContentBL.RemoveDesignContent(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignContent(RH_DesignContent)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignContentList()
        {
            //DesignContentRH_DesignContent
            DesignContentEntityListResult listResult = new DesignContentEntityListResult();

            DesignContentSearcher Searcher = new DesignContentSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<DesignContentInfo> mPage = null;
            try
            {
               listResult = DesignContentBL.GetDesignContentEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.DesignContentList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除DesignContent(RH_DesignContent)出错" + DateTime.Now + "**************************");
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