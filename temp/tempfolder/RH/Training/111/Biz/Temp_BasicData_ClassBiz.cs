using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Temp_BasicData_Class ( RH_Temp_BasicData_Class ) Biz类
    ///</summary>
    public class Temp_BasicData_ClassBiz
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="void"></returns>
        public void AddTemp_BasicData_Class(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_ClassDao temp_BasicData_ClassDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_ClassDao = new Temp_BasicData_ClassDao();

                //执行DAO操作
                temp_BasicData_ClassDao.Insert(curConnectionEntity, paramTemp_BasicData_Class);

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
        /// 修改RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTemp_BasicData_Class(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_ClassDao temp_BasicData_ClassDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_ClassDao = new Temp_BasicData_ClassDao();

                //执行DAO操作
                temp_BasicData_ClassDao.Update(curConnectionEntity, paramTemp_BasicData_Class);

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
        /// 删除RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTemp_BasicData_Class(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_ClassDao temp_BasicData_ClassDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_ClassDao = new Temp_BasicData_ClassDao();

                //执行DAO操作
                temp_BasicData_ClassDao.Delete(curConnectionEntity, paramTemp_BasicData_Class);

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
        /// 查看RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="void"></returns>
        public void FindTemp_BasicData_ClassByPK(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_ClassDao temp_BasicData_ClassDao = null;

            Temp_BasicData_ClassEntity temp_BasicData_ClassEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_ClassDao = new Temp_BasicData_ClassDao();

                //执行DAO操作
                temp_BasicData_Class = temp_BasicData_ClassDao.SelectByPK(curConnectionEntity, paramTemp_BasicData_Class);

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

            return Temp_BasicData_Class;
        }

        /// <summary>
        /// 根据外键查找RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_ClassEntity" type="Temp_BasicData_ClassEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTemp_BasicData_ClassByForeignKeys(Object paramConnectionEntity, Temp_BasicData_ClassEntity paramTemp_BasicData_ClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_ClassDao temp_BasicData_ClassDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_ClassDao = new Temp_BasicData_ClassDao();

                //执行DAO操作
                objDataTable = temp_BasicData_ClassDao.SelectAllTemp_BasicData_ClassByForeignKeys(curConnectionEntity, paramTemp_BasicData_Class);

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