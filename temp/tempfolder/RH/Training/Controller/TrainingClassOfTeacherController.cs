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
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) Controller类
    ///</summary>
    public class TrainingClassOfTeacherController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingClassOfTeacherAdd()
        {
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int ClassID = string.IsNullOrEmpty(Request["ClassID"])? 0 : int.Parse(Request["ClassID"]);
            int TeacherID = string.IsNullOrEmpty(Request["TeacherID"])? 0 : int.Parse(Request["TeacherID"]);
            int Appointer = string.IsNullOrEmpty(Request["Appointer"])? 0 : int.Parse(Request["Appointer"]);
            DateTime AppointTime = string.IsNullOrEmpty(Request["AppointTime"])? DateTime.Now : DateTime.Parse(Request["AppointTime"]);

            ////构建实体对象
            TrainingClassOfTeacherEntity entity = new TrainingClassOfTeacherEntity();
            entity.SubTID = SubTID;
            entity.ClassID = ClassID;
            entity.TeacherID = TeacherID;
            entity.Appointer = Appointer;
            entity.AppointTime = AppointTime;
            int result = 0;
            try
            {
               result = TrainingClassOfTeacherBL.AddTrainingClassOfTeacher(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingClassOfTeacher(RH_TrainingClassOfTeacher)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingClassOfTeacherModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int ClassID = string.IsNullOrEmpty(Request["ClassID"])? 0 : int.Parse(Request["ClassID"]);
            int TeacherID = string.IsNullOrEmpty(Request["TeacherID"])? 0 : int.Parse(Request["TeacherID"]);
            int Appointer = string.IsNullOrEmpty(Request["Appointer"])? 0 : int.Parse(Request["Appointer"]);
            DateTime AppointTime = string.IsNullOrEmpty(Request["AppointTime"])? DateTime.Now : DateTime.Parse(Request["AppointTime"]);

            ////构建实体对象
            TrainingClassOfTeacherEntity entity = new TrainingClassOfTeacherEntity();
            entity.SubTID = SubTID;
            entity.ClassID = ClassID;
            entity.TeacherID = TeacherID;
            entity.Appointer = Appointer;
            entity.AppointTime = AppointTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingClassOfTeacherBL.ModifyTrainingClassOfTeacher(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingClassOfTeacher(RH_TrainingClassOfTeacher)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingClassOfTeacherView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingClassOfTeacherEntity entity = new TrainingClassOfTeacherEntity();
            try
            {
               entity = TrainingClassOfTeacherBL.GatTrainingClassOfTeacherDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingClassOfTeacher(RH_TrainingClassOfTeacher)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingClassOfTeacherRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingClassOfTeacherBL.RemoveTrainingClassOfTeacher(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingClassOfTeacher(RH_TrainingClassOfTeacher)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingClassOfTeacherList()
        {
            //TrainingClassOfTeacherRH_TrainingClassOfTeacher
            TrainingClassOfTeacherEntityListResult listResult = new TrainingClassOfTeacherEntityListResult();

            TrainingClassOfTeacherSearcher Searcher = new TrainingClassOfTeacherSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingClassOfTeacherInfo> mPage = null;
            try
            {
               listResult = TrainingClassOfTeacherBL.GetTrainingClassOfTeacherEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingClassOfTeacherList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingClassOfTeacher(RH_TrainingClassOfTeacher)出错" + DateTime.Now + "**************************");
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