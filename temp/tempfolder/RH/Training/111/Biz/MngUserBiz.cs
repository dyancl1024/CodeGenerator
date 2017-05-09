using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_MngUser ( RH_MngUser ) Biz类
    ///</summary>
    public class MngUserBiz
    {

        /// <summary>
        /// 添加RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void AddMngUser(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserDao mngUserDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngUserDao = new MngUserDao();

                //执行DAO操作
                mngUserDao.Insert(curConnectionEntity, paramMngUser);

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
        /// 修改RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyMngUser(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserDao mngUserDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngUserDao = new MngUserDao();

                //执行DAO操作
                mngUserDao.Update(curConnectionEntity, paramMngUser);

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
        /// 删除RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveMngUser(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserDao mngUserDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngUserDao = new MngUserDao();

                //执行DAO操作
                mngUserDao.Delete(curConnectionEntity, paramMngUser);

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
        /// 查看RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void FindMngUserByPK(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserDao mngUserDao = null;

            MngUserEntity mngUserEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngUserDao = new MngUserDao();

                //执行DAO操作
                mngUser = mngUserDao.SelectByPK(curConnectionEntity, paramMngUser);

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

            return MngUser;
        }

        /// <summary>
        /// 根据外键查找RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllMngUserByForeignKeys(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserDao mngUserDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngUserDao = new MngUserDao();

                //执行DAO操作
                objDataTable = mngUserDao.SelectAllMngUserByForeignKeys(curConnectionEntity, paramMngUser);

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