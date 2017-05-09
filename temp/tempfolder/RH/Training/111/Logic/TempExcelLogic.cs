using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TempExcel ( RH_TempExcel ) Logic类
    ///</summary>
    public class TempExcelLogic
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

            TempExcelBiz tempExcelBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempExcelBiz = new TempExcelBiz();

                //执行Biz操作
                tempExcelBiz.AddTempExcel(curConnectionEntity, paramTempExcel);

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

            TempExcelBiz tempExcelBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempExcelBiz = new TempExcelBiz();

                //执行Biz操作
                tempExcelBiz.ModifyTempExcel(curConnectionEntity, paramTempExcel);

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

            TempExcelBiz tempExcelBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempExcelBiz = new TempExcelBiz();

                //执行Biz操作
                tempExcelBiz.RemoveTempExcel(curConnectionEntity, paramTempExcel);

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

            TempExcelBiz tempExcelBiz = null;

            TempExcelEntity tempExcelEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempExcelBiz = new TempExcelBiz();

                //执行Biz操作
                tempExcel = tempExcelBiz.FindTempExcelByPK(curConnectionEntity, paramTempExcel);

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

            TempExcelBiz tempExcelBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                tempExcelBiz = new TempExcelBiz();

                //执行Biz操作
                objDataTable = tempExcelBiz.FindAllTempExcelByForeignKeys(curConnectionEntity, paramTempExcel);

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