using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_BannerArea ( RH_BannerArea ) Logic类
    ///</summary>
    public class BannerAreaLogic
    {

        /// <summary>
        /// 添加RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="void"></returns>
        public void AddBannerArea(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerAreaBiz bannerAreaBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerAreaBiz = new BannerAreaBiz();

                //执行Biz操作
                bannerAreaBiz.AddBannerArea(curConnectionEntity, paramBannerArea);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }
        }

        /// <summary>
        /// 修改RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyBannerArea(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerAreaBiz bannerAreaBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerAreaBiz = new BannerAreaBiz();

                //执行Biz操作
                bannerAreaBiz.ModifyBannerArea(curConnectionEntity, paramBannerArea);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }
        }

        /// <summary>
        /// 删除RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveBannerArea(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerAreaBiz bannerAreaBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerAreaBiz = new BannerAreaBiz();

                //执行Biz操作
                bannerAreaBiz.RemoveBannerArea(curConnectionEntity, paramBannerArea);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }
        }

        /// <summary>
        /// 查看RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="void"></returns>
        public void FindBannerAreaByPK(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerAreaBiz bannerAreaBiz = null;

            BannerAreaEntity bannerAreaEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerAreaBiz = new BannerAreaBiz();

                //执行Biz操作
                bannerArea = bannerAreaBiz.FindBannerAreaByPK(curConnectionEntity, paramBannerArea);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }

            return BannerArea;
        }

        /// <summary>
        /// 根据外键查找RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllBannerAreaByForeignKeys(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerAreaBiz bannerAreaBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerAreaBiz = new BannerAreaBiz();

                //执行Biz操作
                objDataTable = bannerAreaBiz.FindAllBannerAreaByForeignKeys(curConnectionEntity, paramBannerArea);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }

            return objDataTable;
        }
    }
}