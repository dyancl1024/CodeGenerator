using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingClass ( RH_TrainingClass ) Biz类
    ///</summary>
    public class TrainingClassBiz
    {

        /// <summary>
        /// 添加RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingClass(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassDao trainingClassDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassDao = new TrainingClassDao();

                //执行DAO操作
                trainingClassDao.Insert(curConnectionEntity, paramTrainingClass);

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
        /// 修改RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingClass(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassDao trainingClassDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassDao = new TrainingClassDao();

                //执行DAO操作
                trainingClassDao.Update(curConnectionEntity, paramTrainingClass);

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
        /// 删除RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingClass(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassDao trainingClassDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassDao = new TrainingClassDao();

                //执行DAO操作
                trainingClassDao.Delete(curConnectionEntity, paramTrainingClass);

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
        /// 查看RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingClassByPK(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassDao trainingClassDao = null;

            TrainingClassEntity trainingClassEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassDao = new TrainingClassDao();

                //执行DAO操作
                trainingClass = trainingClassDao.SelectByPK(curConnectionEntity, paramTrainingClass);

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

            return TrainingClass;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingClassByForeignKeys(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassDao trainingClassDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassDao = new TrainingClassDao();

                //执行DAO操作
                objDataTable = trainingClassDao.SelectAllTrainingClassByForeignKeys(curConnectionEntity, paramTrainingClass);

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