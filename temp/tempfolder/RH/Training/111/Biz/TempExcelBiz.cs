using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TempExcel ( RH_TempExcel ) Biz类
    ///</summary>
    public class TempExcelBiz
    {

        /// <summary>
        /// 添加RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="void"></returns>
        public void AddTempExcel(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempExcelDao tempExcelDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempExcelDao = new TempExcelDao();

                //执行DAO操作
                tempExcelDao.Insert(curConnectionEntity, paramTempExcel);

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
        /// 修改RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTempExcel(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempExcelDao tempExcelDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempExcelDao = new TempExcelDao();

                //执行DAO操作
                tempExcelDao.Update(curConnectionEntity, paramTempExcel);

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
        /// 删除RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTempExcel(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempExcelDao tempExcelDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempExcelDao = new TempExcelDao();

                //执行DAO操作
                tempExcelDao.Delete(curConnectionEntity, paramTempExcel);

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
        /// 查看RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="void"></returns>
        public void FindTempExcelByPK(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempExcelDao tempExcelDao = null;

            TempExcelEntity tempExcelEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempExcelDao = new TempExcelDao();

                //执行DAO操作
                tempExcel = tempExcelDao.SelectByPK(curConnectionEntity, paramTempExcel);

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

            return TempExcel;
        }

        /// <summary>
        /// 根据外键查找RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTempExcelByForeignKeys(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TempExcelDao tempExcelDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                tempExcelDao = new TempExcelDao();

                //执行DAO操作
                objDataTable = tempExcelDao.SelectAllTempExcelByForeignKeys(curConnectionEntity, paramTempExcel);

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