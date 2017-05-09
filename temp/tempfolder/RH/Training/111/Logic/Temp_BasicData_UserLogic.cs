using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Temp_BasicData_User ( RH_Temp_BasicData_User ) Logic类
    ///</summary>
    public class Temp_BasicData_UserLogic
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="void"></returns>
        public void AddTemp_BasicData_User(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_UserBiz temp_BasicData_UserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_UserBiz = new Temp_BasicData_UserBiz();

                //执行Biz操作
                temp_BasicData_UserBiz.AddTemp_BasicData_User(curConnectionEntity, paramTemp_BasicData_User);

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
        /// 修改RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTemp_BasicData_User(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_UserBiz temp_BasicData_UserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_UserBiz = new Temp_BasicData_UserBiz();

                //执行Biz操作
                temp_BasicData_UserBiz.ModifyTemp_BasicData_User(curConnectionEntity, paramTemp_BasicData_User);

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
        /// 删除RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTemp_BasicData_User(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_UserBiz temp_BasicData_UserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_UserBiz = new Temp_BasicData_UserBiz();

                //执行Biz操作
                temp_BasicData_UserBiz.RemoveTemp_BasicData_User(curConnectionEntity, paramTemp_BasicData_User);

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
        /// 查看RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="void"></returns>
        public void FindTemp_BasicData_UserByPK(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_UserBiz temp_BasicData_UserBiz = null;

            Temp_BasicData_UserEntity temp_BasicData_UserEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_UserBiz = new Temp_BasicData_UserBiz();

                //执行Biz操作
                temp_BasicData_User = temp_BasicData_UserBiz.FindTemp_BasicData_UserByPK(curConnectionEntity, paramTemp_BasicData_User);

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

            return Temp_BasicData_User;
        }

        /// <summary>
        /// 根据外键查找RH_Temp_BasicData_User
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_UserEntity" type="Temp_BasicData_UserEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTemp_BasicData_UserByForeignKeys(Object paramConnectionEntity, Temp_BasicData_UserEntity paramTemp_BasicData_UserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_UserBiz temp_BasicData_UserBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_UserBiz = new Temp_BasicData_UserBiz();

                //执行Biz操作
                objDataTable = temp_BasicData_UserBiz.FindAllTemp_BasicData_UserByForeignKeys(curConnectionEntity, paramTemp_BasicData_User);

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