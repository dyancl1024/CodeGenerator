using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingStudyStatus ( RH_TrainingStudyStatus ) Biz类
    ///</summary>
    public class TrainingStudyStatusBiz
    {

        /// <summary>
        /// 添加RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingStudyStatus(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusDao trainingStudyStatusDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyStatusDao = new TrainingStudyStatusDao();

                //执行DAO操作
                trainingStudyStatusDao.Insert(curConnectionEntity, paramTrainingStudyStatus);

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
        /// 修改RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingStudyStatus(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusDao trainingStudyStatusDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyStatusDao = new TrainingStudyStatusDao();

                //执行DAO操作
                trainingStudyStatusDao.Update(curConnectionEntity, paramTrainingStudyStatus);

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
        /// 删除RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingStudyStatus(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusDao trainingStudyStatusDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyStatusDao = new TrainingStudyStatusDao();

                //执行DAO操作
                trainingStudyStatusDao.Delete(curConnectionEntity, paramTrainingStudyStatus);

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
        /// 查看RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingStudyStatusByPK(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusDao trainingStudyStatusDao = null;

            TrainingStudyStatusEntity trainingStudyStatusEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyStatusDao = new TrainingStudyStatusDao();

                //执行DAO操作
                trainingStudyStatus = trainingStudyStatusDao.SelectByPK(curConnectionEntity, paramTrainingStudyStatus);

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

            return TrainingStudyStatus;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingStudyStatusByForeignKeys(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusDao trainingStudyStatusDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyStatusDao = new TrainingStudyStatusDao();

                //执行DAO操作
                objDataTable = trainingStudyStatusDao.SelectAllTrainingStudyStatusByForeignKeys(curConnectionEntity, paramTrainingStudyStatus);

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