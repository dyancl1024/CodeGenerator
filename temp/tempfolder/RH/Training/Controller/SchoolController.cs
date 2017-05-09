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
    ///RH_School ( RH_School ) Controller类
    ///</summary>
    public class SchoolController : Controller
    {

        /// <summary>
        /// 添加RH_School
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int SchoolAdd()
        {
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            string SchoolName = string.IsNullOrEmpty(Request["SchoolName"])? "" : Request["SchoolName"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            SchoolEntity entity = new SchoolEntity();
            entity.DistrictID = DistrictID;
            entity.SchoolName = SchoolName;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            int result = 0;
            try
            {
               result = SchoolBL.AddSchool(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加School(RH_School)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_School
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int SchoolModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            string SchoolName = string.IsNullOrEmpty(Request["SchoolName"])? "" : Request["SchoolName"].ToString();
            int Status = string.IsNullOrEmpty(Request["Status"])? 0 : int.Parse(Request["Status"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);

            ////构建实体对象
            SchoolEntity entity = new SchoolEntity();
            entity.DistrictID = DistrictID;
            entity.SchoolName = SchoolName;
            entity.Status = Status;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = SchoolBL.ModifySchool(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改School(RH_School)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult SchoolView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            SchoolEntity entity = new SchoolEntity();
            try
            {
               entity = SchoolBL.GatSchoolDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情School(RH_School)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int SchoolRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = SchoolBL.RemoveSchool(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除School(RH_School)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult SchoolList()
        {
            //SchoolRH_School
            SchoolEntityListResult listResult = new SchoolEntityListResult();

            SchoolSearcher Searcher = new SchoolSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<SchoolInfo> mPage = null;
            try
            {
               listResult = SchoolBL.GetSchoolEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.SchoolList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除School(RH_School)出错" + DateTime.Now + "**************************");
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