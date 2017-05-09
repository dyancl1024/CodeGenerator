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
    ///RH_TempExcel ( RH_TempExcel ) Controller类
    ///</summary>
    public class TempExcelController : Controller
    {

        /// <summary>
        /// 添加RH_TempExcel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TempExcelAdd()
        {
            string FileExcel = string.IsNullOrEmpty(Request["FileExcel"])? "" : Request["FileExcel"].ToString();
            string TableName = string.IsNullOrEmpty(Request["TableName"])? "" : Request["TableName"].ToString();
            string TempRemark = string.IsNullOrEmpty(Request["TempRemark"])? "" : Request["TempRemark"].ToString();

            ////构建实体对象
            TempExcelEntity entity = new TempExcelEntity();
            entity.FileExcel = FileExcel;
            entity.TableName = TableName;
            entity.TempRemark = TempRemark;
            int result = 0;
            try
            {
               result = TempExcelBL.AddTempExcel(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************添加TempExcel(RH_TempExcel)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 修改RH_TempExcel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int TempExcelModify()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            string FileExcel = string.IsNullOrEmpty(Request["FileExcel"])? "" : Request["FileExcel"].ToString();
            string TableName = string.IsNullOrEmpty(Request["TableName"])? "" : Request["TableName"].ToString();
            string TempRemark = string.IsNullOrEmpty(Request["TempRemark"])? "" : Request["TempRemark"].ToString();

            ////构建实体对象
            TempExcelEntity entity = new TempExcelEntity();
            entity.FileExcel = FileExcel;
            entity.TableName = TableName;
            entity.TempRemark = TempRemark;
            entity.ID = ID;
            int result = 0;
            try
            {
               result = TempExcelBL.ModifyTempExcel(entity);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************修改TempExcel(RH_TempExcel)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TempExcelView()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);

            ////构建实体对象
            TempExcelEntity entity = new TempExcelEntity();
            try
            {
               entity = TempExcelBL.GatTempExcelDetail(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************查看详情TempExcel(RH_TempExcel)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return View(entity) ;

        }


        /// <summary>
        /// 删除RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int TempExcelRemove()
        {
            int ID = string.IsNullOrEmpty(Request["ID"])? 0 : int.Parse(Request["ID"]);
            int result = 0;

            try
            {
               result = TempExcelBL.RemoveTempExcel(ID);

            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TempExcel(RH_TempExcel)出错" + DateTime.Now + "**************************");
               FileLib.SaveInfoToLog(ex.Message);
            }

            return result ;

        }


        /// <summary>
        /// 查看全部RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult TempExcelList()
        {
            //TempExcelRH_TempExcel
            TempExcelEntityListResult listResult = new TempExcelEntityListResult();

            TempExcelSearcher Searcher = new TempExcelSearcher();

            //查询条件设置
            Searcher.PageSize = PageSize;
            Searcher.PageIndex = PageIndex - 1;
            PagedList<TempExcelInfo> mPage = null;
            try
            {
               listResult = TempExcelBL.GetTempExcelEntityList(Searcher);

               if(listResult.TotalCount > 0)
               {
                  mPage = listResult.TempExcelList.AsQueryable().ToPagedList(1, PageSize);
                  mPage.TotalItemCount = listResult.TotalCount;
                  mPage.CurrentPageIndex = PageIndex;
               }
            }
            catch (Exception ex)
            {
               FileLib.SaveInfoToLog("*********************删除TempExcel(RH_TempExcel)出错" + DateTime.Now + "**************************");
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