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
    ///RH_Temp_BasicData_Class ( RH_Temp_BasicData_Class ) Controller类
    ///</summary>
    public class Temp_BasicData_ClassController : Controller
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Temp_BasicData_ClassAdd()
        {
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int ClassID = string.IsNullOrEmpty(Request["ClassID"])? 0 : int.Parse(Request["ClassID"]);
            int YX_HW = string.IsNullOrEmpty(Request["YX_HW"])? 0 : int.Parse(Request["YX_HW"]);
            int TJ_HW = string.IsNullOrEmpty(Request["TJ_HW"])? 0 : int.Parse(Request["TJ_HW"]);
            int StudyNum = string.IsNullOrEmpty(Request["StudyNum"])? 0 : int.Parse(Request["StudyNum"]);
            int FinishedNum = string.IsNullOrEmpty(Request["FinishedNum"])? 0 : int.Parse(Request["FinishedNum"]);
            int UserNum = string.IsNullOrEmpty(Request["UserNum"])? 0 : int.Parse(Request["UserNum"]);
            decimal ClassRate = string.IsNullOrEmpty(Request["ClassRate"])? 0 : decimal.Parse(Request["ClassRate"]);
            int HG_HW = string.IsNullOrEmpty(Request["HG_HW"])? 0 : int.Parse(Request["HG_HW"]);
            int No_Num = string.IsNullOrEmpty(Request["No_Num"])? 0 : int.Parse(Request["No_Num"]);

            ////构建实体对象
            Temp_BasicData_ClassEntity entity = new Temp_BasicData_ClassEntity();
            entity.SubTID = SubTID;
            entity.ClassID = ClassID;
            entity.YX_HW = YX_HW;
            entity.TJ_HW = TJ_HW;
            entity.StudyNum = StudyNum;
            entity.FinishedNum = FinishedNum;
            entity.UserNum = UserNum;
            entity.ClassRate = ClassRate;
            entity.HG_HW = HG_HW;
            entity.No_Num = No_Num;
            int result = 0;
            try
            {
               result = Temp_BasicData_ClassBL.AddTemp_BasicData_Class(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Temp_BasicData_Class(RH_Temp_BasicData_Class)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Temp_BasicData_ClassModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int ClassID = string.IsNullOrEmpty(Request["ClassID"])? 0 : int.Parse(Request["ClassID"]);
            int YX_HW = string.IsNullOrEmpty(Request["YX_HW"])? 0 : int.Parse(Request["YX_HW"]);
            int TJ_HW = string.IsNullOrEmpty(Request["TJ_HW"])? 0 : int.Parse(Request["TJ_HW"]);
            int StudyNum = string.IsNullOrEmpty(Request["StudyNum"])? 0 : int.Parse(Request["StudyNum"]);
            int FinishedNum = string.IsNullOrEmpty(Request["FinishedNum"])? 0 : int.Parse(Request["FinishedNum"]);
            int UserNum = string.IsNullOrEmpty(Request["UserNum"])? 0 : int.Parse(Request["UserNum"]);
            decimal ClassRate = string.IsNullOrEmpty(Request["ClassRate"])? 0 : decimal.Parse(Request["ClassRate"]);
            int HG_HW = string.IsNullOrEmpty(Request["HG_HW"])? 0 : int.Parse(Request["HG_HW"]);
            int No_Num = string.IsNullOrEmpty(Request["No_Num"])? 0 : int.Parse(Request["No_Num"]);

            ////构建实体对象
            Temp_BasicData_ClassEntity entity = new Temp_BasicData_ClassEntity();
            entity.SubTID = SubTID;
            entity.ClassID = ClassID;
            entity.YX_HW = YX_HW;
            entity.TJ_HW = TJ_HW;
            entity.StudyNum = StudyNum;
            entity.FinishedNum = FinishedNum;
            entity.UserNum = UserNum;
            entity.ClassRate = ClassRate;
            entity.HG_HW = HG_HW;
            entity.No_Num = No_Num;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = Temp_BasicData_ClassBL.ModifyTemp_BasicData_Class(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Temp_BasicData_Class(RH_Temp_BasicData_Class)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Temp_BasicData_ClassView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            Temp_BasicData_ClassEntity entity = new Temp_BasicData_ClassEntity();
            try
            {
               entity = Temp_BasicData_ClassBL.GatTemp_BasicData_ClassDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Temp_BasicData_Class(RH_Temp_BasicData_Class)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Temp_BasicData_ClassRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = Temp_BasicData_ClassBL.RemoveTemp_BasicData_Class(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Temp_BasicData_Class(RH_Temp_BasicData_Class)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Temp_BasicData_ClassList()
        {
            //Temp_BasicData_ClassRH_Temp_BasicData_Class
            Temp_BasicData_ClassEntityListResult listResult = new Temp_BasicData_ClassEntityListResult();

            Temp_BasicData_ClassSearcher Searcher = new Temp_BasicData_ClassSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<Temp_BasicData_ClassInfo> mPage = null;
            try
            {
               listResult = Temp_BasicData_ClassBL.GetTemp_BasicData_ClassEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.Temp_BasicData_ClassList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Temp_BasicData_Class(RH_Temp_BasicData_Class)出错" + DateTime.Now + "**************************");
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