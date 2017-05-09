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
    ///RH_User ( RH_User ) Controller类
    ///</summary>
    public class UserController : Controller
    {

        /// <summary>
        /// 添加RH_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int UserAdd()
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

            ////构建实体对象
            UserEntity entity = new UserEntity();
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
            int result = 0;
            try
            {
               result = UserBL.AddUser(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加User(RH_User)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int UserModify()
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

            ////构建实体对象
            UserEntity entity = new UserEntity();
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
            entity.id = id;
            int result = 0;
            try
            {
               result = UserBL.ModifyUser(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改User(RH_User)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult UserView()
        {
            int id = string.IsNullOrEmpty(Request["id"])? 0 : int.Parse(Request["id"]);

            ////构建实体对象
            UserEntity entity = new UserEntity();
            try
            {
               entity = UserBL.GatUserDetail(id);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情User(RH_User)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int UserRemove()
        {
            int id = string.IsNullOrEmpty(Request["id"])? 0 : int.Parse(Request["id"]);
            int result = 0;

            try
            {
               result = UserBL.RemoveUser(id);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除User(RH_User)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult UserList()
        {
            //UserRH_User
            UserEntityListResult listResult = new UserEntityListResult();

            UserSearcher Searcher = new UserSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<UserInfo> mPage = null;
            try
            {
               listResult = UserBL.GetUserEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.UserList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除User(RH_User)出错" + DateTime.Now + "**************************");
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