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
    ///RH_Design ( RH_Design ) Controller类
    ///</summary>
    public class DesignController : Controller
    {

        /// <summary>
        /// 添加RH_Design
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignAdd()
        {
            string DesignName = string.IsNullOrEmpty(Request["DesignName"])? "" : Request["DesignName"].ToString();
            string TrainingLevelCode = string.IsNullOrEmpty(Request["TrainingLevelCode"])? "" : Request["TrainingLevelCode"].ToString();
            string TrainingTypeCode = string.IsNullOrEmpty(Request["TrainingTypeCode"])? "" : Request["TrainingTypeCode"].ToString();
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            string OrgCode = string.IsNullOrEmpty(Request["OrgCode"])? "" : Request["OrgCode"].ToString();
            int TrainingNum = string.IsNullOrEmpty(Request["TrainingNum"])? 0 : int.Parse(Request["TrainingNum"]);
            int TrainingPhase = string.IsNullOrEmpty(Request["TrainingPhase"])? 0 : int.Parse(Request["TrainingPhase"]);
            DateTime TrainingDateB = string.IsNullOrEmpty(Request["TrainingDateB"])? DateTime.Now : DateTime.Parse(Request["TrainingDateB"]);
            DateTime TrainingDateE = string.IsNullOrEmpty(Request["TrainingDateE"])? DateTime.Now : DateTime.Parse(Request["TrainingDateE"]);
            string DesignDesc = string.IsNullOrEmpty(Request["DesignDesc"])? "" : Request["DesignDesc"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            DesignEntity entity = new DesignEntity();
            entity.DesignName = DesignName;
            entity.TrainingLevelCode = TrainingLevelCode;
            entity.TrainingTypeCode = TrainingTypeCode;
            entity.ProvinceID = ProvinceID;
            entity.CityID = CityID;
            entity.DistrictID = DistrictID;
            entity.OrgCode = OrgCode;
            entity.TrainingNum = TrainingNum;
            entity.TrainingPhase = TrainingPhase;
            entity.TrainingDateB = TrainingDateB;
            entity.TrainingDateE = TrainingDateE;
            entity.DesignDesc = DesignDesc;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = DesignBL.AddDesign(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Design(RH_Design)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Design
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int DesignModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string DesignName = string.IsNullOrEmpty(Request["DesignName"])? "" : Request["DesignName"].ToString();
            string TrainingLevelCode = string.IsNullOrEmpty(Request["TrainingLevelCode"])? "" : Request["TrainingLevelCode"].ToString();
            string TrainingTypeCode = string.IsNullOrEmpty(Request["TrainingTypeCode"])? "" : Request["TrainingTypeCode"].ToString();
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            string OrgCode = string.IsNullOrEmpty(Request["OrgCode"])? "" : Request["OrgCode"].ToString();
            int TrainingNum = string.IsNullOrEmpty(Request["TrainingNum"])? 0 : int.Parse(Request["TrainingNum"]);
            int TrainingPhase = string.IsNullOrEmpty(Request["TrainingPhase"])? 0 : int.Parse(Request["TrainingPhase"]);
            DateTime TrainingDateB = string.IsNullOrEmpty(Request["TrainingDateB"])? DateTime.Now : DateTime.Parse(Request["TrainingDateB"]);
            DateTime TrainingDateE = string.IsNullOrEmpty(Request["TrainingDateE"])? DateTime.Now : DateTime.Parse(Request["TrainingDateE"]);
            string DesignDesc = string.IsNullOrEmpty(Request["DesignDesc"])? "" : Request["DesignDesc"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            DesignEntity entity = new DesignEntity();
            entity.DesignName = DesignName;
            entity.TrainingLevelCode = TrainingLevelCode;
            entity.TrainingTypeCode = TrainingTypeCode;
            entity.ProvinceID = ProvinceID;
            entity.CityID = CityID;
            entity.DistrictID = DistrictID;
            entity.OrgCode = OrgCode;
            entity.TrainingNum = TrainingNum;
            entity.TrainingPhase = TrainingPhase;
            entity.TrainingDateB = TrainingDateB;
            entity.TrainingDateE = TrainingDateE;
            entity.DesignDesc = DesignDesc;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = DesignBL.ModifyDesign(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Design(RH_Design)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            DesignEntity entity = new DesignEntity();
            try
            {
               entity = DesignBL.GatDesignDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Design(RH_Design)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DesignRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = DesignBL.RemoveDesign(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Design(RH_Design)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult DesignList()
        {
            //DesignRH_Design
            DesignEntityListResult listResult = new DesignEntityListResult();

            DesignSearcher Searcher = new DesignSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<DesignInfo> mPage = null;
            try
            {
               listResult = DesignBL.GetDesignEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.DesignList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Design(RH_Design)出错" + DateTime.Now + "**************************");
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