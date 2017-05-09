using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_MngRoleRight ( RH_MngRoleRight ) Biz类
    ///</summary>
    public class MngRoleRightBiz
    {

        /// <summary>
        /// 添加RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void AddMngRoleRight(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightDao mngRoleRightDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleRightDao = new MngRoleRightDao();

                //执行DAO操作
                mngRoleRightDao.Insert(curConnectionEntity, paramMngRoleRight);

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
        /// 修改RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyMngRoleRight(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightDao mngRoleRightDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleRightDao = new MngRoleRightDao();

                //执行DAO操作
                mngRoleRightDao.Update(curConnectionEntity, paramMngRoleRight);

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
        /// 删除RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveMngRoleRight(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightDao mngRoleRightDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleRightDao = new MngRoleRightDao();

                //执行DAO操作
                mngRoleRightDao.Delete(curConnectionEntity, paramMngRoleRight);

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
        /// 查看RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void FindMngRoleRightByPK(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightDao mngRoleRightDao = null;

            MngRoleRightEntity mngRoleRightEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleRightDao = new MngRoleRightDao();

                //执行DAO操作
                mngRoleRight = mngRoleRightDao.SelectByPK(curConnectionEntity, paramMngRoleRight);

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

            return MngRoleRight;
        }

        /// <summary>
        /// 根据外键查找RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllMngRoleRightByForeignKeys(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightDao mngRoleRightDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleRightDao = new MngRoleRightDao();

                //执行DAO操作
                objDataTable = mngRoleRightDao.SelectAllMngRoleRightByForeignKeys(curConnectionEntity, paramMngRoleRight);

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