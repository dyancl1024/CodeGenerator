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
    ///RH_TrainingCourse ( RH_TrainingCourse ) Controller类
    ///</summary>
    public class TrainingCourseController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingCourseAdd()
        {
            int PresetID = string.IsNullOrEmpty(Request["PresetID"])? 0 : int.Parse(Request["PresetID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            int IfRequired = string.IsNullOrEmpty(Request["IfRequired"])? 0 : int.Parse(Request["IfRequired"]);
            int CPharse = string.IsNullOrEmpty(Request["CPharse"])? 0 : int.Parse(Request["CPharse"]);
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingCourseEntity entity = new TrainingCourseEntity();
            entity.PresetID = PresetID;
            entity.SubTID = SubTID;
            entity.CourseID = CourseID;
            entity.IfRequired = IfRequired;
            entity.CPharse = CPharse;
            entity.Sort = Sort;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingCourseBL.AddTrainingCourse(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingCourse(RH_TrainingCourse)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingCourseModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int PresetID = string.IsNullOrEmpty(Request["PresetID"])? 0 : int.Parse(Request["PresetID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int CourseID = string.IsNullOrEmpty(Request["CourseID"])? 0 : int.Parse(Request["CourseID"]);
            int IfRequired = string.IsNullOrEmpty(Request["IfRequired"])? 0 : int.Parse(Request["IfRequired"]);
            int CPharse = string.IsNullOrEmpty(Request["CPharse"])? 0 : int.Parse(Request["CPharse"]);
            int Sort = string.IsNullOrEmpty(Request["Sort"])? 0 : int.Parse(Request["Sort"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingCourseEntity entity = new TrainingCourseEntity();
            entity.PresetID = PresetID;
            entity.SubTID = SubTID;
            entity.CourseID = CourseID;
            entity.IfRequired = IfRequired;
            entity.CPharse = CPharse;
            entity.Sort = Sort;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingCourseBL.ModifyTrainingCourse(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingCourse(RH_TrainingCourse)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingCourseView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingCourseEntity entity = new TrainingCourseEntity();
            try
            {
               entity = TrainingCourseBL.GatTrainingCourseDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingCourse(RH_TrainingCourse)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingCourseRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingCourseBL.RemoveTrainingCourse(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingCourse(RH_TrainingCourse)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingCourseList()
        {
            //TrainingCourseRH_TrainingCourse
            TrainingCourseEntityListResult listResult = new TrainingCourseEntityListResult();

            TrainingCourseSearcher Searcher = new TrainingCourseSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingCourseInfo> mPage = null;
            try
            {
               listResult = TrainingCourseBL.GetTrainingCourseEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingCourseList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingCourse(RH_TrainingCourse)出错" + DateTime.Now + "**************************");
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