using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TempUser ( RH_TempUser ) Biz类
    ///</summary>
    public class TempUserBiz
    {

        /// <summary>
        /// 添加RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="void"></returns>
        public void AddTempUser(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempUserDao tempUserDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempUserDao = new TempUserDao();

                //执行DAO操作
                tempUserDao.Insert(curConnectionEntity, paramTempUser);

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
        /// 修改RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTempUser(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempUserDao tempUserDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempUserDao = new TempUserDao();

                //执行DAO操作
                tempUserDao.Update(curConnectionEntity, paramTempUser);

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
        /// 删除RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTempUser(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempUserDao tempUserDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempUserDao = new TempUserDao();

                //执行DAO操作
                tempUserDao.Delete(curConnectionEntity, paramTempUser);

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
        /// 查看RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="void"></returns>
        public void FindTempUserByPK(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempUserDao tempUserDao = null;

            TempUserEntity tempUserEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempUserDao = new TempUserDao();

                //执行DAO操作
                tempUser = tempUserDao.SelectByPK(curConnectionEntity, paramTempUser);

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

            return TempUser;
        }

        /// <summary>
        /// 根据外键查找RH_TempUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempUserEntity" type="TempUserEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTempUserByForeignKeys(Object paramConnectionEntity, TempUserEntity paramTempUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempUserDao tempUserDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempUserDao = new TempUserDao();

                //执行DAO操作
                objDataTable = tempUserDao.SelectAllTempUserByForeignKeys(curConnectionEntity, paramTempUser);

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