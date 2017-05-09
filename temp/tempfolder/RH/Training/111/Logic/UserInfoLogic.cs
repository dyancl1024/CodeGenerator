using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_UserInfo ( RH_UserInfo ) Logic类
    ///</summary>
    public class UserInfoLogic
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

            UserInfoBiz userInfoBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userInfoBiz = new UserInfoBiz();

                //执行Biz操作
                userInfoBiz.AddUserInfo(curConnectionEntity, paramUserInfo);

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

            UserInfoBiz userInfoBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userInfoBiz = new UserInfoBiz();

                //执行Biz操作
                userInfoBiz.ModifyUserInfo(curConnectionEntity, paramUserInfo);

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

            UserInfoBiz userInfoBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userInfoBiz = new UserInfoBiz();

                //执行Biz操作
                userInfoBiz.RemoveUserInfo(curConnectionEntity, paramUserInfo);

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

            UserInfoBiz userInfoBiz = null;

            UserInfoEntity userInfoEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userInfoBiz = new UserInfoBiz();

                //执行Biz操作
                userInfo = userInfoBiz.FindUserInfoByPK(curConnectionEntity, paramUserInfo);

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

            UserInfoBiz userInfoBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userInfoBiz = new UserInfoBiz();

                //执行Biz操作
                objDataTable = userInfoBiz.FindAllUserInfoByForeignKeys(curConnectionEntity, paramUserInfo);

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