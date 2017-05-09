using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_User ( RH_User ) Logic类
    ///</summary>
    public class UserLogic
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

            UserBiz userBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userBiz = new UserBiz();

                //执行Biz操作
                userBiz.AddUser(curConnectionEntity, paramUser);

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

            UserBiz userBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userBiz = new UserBiz();

                //执行Biz操作
                userBiz.ModifyUser(curConnectionEntity, paramUser);

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

            UserBiz userBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userBiz = new UserBiz();

                //执行Biz操作
                userBiz.RemoveUser(curConnectionEntity, paramUser);

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

            UserBiz userBiz = null;

            UserEntity userEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userBiz = new UserBiz();

                //执行Biz操作
                user = userBiz.FindUserByPK(curConnectionEntity, paramUser);

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

            UserBiz userBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userBiz = new UserBiz();

                //执行Biz操作
                objDataTable = userBiz.FindAllUserByForeignKeys(curConnectionEntity, paramUser);

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