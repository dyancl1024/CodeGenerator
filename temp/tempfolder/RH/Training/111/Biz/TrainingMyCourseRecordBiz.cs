using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingMyCourseRecord ( RH_TrainingMyCourseRecord ) Biz类
    ///</summary>
    public class TrainingMyCourseRecordBiz
    {

        /// <summary>
        /// 添加RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingMyCourseRecord(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordDao trainingMyCourseRecordDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyCourseRecordDao = new TrainingMyCourseRecordDao();

                //执行DAO操作
                trainingMyCourseRecordDao.Insert(curConnectionEntity, paramTrainingMyCourseRecord);

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
        /// 修改RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingMyCourseRecord(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordDao trainingMyCourseRecordDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyCourseRecordDao = new TrainingMyCourseRecordDao();

                //执行DAO操作
                trainingMyCourseRecordDao.Update(curConnectionEntity, paramTrainingMyCourseRecord);

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
        /// 删除RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingMyCourseRecord(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordDao trainingMyCourseRecordDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyCourseRecordDao = new TrainingMyCourseRecordDao();

                //执行DAO操作
                trainingMyCourseRecordDao.Delete(curConnectionEntity, paramTrainingMyCourseRecord);

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
        /// 查看RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingMyCourseRecordByPK(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordDao trainingMyCourseRecordDao = null;

            TrainingMyCourseRecordEntity trainingMyCourseRecordEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyCourseRecordDao = new TrainingMyCourseRecordDao();

                //执行DAO操作
                trainingMyCourseRecord = trainingMyCourseRecordDao.SelectByPK(curConnectionEntity, paramTrainingMyCourseRecord);

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

            return TrainingMyCourseRecord;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingMyCourseRecordByForeignKeys(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordDao trainingMyCourseRecordDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyCourseRecordDao = new TrainingMyCourseRecordDao();

                //执行DAO操作
                objDataTable = trainingMyCourseRecordDao.SelectAllTrainingMyCourseRecordByForeignKeys(curConnectionEntity, paramTrainingMyCourseRecord);

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