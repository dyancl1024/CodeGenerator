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
    ///RH_Postion ( RH_Postion ) Controller类
    ///</summary>
    public class PostionController : Controller
    {

        /// <summary>
        /// 添加RH_Postion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int PostionAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            PostionEntity entity = new PostionEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            int result = 0;
            try
            {
               result = PostionBL.AddPostion(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Postion(RH_Postion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Postion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int PostionModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string Code = string.IsNullOrEmpty(Request["Code"])? "" : Request["Code"].ToString();
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);

            ////构建实体对象
            PostionEntity entity = new PostionEntity();
            entity.Name = Name;
            entity.Code = Code;
            entity.Sort = Sort;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = PostionBL.ModifyPostion(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Postion(RH_Postion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult PostionView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            PostionEntity entity = new PostionEntity();
            try
            {
               entity = PostionBL.GatPostionDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Postion(RH_Postion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int PostionRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = PostionBL.RemovePostion(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Postion(RH_Postion)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult PostionList()
        {
            //PostionRH_Postion
            PostionEntityListResult listResult = new PostionEntityListResult();

            PostionSearcher Searcher = new PostionSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<PostionInfo> mPage = null;
            try
            {
               listResult = PostionBL.GetPostionEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.PostionList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Postion(RH_Postion)出错" + DateTime.Now + "**************************");
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