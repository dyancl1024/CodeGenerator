using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingSub ( RH_TrainingSub ) Biz类
    ///</summary>
    public class TrainingSubBiz
    {

        /// <summary>
        /// 添加RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingSub(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubDao trainingSubDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubDao = new TrainingSubDao();

                //执行DAO操作
                trainingSubDao.Insert(curConnectionEntity, paramTrainingSub);

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
        /// 修改RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingSub(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubDao trainingSubDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubDao = new TrainingSubDao();

                //执行DAO操作
                trainingSubDao.Update(curConnectionEntity, paramTrainingSub);

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
        /// 删除RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingSub(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubDao trainingSubDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubDao = new TrainingSubDao();

                //执行DAO操作
                trainingSubDao.Delete(curConnectionEntity, paramTrainingSub);

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
        /// 查看RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingSubByPK(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubDao trainingSubDao = null;

            TrainingSubEntity trainingSubEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubDao = new TrainingSubDao();

                //执行DAO操作
                trainingSub = trainingSubDao.SelectByPK(curConnectionEntity, paramTrainingSub);

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

            return TrainingSub;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingSubByForeignKeys(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubDao trainingSubDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubDao = new TrainingSubDao();

                //执行DAO操作
                objDataTable = trainingSubDao.SelectAllTrainingSubByForeignKeys(curConnectionEntity, paramTrainingSub);

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