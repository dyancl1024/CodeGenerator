using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_UserInfo ( RH_UserInfo ) Biz类
    ///</summary>
    public class UserInfoBiz
    {

        /// <summary>
        /// 添加RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="void"></returns>
        public void AddUserInfo(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserInfoDao userInfoDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userInfoDao = new UserInfoDao();

                //执行DAO操作
                userInfoDao.Insert(curConnectionEntity, paramUserInfo);

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
        /// 修改RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyUserInfo(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserInfoDao userInfoDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userInfoDao = new UserInfoDao();

                //执行DAO操作
                userInfoDao.Update(curConnectionEntity, paramUserInfo);

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
        /// 删除RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveUserInfo(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserInfoDao userInfoDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userInfoDao = new UserInfoDao();

                //执行DAO操作
                userInfoDao.Delete(curConnectionEntity, paramUserInfo);

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
        /// 查看RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="void"></returns>
        public void FindUserInfoByPK(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserInfoDao userInfoDao = null;

            UserInfoEntity userInfoEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userInfoDao = new UserInfoDao();

                //执行DAO操作
                userInfo = userInfoDao.SelectByPK(curConnectionEntity, paramUserInfo);

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

            return UserInfo;
        }

        /// <summary>
        /// 根据外键查找RH_UserInfo
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserInfoEntity" type="UserInfoEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllUserInfoByForeignKeys(Object paramConnectionEntity, UserInfoEntity paramUserInfoEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserInfoDao userInfoDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userInfoDao = new UserInfoDao();

                //执行DAO操作
                objDataTable = userInfoDao.SelectAllUserInfoByForeignKeys(curConnectionEntity, paramUserInfo);

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