using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_BannerArea ( RH_BannerArea ) Biz类
    ///</summary>
    public class BannerAreaBiz
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

            BannerAreaDao bannerAreaDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerAreaDao = new BannerAreaDao();

                //执行DAO操作
                bannerAreaDao.Insert(curConnectionEntity, paramBannerArea);

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

            BannerAreaDao bannerAreaDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerAreaDao = new BannerAreaDao();

                //执行DAO操作
                bannerAreaDao.Update(curConnectionEntity, paramBannerArea);

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

            BannerAreaDao bannerAreaDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerAreaDao = new BannerAreaDao();

                //执行DAO操作
                bannerAreaDao.Delete(curConnectionEntity, paramBannerArea);

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

            BannerAreaDao bannerAreaDao = null;

            BannerAreaEntity bannerAreaEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerAreaDao = new BannerAreaDao();

                //执行DAO操作
                bannerArea = bannerAreaDao.SelectByPK(curConnectionEntity, paramBannerArea);

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

            BannerAreaDao bannerAreaDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerAreaDao = new BannerAreaDao();

                //执行DAO操作
                objDataTable = bannerAreaDao.SelectAllBannerAreaByForeignKeys(curConnectionEntity, paramBannerArea);

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