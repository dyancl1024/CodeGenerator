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
    ///RH_CoursePreset ( RH_CoursePreset ) Controller类
    ///</summary>
    public class CoursePresetController : Controller
    {

        /// <summary>
        /// 添加RH_CoursePreset
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CoursePresetAdd()
        {
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string CPDesc = string.IsNullOrEmpty(Request["CPDesc"])? "" : Request["CPDesc"].ToString();
            int IfPromote = string.IsNullOrEmpty(Request["IfPromote"])? 0 : int.Parse(Request["IfPromote"]);
            int IsRequired = string.IsNullOrEmpty(Request["IsRequired"])? 0 : int.Parse(Request["IsRequired"]);
            int CourseLevel = string.IsNullOrEmpty(Request["CourseLevel"])? 0 : int.Parse(Request["CourseLevel"]);
            int Dimension = string.IsNullOrEmpty(Request["Dimension"])? 0 : int.Parse(Request["Dimension"]);
            int Version = string.IsNullOrEmpty(Request["Version"])? 0 : int.Parse(Request["Version"]);
            int parentID = string.IsNullOrEmpty(Request["parentID"])? 0 : int.Parse(Request["parentID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            CoursePresetEntity entity = new CoursePresetEntity();
            entity.Name = Name;
            entity.CPDesc = CPDesc;
            entity.IfPromote = IfPromote;
            entity.IsRequired = IsRequired;
            entity.CourseLevel = CourseLevel;
            entity.Dimension = Dimension;
            entity.Version = Version;
            entity.parentID = parentID;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = CoursePresetBL.AddCoursePreset(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加CoursePreset(RH_CoursePreset)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_CoursePreset
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int CoursePresetModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string Name = string.IsNullOrEmpty(Request["Name"])? "" : Request["Name"].ToString();
            string CPDesc = string.IsNullOrEmpty(Request["CPDesc"])? "" : Request["CPDesc"].ToString();
            int IfPromote = string.IsNullOrEmpty(Request["IfPromote"])? 0 : int.Parse(Request["IfPromote"]);
            int IsRequired = string.IsNullOrEmpty(Request["IsRequired"])? 0 : int.Parse(Request["IsRequired"]);
            int CourseLevel = string.IsNullOrEmpty(Request["CourseLevel"])? 0 : int.Parse(Request["CourseLevel"]);
            int Dimension = string.IsNullOrEmpty(Request["Dimension"])? 0 : int.Parse(Request["Dimension"]);
            int Version = string.IsNullOrEmpty(Request["Version"])? 0 : int.Parse(Request["Version"]);
            int parentID = string.IsNullOrEmpty(Request["parentID"])? 0 : int.Parse(Request["parentID"]);
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            CoursePresetEntity entity = new CoursePresetEntity();
            entity.Name = Name;
            entity.CPDesc = CPDesc;
            entity.IfPromote = IfPromote;
            entity.IsRequired = IsRequired;
            entity.CourseLevel = CourseLevel;
            entity.Dimension = Dimension;
            entity.Version = Version;
            entity.parentID = parentID;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = CoursePresetBL.ModifyCoursePreset(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改CoursePreset(RH_CoursePreset)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CoursePresetView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            CoursePresetEntity entity = new CoursePresetEntity();
            try
            {
               entity = CoursePresetBL.GatCoursePresetDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情CoursePreset(RH_CoursePreset)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int CoursePresetRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = CoursePresetBL.RemoveCoursePreset(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CoursePreset(RH_CoursePreset)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult CoursePresetList()
        {
            //CoursePresetRH_CoursePreset
            CoursePresetEntityListResult listResult = new CoursePresetEntityListResult();

            CoursePresetSearcher Searcher = new CoursePresetSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<CoursePresetInfo> mPage = null;
            try
            {
               listResult = CoursePresetBL.GetCoursePresetEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.CoursePresetList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除CoursePreset(RH_CoursePreset)出错" + DateTime.Now + "**************************");
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