using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Temp_BasicData_TrainingSub ( RH_Temp_BasicData_TrainingSub ) Biz类
    ///</summary>
    public class Temp_BasicData_TrainingSubBiz
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void AddTemp_BasicData_TrainingSub(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubDao temp_BasicData_TrainingSubDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_TrainingSubDao = new Temp_BasicData_TrainingSubDao();

                //执行DAO操作
                temp_BasicData_TrainingSubDao.Insert(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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
        /// 修改RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTemp_BasicData_TrainingSub(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubDao temp_BasicData_TrainingSubDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_TrainingSubDao = new Temp_BasicData_TrainingSubDao();

                //执行DAO操作
                temp_BasicData_TrainingSubDao.Update(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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
        /// 删除RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTemp_BasicData_TrainingSub(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubDao temp_BasicData_TrainingSubDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_TrainingSubDao = new Temp_BasicData_TrainingSubDao();

                //执行DAO操作
                temp_BasicData_TrainingSubDao.Delete(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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
        /// 查看RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void FindTemp_BasicData_TrainingSubByPK(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubDao temp_BasicData_TrainingSubDao = null;

            Temp_BasicData_TrainingSubEntity temp_BasicData_TrainingSubEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_TrainingSubDao = new Temp_BasicData_TrainingSubDao();

                //执行DAO操作
                temp_BasicData_TrainingSub = temp_BasicData_TrainingSubDao.SelectByPK(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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

            return Temp_BasicData_TrainingSub;
        }

        /// <summary>
        /// 根据外键查找RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTemp_BasicData_TrainingSubByForeignKeys(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubDao temp_BasicData_TrainingSubDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                temp_BasicData_TrainingSubDao = new Temp_BasicData_TrainingSubDao();

                //执行DAO操作
                objDataTable = temp_BasicData_TrainingSubDao.SelectAllTemp_BasicData_TrainingSubByForeignKeys(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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