using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Training ( RH_Training ) Biz类
    ///</summary>
    public class TrainingBiz
    {

        /// <summary>
        /// 添加RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void AddTraining(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDao trainingDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDao = new TrainingDao();

                //执行DAO操作
                trainingDao.Insert(curConnectionEntity, paramTraining);

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
        /// 修改RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTraining(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDao trainingDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDao = new TrainingDao();

                //执行DAO操作
                trainingDao.Update(curConnectionEntity, paramTraining);

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
        /// 删除RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTraining(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDao trainingDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDao = new TrainingDao();

                //执行DAO操作
                trainingDao.Delete(curConnectionEntity, paramTraining);

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
        /// 查看RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingByPK(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDao trainingDao = null;

            TrainingEntity trainingEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDao = new TrainingDao();

                //执行DAO操作
                training = trainingDao.SelectByPK(curConnectionEntity, paramTraining);

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

            return Training;
        }

        /// <summary>
        /// 根据外键查找RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingByForeignKeys(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDao trainingDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDao = new TrainingDao();

                //执行DAO操作
                objDataTable = trainingDao.SelectAllTrainingByForeignKeys(curConnectionEntity, paramTraining);

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