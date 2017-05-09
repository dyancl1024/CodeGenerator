using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Banner ( RH_Banner ) Biz类
    ///</summary>
    public class BannerBiz
    {

        /// <summary>
        /// 添加RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="void"></returns>
        public void AddBanner(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerDao bannerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerDao = new BannerDao();

                //执行DAO操作
                bannerDao.Insert(curConnectionEntity, paramBanner);

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
        /// 修改RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyBanner(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerDao bannerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerDao = new BannerDao();

                //执行DAO操作
                bannerDao.Update(curConnectionEntity, paramBanner);

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
        /// 删除RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveBanner(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerDao bannerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerDao = new BannerDao();

                //执行DAO操作
                bannerDao.Delete(curConnectionEntity, paramBanner);

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
        /// 查看RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="void"></returns>
        public void FindBannerByPK(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerDao bannerDao = null;

            BannerEntity bannerEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerDao = new BannerDao();

                //执行DAO操作
                banner = bannerDao.SelectByPK(curConnectionEntity, paramBanner);

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

            return Banner;
        }

        /// <summary>
        /// 根据外键查找RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllBannerByForeignKeys(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerDao bannerDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerDao = new BannerDao();

                //执行DAO操作
                objDataTable = bannerDao.SelectAllBannerByForeignKeys(curConnectionEntity, paramBanner);

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