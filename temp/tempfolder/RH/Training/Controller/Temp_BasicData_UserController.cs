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
    ///RH_Temp_BasicData_User ( RH_Temp_BasicData_User ) Controller类
    ///</summary>
    public class Temp_BasicData_UserController : Controller
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Temp_BasicData_UserAdd()
        {
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int ClassID = string.IsNullOrEmpty(Request["ClassID"])? 0 : int.Parse(Request["ClassID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int Phase = string.IsNullOrEmpty(Request["Phase"])? 0 : int.Parse(Request["Phase"]);
            int Q_jxfs = string.IsNullOrEmpty(Request["Q_jxfs"])? 0 : int.Parse(Request["Q_jxfs"]);
            int T_jxfs = string.IsNullOrEmpty(Request["T_jxfs"])? 0 : int.Parse(Request["T_jxfs"]);
            int F_jxfs = string.IsNullOrEmpty(Request["F_jxfs"])? 0 : int.Parse(Request["F_jxfs"]);
            int E_jxfs = string.IsNullOrEmpty(Request["E_jxfs"])? 0 : int.Parse(Request["E_jxfs"]);
            int Q_jxcl = string.IsNullOrEmpty(Request["Q_jxcl"])? 0 : int.Parse(Request["Q_jxcl"]);
            int T_jxcl = string.IsNullOrEmpty(Request["T_jxcl"])? 0 : int.Parse(Request["T_jxcl"]);
            int F_jxcl = string.IsNullOrEmpty(Request["F_jxcl"])? 0 : int.Parse(Request["F_jxcl"]);
            int E_jxcl = string.IsNullOrEmpty(Request["E_jxcl"])? 0 : int.Parse(Request["E_jxcl"]);
            int Q_xxxd = string.IsNullOrEmpty(Request["Q_xxxd"])? 0 : int.Parse(Request["Q_xxxd"]);
            int T_xxxd = string.IsNullOrEmpty(Request["T_xxxd"])? 0 : int.Parse(Request["T_xxxd"]);
            int F_xxxd = string.IsNullOrEmpty(Request["F_xxxd"])? 0 : int.Parse(Request["F_xxxd"]);
            int E_xxxd = string.IsNullOrEmpty(Request["E_xxxd"])? 0 : int.Parse(Request["E_xxxd"]);
            int Q_wtfx = string.IsNullOrEmpty(Request["Q_wtfx"])? 0 : int.Parse(Request["Q_wtfx"]);
            int T_wtfx = string.IsNullOrEmpty(Request["T_wtfx"])? 0 : int.Parse(Request["T_wtfx"]);
            int F_wtfx = string.IsNullOrEmpty(Request["F_wtfx"])? 0 : int.Parse(Request["F_wtfx"]);
            int E_wtfx = string.IsNullOrEmpty(Request["E_wtfx"])? 0 : int.Parse(Request["E_wtfx"]);
            int Q_yxrz = string.IsNullOrEmpty(Request["Q_yxrz"])? 0 : int.Parse(Request["Q_yxrz"]);
            int T_yxrz = string.IsNullOrEmpty(Request["T_yxrz"])? 0 : int.Parse(Request["T_yxrz"]);
            int F_yxrz = string.IsNullOrEmpty(Request["F_yxrz"])? 0 : int.Parse(Request["F_yxrz"]);
            int E_yxrz = string.IsNullOrEmpty(Request["E_yxrz"])? 0 : int.Parse(Request["E_yxrz"]);
            int Q_pxzj = string.IsNullOrEmpty(Request["Q_pxzj"])? 0 : int.Parse(Request["Q_pxzj"]);
            int T_pxzj = string.IsNullOrEmpty(Request["T_pxzj"])? 0 : int.Parse(Request["T_pxzj"]);
            int F_pxzj = string.IsNullOrEmpty(Request["F_pxzj"])? 0 : int.Parse(Request["F_pxzj"]);
            int E_pxzj = string.IsNullOrEmpty(Request["E_pxzj"])? 0 : int.Parse(Request["E_pxzj"]);
            int Finished = string.IsNullOrEmpty(Request["Finished"])? 0 : int.Parse(Request["Finished"]);
            int GetCoursePhase = string.IsNullOrEmpty(Request["GetCoursePhase"])? 0 : int.Parse(Request["GetCoursePhase"]);
            int CoursePhase = string.IsNullOrEmpty(Request["CoursePhase"])? 0 : int.Parse(Request["CoursePhase"]);
            string StatusName = string.IsNullOrEmpty(Request["StatusName"])? "" : Request["StatusName"].ToString();
            int IsStudy = string.IsNullOrEmpty(Request["IsStudy"])? 0 : int.Parse(Request["IsStudy"]);
            int HomeWorkPhase = string.IsNullOrEmpty(Request["HomeWorkPhase"])? 0 : int.Parse(Request["HomeWorkPhase"]);

            ////构建实体对象
            Temp_BasicData_UserEntity entity = new Temp_BasicData_UserEntity();
            entity.SubTID = SubTID;
            entity.ClassID = ClassID;
            entity.UserID = UserID;
            entity.Phase = Phase;
            entity.Q_jxfs = Q_jxfs;
            entity.T_jxfs = T_jxfs;
            entity.F_jxfs = F_jxfs;
            entity.E_jxfs = E_jxfs;
            entity.Q_jxcl = Q_jxcl;
            entity.T_jxcl = T_jxcl;
            entity.F_jxcl = F_jxcl;
            entity.E_jxcl = E_jxcl;
            entity.Q_xxxd = Q_xxxd;
            entity.T_xxxd = T_xxxd;
            entity.F_xxxd = F_xxxd;
            entity.E_xxxd = E_xxxd;
            entity.Q_wtfx = Q_wtfx;
            entity.T_wtfx = T_wtfx;
            entity.F_wtfx = F_wtfx;
            entity.E_wtfx = E_wtfx;
            entity.Q_yxrz = Q_yxrz;
            entity.T_yxrz = T_yxrz;
            entity.F_yxrz = F_yxrz;
            entity.E_yxrz = E_yxrz;
            entity.Q_pxzj = Q_pxzj;
            entity.T_pxzj = T_pxzj;
            entity.F_pxzj = F_pxzj;
            entity.E_pxzj = E_pxzj;
            entity.Finished = Finished;
            entity.GetCoursePhase = GetCoursePhase;
            entity.CoursePhase = CoursePhase;
            entity.StatusName = StatusName;
            entity.IsStudy = IsStudy;
            entity.HomeWorkPhase = HomeWorkPhase;
            int result = 0;
            try
            {
               result = Temp_BasicData_UserBL.AddTemp_BasicData_User(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加Temp_BasicData_User(RH_Temp_BasicData_User)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_Temp_BasicData_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Temp_BasicData_UserModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int SubTID = string.IsNullOrEmpty(Request["SubTID"])? 0 : int.Parse(Request["SubTID"]);
            int ClassID = string.IsNullOrEmpty(Request["ClassID"])? 0 : int.Parse(Request["ClassID"]);
            int UserID = string.IsNullOrEmpty(Request["UserID"])? 0 : int.Parse(Request["UserID"]);
            int Phase = string.IsNullOrEmpty(Request["Phase"])? 0 : int.Parse(Request["Phase"]);
            int Q_jxfs = string.IsNullOrEmpty(Request["Q_jxfs"])? 0 : int.Parse(Request["Q_jxfs"]);
            int T_jxfs = string.IsNullOrEmpty(Request["T_jxfs"])? 0 : int.Parse(Request["T_jxfs"]);
            int F_jxfs = string.IsNullOrEmpty(Request["F_jxfs"])? 0 : int.Parse(Request["F_jxfs"]);
            int E_jxfs = string.IsNullOrEmpty(Request["E_jxfs"])? 0 : int.Parse(Request["E_jxfs"]);
            int Q_jxcl = string.IsNullOrEmpty(Request["Q_jxcl"])? 0 : int.Parse(Request["Q_jxcl"]);
            int T_jxcl = string.IsNullOrEmpty(Request["T_jxcl"])? 0 : int.Parse(Request["T_jxcl"]);
            int F_jxcl = string.IsNullOrEmpty(Request["F_jxcl"])? 0 : int.Parse(Request["F_jxcl"]);
            int E_jxcl = string.IsNullOrEmpty(Request["E_jxcl"])? 0 : int.Parse(Request["E_jxcl"]);
            int Q_xxxd = string.IsNullOrEmpty(Request["Q_xxxd"])? 0 : int.Parse(Request["Q_xxxd"]);
            int T_xxxd = string.IsNullOrEmpty(Request["T_xxxd"])? 0 : int.Parse(Request["T_xxxd"]);
            int F_xxxd = string.IsNullOrEmpty(Request["F_xxxd"])? 0 : int.Parse(Request["F_xxxd"]);
            int E_xxxd = string.IsNullOrEmpty(Request["E_xxxd"])? 0 : int.Parse(Request["E_xxxd"]);
            int Q_wtfx = string.IsNullOrEmpty(Request["Q_wtfx"])? 0 : int.Parse(Request["Q_wtfx"]);
            int T_wtfx = string.IsNullOrEmpty(Request["T_wtfx"])? 0 : int.Parse(Request["T_wtfx"]);
            int F_wtfx = string.IsNullOrEmpty(Request["F_wtfx"])? 0 : int.Parse(Request["F_wtfx"]);
            int E_wtfx = string.IsNullOrEmpty(Request["E_wtfx"])? 0 : int.Parse(Request["E_wtfx"]);
            int Q_yxrz = string.IsNullOrEmpty(Request["Q_yxrz"])? 0 : int.Parse(Request["Q_yxrz"]);
            int T_yxrz = string.IsNullOrEmpty(Request["T_yxrz"])? 0 : int.Parse(Request["T_yxrz"]);
            int F_yxrz = string.IsNullOrEmpty(Request["F_yxrz"])? 0 : int.Parse(Request["F_yxrz"]);
            int E_yxrz = string.IsNullOrEmpty(Request["E_yxrz"])? 0 : int.Parse(Request["E_yxrz"]);
            int Q_pxzj = string.IsNullOrEmpty(Request["Q_pxzj"])? 0 : int.Parse(Request["Q_pxzj"]);
            int T_pxzj = string.IsNullOrEmpty(Request["T_pxzj"])? 0 : int.Parse(Request["T_pxzj"]);
            int F_pxzj = string.IsNullOrEmpty(Request["F_pxzj"])? 0 : int.Parse(Request["F_pxzj"]);
            int E_pxzj = string.IsNullOrEmpty(Request["E_pxzj"])? 0 : int.Parse(Request["E_pxzj"]);
            int Finished = string.IsNullOrEmpty(Request["Finished"])? 0 : int.Parse(Request["Finished"]);
            int GetCoursePhase = string.IsNullOrEmpty(Request["GetCoursePhase"])? 0 : int.Parse(Request["GetCoursePhase"]);
            int CoursePhase = string.IsNullOrEmpty(Request["CoursePhase"])? 0 : int.Parse(Request["CoursePhase"]);
            string StatusName = string.IsNullOrEmpty(Request["StatusName"])? "" : Request["StatusName"].ToString();
            int IsStudy = string.IsNullOrEmpty(Request["IsStudy"])? 0 : int.Parse(Request["IsStudy"]);
            int HomeWorkPhase = string.IsNullOrEmpty(Request["HomeWorkPhase"])? 0 : int.Parse(Request["HomeWorkPhase"]);

            ////构建实体对象
            Temp_BasicData_UserEntity entity = new Temp_BasicData_UserEntity();
            entity.SubTID = SubTID;
            entity.ClassID = ClassID;
            entity.UserID = UserID;
            entity.Phase = Phase;
            entity.Q_jxfs = Q_jxfs;
            entity.T_jxfs = T_jxfs;
            entity.F_jxfs = F_jxfs;
            entity.E_jxfs = E_jxfs;
            entity.Q_jxcl = Q_jxcl;
            entity.T_jxcl = T_jxcl;
            entity.F_jxcl = F_jxcl;
            entity.E_jxcl = E_jxcl;
            entity.Q_xxxd = Q_xxxd;
            entity.T_xxxd = T_xxxd;
            entity.F_xxxd = F_xxxd;
            entity.E_xxxd = E_xxxd;
            entity.Q_wtfx = Q_wtfx;
            entity.T_wtfx = T_wtfx;
            entity.F_wtfx = F_wtfx;
            entity.E_wtfx = E_wtfx;
            entity.Q_yxrz = Q_yxrz;
            entity.T_yxrz = T_yxrz;
            entity.F_yxrz = F_yxrz;
            entity.E_yxrz = E_yxrz;
            entity.Q_pxzj = Q_pxzj;
            entity.T_pxzj = T_pxzj;
            entity.F_pxzj = F_pxzj;
            entity.E_pxzj = E_pxzj;
            entity.Finished = Finished;
            entity.GetCoursePhase = GetCoursePhase;
            entity.CoursePhase = CoursePhase;
            entity.StatusName = StatusName;
            entity.IsStudy = IsStudy;
            entity.HomeWorkPhase = HomeWorkPhase;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = Temp_BasicData_UserBL.ModifyTemp_BasicData_User(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改Temp_BasicData_User(RH_Temp_BasicData_User)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Temp_BasicData_UserView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            Temp_BasicData_UserEntity entity = new Temp_BasicData_UserEntity();
            try
            {
               entity = Temp_BasicData_UserBL.GatTemp_BasicData_UserDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情Temp_BasicData_User(RH_Temp_BasicData_User)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Temp_BasicData_UserRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = Temp_BasicData_UserBL.RemoveTemp_BasicData_User(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Temp_BasicData_User(RH_Temp_BasicData_User)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Temp_BasicData_UserList()
        {
            //Temp_BasicData_UserRH_Temp_BasicData_User
            Temp_BasicData_UserEntityListResult listResult = new Temp_BasicData_UserEntityListResult();

            Temp_BasicData_UserSearcher Searcher = new Temp_BasicData_UserSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<Temp_BasicData_UserInfo> mPage = null;
            try
            {
               listResult = Temp_BasicData_UserBL.GetTemp_BasicData_UserEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.Temp_BasicData_UserList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除Temp_BasicData_User(RH_Temp_BasicData_User)出错" + DateTime.Now + "**************************");
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