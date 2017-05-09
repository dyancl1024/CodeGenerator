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
    ///RH_TrainingClass ( RH_TrainingClass ) Controller类
    ///</summary>
    public class TrainingClassController : Controller
    {

        /// <summary>
        /// 添加RH_TrainingClass
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingClassAdd()
        {
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int ClassNO = string.IsNullOrEmpty(Request["ClassNO"])? 0 : int.Parse(Request["ClassNO"]);
            string CName = string.IsNullOrEmpty(Request["CName"])? "" : Request["CName"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingClassEntity entity = new TrainingClassEntity();
            entity.SubTID = SubTID;
            entity.ClassNO = ClassNO;
            entity.CName = CName;
            entity.SubjectCode = SubjectCode;
            entity.GradeCode = GradeCode;
            entity.StaticUrl = StaticUrl;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = TrainingClassBL.AddTrainingClass(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TrainingClass(RH_TrainingClass)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TrainingClass
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TrainingClassModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int ClassNO = string.IsNullOrEmpty(Request["ClassNO"])? 0 : int.Parse(Request["ClassNO"]);
            string CName = string.IsNullOrEmpty(Request["CName"])? "" : Request["CName"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string StaticUrl = string.IsNullOrEmpty(Request["StaticUrl"])? "" : Request["StaticUrl"].ToString();
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            TrainingClassEntity entity = new TrainingClassEntity();
            entity.SubTID = SubTID;
            entity.ClassNO = ClassNO;
            entity.CName = CName;
            entity.SubjectCode = SubjectCode;
            entity.GradeCode = GradeCode;
            entity.StaticUrl = StaticUrl;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TrainingClassBL.ModifyTrainingClass(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TrainingClass(RH_TrainingClass)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingClassView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TrainingClassEntity entity = new TrainingClassEntity();
            try
            {
               entity = TrainingClassBL.GatTrainingClassDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TrainingClass(RH_TrainingClass)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TrainingClassRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TrainingClassBL.RemoveTrainingClass(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingClass(RH_TrainingClass)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TrainingClassList()
        {
            //TrainingClassRH_TrainingClass
            TrainingClassEntityListResult listResult = new TrainingClassEntityListResult();

            TrainingClassSearcher Searcher = new TrainingClassSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TrainingClassInfo> mPage = null;
            try
            {
               listResult = TrainingClassBL.GetTrainingClassEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TrainingClassList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TrainingClass(RH_TrainingClass)出错" + DateTime.Now + "**************************");
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