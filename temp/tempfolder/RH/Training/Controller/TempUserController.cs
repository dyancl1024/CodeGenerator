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
    ///RH_TempUser ( RH_TempUser ) Controller类
    ///</summary>
    public class TempUserController : Controller
    {

        /// <summary>
        /// 添加RH_TempUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TempUserAdd()
        {
            string UserName = string.IsNullOrEmpty(Request["UserName"])? "" : Request["UserName"].ToString();
            string Password = string.IsNullOrEmpty(Request["Password"])? "" : Request["Password"].ToString();
            string TrueName = string.IsNullOrEmpty(Request["TrueName"])? "" : Request["TrueName"].ToString();
            string Gender = string.IsNullOrEmpty(Request["Gender"])? "" : Request["Gender"].ToString();
            string PicUrl = string.IsNullOrEmpty(Request["PicUrl"])? "" : Request["PicUrl"].ToString();
            int Nation = string.IsNullOrEmpty(Request["Nation"])? 0 : int.Parse(Request["Nation"]);
            string IDNO = string.IsNullOrEmpty(Request["IDNO"])? "" : Request["IDNO"].ToString();
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            string Mobile = string.IsNullOrEmpty(Request["Mobile"])? "" : Request["Mobile"].ToString();
            string Email = string.IsNullOrEmpty(Request["Email"])? "" : Request["Email"].ToString();
            string QQ = string.IsNullOrEmpty(Request["QQ"])? "" : Request["QQ"].ToString();
            string IPAddr = string.IsNullOrEmpty(Request["IPAddr"])? "" : Request["IPAddr"].ToString();
            int IsChange = string.IsNullOrEmpty(Request["IsChange"])? 0 : int.Parse(Request["IsChange"]);
            int UserState = string.IsNullOrEmpty(Request["UserState"])? 0 : int.Parse(Request["UserState"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);
            string CUserName = string.IsNullOrEmpty(Request["CUserName"])? "" : Request["CUserName"].ToString();
            string CPassword = string.IsNullOrEmpty(Request["CPassword"])? "" : Request["CPassword"].ToString();
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            int SchoolID = string.IsNullOrEmpty(Request["SchoolID"])? 0 : int.Parse(Request["SchoolID"]);
            string SchoolName = string.IsNullOrEmpty(Request["SchoolName"])? "" : Request["SchoolName"].ToString();
            string TempRemark = string.IsNullOrEmpty(Request["TempRemark"])? "" : Request["TempRemark"].ToString();
            int TempUserID = string.IsNullOrEmpty(Request["TempUserID"])? 0 : int.Parse(Request["TempUserID"]);
            string TempClassName = string.IsNullOrEmpty(Request["TempClassName"])? "" : Request["TempClassName"].ToString();
            int TempClassID = string.IsNullOrEmpty(Request["TempClassID"])? 0 : int.Parse(Request["TempClassID"]);

            ////构建实体对象
            TempUserEntity entity = new TempUserEntity();
            entity.UserName = UserName;
            entity.Password = Password;
            entity.TrueName = TrueName;
            entity.Gender = Gender;
            entity.PicUrl = PicUrl;
            entity.Nation = Nation;
            entity.IDNO = IDNO;
            entity.ProvinceID = ProvinceID;
            entity.CityID = CityID;
            entity.DistrictID = DistrictID;
            entity.Mobile = Mobile;
            entity.Email = Email;
            entity.QQ = QQ;
            entity.IPAddr = IPAddr;
            entity.IsChange = IsChange;
            entity.UserState = UserState;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.CUserName = CUserName;
            entity.CPassword = CPassword;
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.SchoolID = SchoolID;
            entity.SchoolName = SchoolName;
            entity.TempRemark = TempRemark;
            entity.TempUserID = TempUserID;
            entity.TempClassName = TempClassName;
            entity.TempClassID = TempClassID;
            int result = 0;
            try
            {
               result = TempUserBL.AddTempUser(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TempUser(RH_TempUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TempUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TempUserModify()
        {
            int id = string.IsNullOrEmpty(Request["id"])? 0 : int.Parse(Request["id"]);
            string UserName = string.IsNullOrEmpty(Request["UserName"])? "" : Request["UserName"].ToString();
            string Password = string.IsNullOrEmpty(Request["Password"])? "" : Request["Password"].ToString();
            string TrueName = string.IsNullOrEmpty(Request["TrueName"])? "" : Request["TrueName"].ToString();
            string Gender = string.IsNullOrEmpty(Request["Gender"])? "" : Request["Gender"].ToString();
            string PicUrl = string.IsNullOrEmpty(Request["PicUrl"])? "" : Request["PicUrl"].ToString();
            int Nation = string.IsNullOrEmpty(Request["Nation"])? 0 : int.Parse(Request["Nation"]);
            string IDNO = string.IsNullOrEmpty(Request["IDNO"])? "" : Request["IDNO"].ToString();
            int ProvinceID = string.IsNullOrEmpty(Request["ProvinceID"])? 0 : int.Parse(Request["ProvinceID"]);
            int CityID = string.IsNullOrEmpty(Request["CityID"])? 0 : int.Parse(Request["CityID"]);
            int DistrictID = string.IsNullOrEmpty(Request["DistrictID"])? 0 : int.Parse(Request["DistrictID"]);
            string Mobile = string.IsNullOrEmpty(Request["Mobile"])? "" : Request["Mobile"].ToString();
            string Email = string.IsNullOrEmpty(Request["Email"])? "" : Request["Email"].ToString();
            string QQ = string.IsNullOrEmpty(Request["QQ"])? "" : Request["QQ"].ToString();
            string IPAddr = string.IsNullOrEmpty(Request["IPAddr"])? "" : Request["IPAddr"].ToString();
            int IsChange = string.IsNullOrEmpty(Request["IsChange"])? 0 : int.Parse(Request["IsChange"]);
            int UserState = string.IsNullOrEmpty(Request["UserState"])? 0 : int.Parse(Request["UserState"]);
            int CreateBy = string.IsNullOrEmpty(Request["CreateBy"])? 0 : int.Parse(Request["CreateBy"]);
            DateTime CreateTime = string.IsNullOrEmpty(Request["CreateTime"])? DateTime.Now : DateTime.Parse(Request["CreateTime"]);
            int UpdateBy = string.IsNullOrEmpty(Request["UpdateBy"])? 0 : int.Parse(Request["UpdateBy"]);
            DateTime UpdateTime = string.IsNullOrEmpty(Request["UpdateTime"])? DateTime.Now : DateTime.Parse(Request["UpdateTime"]);
            string CUserName = string.IsNullOrEmpty(Request["CUserName"])? "" : Request["CUserName"].ToString();
            string CPassword = string.IsNullOrEmpty(Request["CPassword"])? "" : Request["CPassword"].ToString();
            string GradeCode = string.IsNullOrEmpty(Request["GradeCode"])? "" : Request["GradeCode"].ToString();
            string SubjectCode = string.IsNullOrEmpty(Request["SubjectCode"])? "" : Request["SubjectCode"].ToString();
            int SchoolID = string.IsNullOrEmpty(Request["SchoolID"])? 0 : int.Parse(Request["SchoolID"]);
            string SchoolName = string.IsNullOrEmpty(Request["SchoolName"])? "" : Request["SchoolName"].ToString();
            string TempRemark = string.IsNullOrEmpty(Request["TempRemark"])? "" : Request["TempRemark"].ToString();
            int TempUserID = string.IsNullOrEmpty(Request["TempUserID"])? 0 : int.Parse(Request["TempUserID"]);
            string TempClassName = string.IsNullOrEmpty(Request["TempClassName"])? "" : Request["TempClassName"].ToString();
            int TempClassID = string.IsNullOrEmpty(Request["TempClassID"])? 0 : int.Parse(Request["TempClassID"]);

            ////构建实体对象
            TempUserEntity entity = new TempUserEntity();
            entity.UserName = UserName;
            entity.Password = Password;
            entity.TrueName = TrueName;
            entity.Gender = Gender;
            entity.PicUrl = PicUrl;
            entity.Nation = Nation;
            entity.IDNO = IDNO;
            entity.ProvinceID = ProvinceID;
            entity.CityID = CityID;
            entity.DistrictID = DistrictID;
            entity.Mobile = Mobile;
            entity.Email = Email;
            entity.QQ = QQ;
            entity.IPAddr = IPAddr;
            entity.IsChange = IsChange;
            entity.UserState = UserState;
            entity.CreateBy = CreateBy;
            entity.CreateTime = CreateTime;
            entity.UpdateBy = UpdateBy;
            entity.UpdateTime = UpdateTime;
            entity.CUserName = CUserName;
            entity.CPassword = CPassword;
            entity.GradeCode = GradeCode;
            entity.SubjectCode = SubjectCode;
            entity.SchoolID = SchoolID;
            entity.SchoolName = SchoolName;
            entity.TempRemark = TempRemark;
            entity.TempUserID = TempUserID;
            entity.TempClassName = TempClassName;
            entity.TempClassID = TempClassID;
            entity.id = id;
            int result = 0;
            try
            {
               result = TempUserBL.ModifyTempUser(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TempUser(RH_TempUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TempUserView()
        {
            int id = string.IsNullOrEmpty(Request["id"])? 0 : int.Parse(Request["id"]);

            ////构建实体对象
            TempUserEntity entity = new TempUserEntity();
            try
            {
               entity = TempUserBL.GatTempUserDetail(id);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TempUser(RH_TempUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TempUserRemove()
        {
            int id = string.IsNullOrEmpty(Request["id"])? 0 : int.Parse(Request["id"]);
            int result = 0;

            try
            {
               result = TempUserBL.RemoveTempUser(id);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TempUser(RH_TempUser)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TempUserList()
        {
            //TempUserRH_TempUser
            TempUserEntityListResult listResult = new TempUserEntityListResult();

            TempUserSearcher Searcher = new TempUserSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TempUserInfo> mPage = null;
            try
            {
               listResult = TempUserBL.GetTempUserEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TempUserList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TempUser(RH_TempUser)出错" + DateTime.Now + "**************************");
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