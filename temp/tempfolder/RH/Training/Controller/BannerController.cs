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
    ///RH_Banner ( RH_Banner ) Controller类
    ///</summary>
    public class BannerController : Controller
    {

        /// <summary>
        /// 添加RH_Banner
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int BannerAdd()
        {
            string ADTitle = string.IsNullOrEmpty(Request["ADTitle"])? "" : Request["ADTitle"].ToString();
            string AreaCode = string.IsNullOrEmpty(Request["AreaCode"])? "" : Request["AreaCode"].ToString();
            string ADPhotoUrl = string.IsNullOrEmpty(Request["ADPhotoUrl"])? "" : Request["ADPhotoUrl"].ToString();
            int ADContentType = string.IsNullOrEmpty(Request["ADContentType"])? 0 : int.Parse(Request["ADContentType"]);
            string ADContentURL = string.IsNullOrEmpty(Request["ADContentURL"])? "" : Request["ADContentURL"].ToString();
            string ADContent = string.IsNullOrEmpty(Request["ADContent"])? "" : Request["ADContent"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            BannerEntity entity = new BannerEntity();
            entity.ADTitle = ADTitle;
            entity.AreaCode = AreaCode;
            entity.ADPhotoUrl = ADPhotoUrl;
            entity.ADContentType = ADContentType;
            entity.ADContentURL = ADContentURL;
            entity.ADContent = ADContent;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = BannerBL.AddBanner(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Banner(RH_Banner)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Banner
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int BannerModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string ADTitle = string.IsNullOrEmpty(Request["ADTitle"])? "" : Request["ADTitle"].ToString();
            string AreaCode = string.IsNullOrEmpty(Request["AreaCode"])? "" : Request["AreaCode"].ToString();
            string ADPhotoUrl = string.IsNullOrEmpty(Request["ADPhotoUrl"])? "" : Request["ADPhotoUrl"].ToString();
            int ADContentType = string.IsNullOrEmpty(Request["ADContentType"])? 0 : int.Parse(Request["ADContentType"]);
            string ADContentURL = string.IsNullOrEmpty(Request["ADContentURL"])? "" : Request["ADContentURL"].ToString();
            string ADContent = string.IsNullOrEmpty(Request["ADContent"])? "" : Request["ADContent"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            BannerEntity entity = new BannerEntity();
            entity.ADTitle = ADTitle;
            entity.AreaCode = AreaCode;
            entity.ADPhotoUrl = ADPhotoUrl;
            entity.ADContentType = ADContentType;
            entity.ADContentURL = ADContentURL;
            entity.ADContent = ADContent;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = BannerBL.ModifyBanner(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Banner(RH_Banner)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult BannerView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            BannerEntity entity = new BannerEntity();
            try
            {
               entity = BannerBL.GatBannerDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Banner(RH_Banner)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int BannerRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = BannerBL.RemoveBanner(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Banner(RH_Banner)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult BannerList()
        {
            //BannerRH_Banner
            BannerEntityListResult listResult = new BannerEntityListResult();

            BannerSearcher Searcher = new BannerSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<BannerInfo> mPage = null;
            try
            {
               listResult = BannerBL.GetBannerEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.BannerList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Banner(RH_Banner)出错" + DateTime.Now + "**************************");
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