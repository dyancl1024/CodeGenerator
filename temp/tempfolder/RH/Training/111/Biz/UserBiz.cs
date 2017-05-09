using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_User ( RH_User ) Biz类
    ///</summary>
    public class UserBiz
    {

        /// <summary>
        /// 添加RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="void"></returns>
        public void AddUser(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserDao userDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userDao = new UserDao();

                //执行DAO操作
                userDao.Insert(curConnectionEntity, paramUser);

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
        /// 修改RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyUser(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserDao userDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userDao = new UserDao();

                //执行DAO操作
                userDao.Update(curConnectionEntity, paramUser);

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
        /// 删除RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveUser(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserDao userDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userDao = new UserDao();

                //执行DAO操作
                userDao.Delete(curConnectionEntity, paramUser);

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
        /// 查看RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="void"></returns>
        public void FindUserByPK(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserDao userDao = null;

            UserEntity userEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userDao = new UserDao();

                //执行DAO操作
                user = userDao.SelectByPK(curConnectionEntity, paramUser);

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

            return User;
        }

        /// <summary>
        /// 根据外键查找RH_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserEntity" type="UserEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllUserByForeignKeys(Object paramConnectionEntity, UserEntity paramUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserDao userDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userDao = new UserDao();

                //执行DAO操作
                objDataTable = userDao.SelectAllUserByForeignKeys(curConnectionEntity, paramUser);

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