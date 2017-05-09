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
    ///RH_Temp_BasicData_TrainingSub ( RH_Temp_BasicData_TrainingSub ) Controller类
    ///</summary>
    public class Temp_BasicData_TrainingSubController : Controller
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Temp_BasicData_TrainingSubAdd()
        {
            int tid = string.IsNullOrEmpty(Request["tid"])? 0 : int.Parse(Request["tid"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int TeacherNum = string.IsNullOrEmpty(Request["TeacherNum"])? 0 : int.Parse(Request["TeacherNum"]);
            int ClassNum = string.IsNullOrEmpty(Request["ClassNum"])? 0 : int.Parse(Request["ClassNum"]);
            int FinishedNum = string.IsNullOrEmpty(Request["FinishedNum"])? 0 : int.Parse(Request["FinishedNum"]);
            int StudyNum = string.IsNullOrEmpty(Request["StudyNum"])? 0 : int.Parse(Request["StudyNum"]);
            int UserNum = string.IsNullOrEmpty(Request["UserNum"])? 0 : int.Parse(Request["UserNum"]);
            decimal FinishedRate = string.IsNullOrEmpty(Request["FinishedRate"])? 0 : decimal.Parse(Request["FinishedRate"]);
            decimal StudyRate = string.IsNullOrEmpty(Request["StudyRate"])? 0 : decimal.Parse(Request["StudyRate"]);

            ////构建实体对象
            Temp_BasicData_TrainingSubEntity entity = new Temp_BasicData_TrainingSubEntity();
            entity.tid = tid;
            entity.SubTID = SubTID;
            entity.TeacherNum = TeacherNum;
            entity.ClassNum = ClassNum;
            entity.FinishedNum = FinishedNum;
            entity.StudyNum = StudyNum;
            entity.UserNum = UserNum;
            entity.FinishedRate = FinishedRate;
            entity.StudyRate = StudyRate;
            int result = 0;
            try
            {
               result = Temp_BasicData_TrainingSubBL.AddTemp_BasicData_TrainingSub(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Temp_BasicData_TrainingSub(RH_Temp_BasicData_TrainingSub)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Temp_BasicData_TrainingSubModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int tid = string.IsNullOrEmpty(Request["tid"])? 0 : int.Parse(Request["tid"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int TeacherNum = string.IsNullOrEmpty(Request["TeacherNum"])? 0 : int.Parse(Request["TeacherNum"]);
            int ClassNum = string.IsNullOrEmpty(Request["ClassNum"])? 0 : int.Parse(Request["ClassNum"]);
            int FinishedNum = string.IsNullOrEmpty(Request["FinishedNum"])? 0 : int.Parse(Request["FinishedNum"]);
            int StudyNum = string.IsNullOrEmpty(Request["StudyNum"])? 0 : int.Parse(Request["StudyNum"]);
            int UserNum = string.IsNullOrEmpty(Request["UserNum"])? 0 : int.Parse(Request["UserNum"]);
            decimal FinishedRate = string.IsNullOrEmpty(Request["FinishedRate"])? 0 : decimal.Parse(Request["FinishedRate"]);
            decimal StudyRate = string.IsNullOrEmpty(Request["StudyRate"])? 0 : decimal.Parse(Request["StudyRate"]);

            ////构建实体对象
            Temp_BasicData_TrainingSubEntity entity = new Temp_BasicData_TrainingSubEntity();
            entity.tid = tid;
            entity.SubTID = SubTID;
            entity.TeacherNum = TeacherNum;
            entity.ClassNum = ClassNum;
            entity.FinishedNum = FinishedNum;
            entity.StudyNum = StudyNum;
            entity.UserNum = UserNum;
            entity.FinishedRate = FinishedRate;
            entity.StudyRate = StudyRate;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = Temp_BasicData_TrainingSubBL.ModifyTemp_BasicData_TrainingSub(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Temp_BasicData_TrainingSub(RH_Temp_BasicData_TrainingSub)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Temp_BasicData_TrainingSubView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            Temp_BasicData_TrainingSubEntity entity = new Temp_BasicData_TrainingSubEntity();
            try
            {
               entity = Temp_BasicData_TrainingSubBL.GatTemp_BasicData_TrainingSubDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Temp_BasicData_TrainingSub(RH_Temp_BasicData_TrainingSub)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Temp_BasicData_TrainingSubRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = Temp_BasicData_TrainingSubBL.RemoveTemp_BasicData_TrainingSub(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Temp_BasicData_TrainingSub(RH_Temp_BasicData_TrainingSub)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Temp_BasicData_TrainingSubList()
        {
            //Temp_BasicData_TrainingSubRH_Temp_BasicData_TrainingSub
            Temp_BasicData_TrainingSubEntityListResult listResult = new Temp_BasicData_TrainingSubEntityListResult();

            Temp_BasicData_TrainingSubSearcher Searcher = new Temp_BasicData_TrainingSubSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<Temp_BasicData_TrainingSubInfo> mPage = null;
            try
            {
               listResult = Temp_BasicData_TrainingSubBL.GetTemp_BasicData_TrainingSubEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.Temp_BasicData_TrainingSubList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Temp_BasicData_TrainingSub(RH_Temp_BasicData_TrainingSub)出错" + DateTime.Now + "**************************");
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