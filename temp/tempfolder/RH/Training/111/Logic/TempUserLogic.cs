using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TempUser ( RH_TempUser ) Logic类
    ///</summary>
    public class TempUserLogic
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

            TempUserBiz tempUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempUserBiz = new TempUserBiz();

                //执行Biz操作
                tempUserBiz.AddTempUser(curConnectionEntity, paramTempUser);

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

            TempUserBiz tempUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempUserBiz = new TempUserBiz();

                //执行Biz操作
                tempUserBiz.ModifyTempUser(curConnectionEntity, paramTempUser);

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

            TempUserBiz tempUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempUserBiz = new TempUserBiz();

                //执行Biz操作
                tempUserBiz.RemoveTempUser(curConnectionEntity, paramTempUser);

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

            TempUserBiz tempUserBiz = null;

            TempUserEntity tempUserEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempUserBiz = new TempUserBiz();

                //执行Biz操作
                tempUser = tempUserBiz.FindTempUserByPK(curConnectionEntity, paramTempUser);

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

            TempUserBiz tempUserBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempUserBiz = new TempUserBiz();

                //执行Biz操作
                objDataTable = tempUserBiz.FindAllTempUserByForeignKeys(curConnectionEntity, paramTempUser);

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