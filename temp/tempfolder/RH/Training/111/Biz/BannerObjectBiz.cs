using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_BannerObject ( RH_BannerObject ) Biz类
    ///</summary>
    public class BannerObjectBiz
    {

        /// <summary>
        /// 添加RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void AddBannerObject(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectDao bannerObjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerObjectDao = new BannerObjectDao();

                //执行DAO操作
                bannerObjectDao.Insert(curConnectionEntity, paramBannerObject);

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
        /// 修改RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyBannerObject(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectDao bannerObjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerObjectDao = new BannerObjectDao();

                //执行DAO操作
                bannerObjectDao.Update(curConnectionEntity, paramBannerObject);

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
        /// 删除RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveBannerObject(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectDao bannerObjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerObjectDao = new BannerObjectDao();

                //执行DAO操作
                bannerObjectDao.Delete(curConnectionEntity, paramBannerObject);

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
        /// 查看RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void FindBannerObjectByPK(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectDao bannerObjectDao = null;

            BannerObjectEntity bannerObjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerObjectDao = new BannerObjectDao();

                //执行DAO操作
                bannerObject = bannerObjectDao.SelectByPK(curConnectionEntity, paramBannerObject);

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

            return BannerObject;
        }

        /// <summary>
        /// 根据外键查找RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllBannerObjectByForeignKeys(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectDao bannerObjectDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                bannerObjectDao = new BannerObjectDao();

                //执行DAO操作
                objDataTable = bannerObjectDao.SelectAllBannerObjectByForeignKeys(curConnectionEntity, paramBannerObject);

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