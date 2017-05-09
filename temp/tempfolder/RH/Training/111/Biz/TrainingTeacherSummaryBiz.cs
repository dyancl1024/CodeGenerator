using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) Biz类
    ///</summary>
    public class TrainingTeacherSummaryBiz
    {

        /// <summary>
        /// 添加RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingTeacherSummary(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryDao trainingTeacherSummaryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherSummaryDao = new TrainingTeacherSummaryDao();

                //执行DAO操作
                trainingTeacherSummaryDao.Insert(curConnectionEntity, paramTrainingTeacherSummary);

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
        /// 修改RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingTeacherSummary(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryDao trainingTeacherSummaryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherSummaryDao = new TrainingTeacherSummaryDao();

                //执行DAO操作
                trainingTeacherSummaryDao.Update(curConnectionEntity, paramTrainingTeacherSummary);

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
        /// 删除RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingTeacherSummary(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryDao trainingTeacherSummaryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherSummaryDao = new TrainingTeacherSummaryDao();

                //执行DAO操作
                trainingTeacherSummaryDao.Delete(curConnectionEntity, paramTrainingTeacherSummary);

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
        /// 查看RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingTeacherSummaryByPK(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryDao trainingTeacherSummaryDao = null;

            TrainingTeacherSummaryEntity trainingTeacherSummaryEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherSummaryDao = new TrainingTeacherSummaryDao();

                //执行DAO操作
                trainingTeacherSummary = trainingTeacherSummaryDao.SelectByPK(curConnectionEntity, paramTrainingTeacherSummary);

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

            return TrainingTeacherSummary;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingTeacherSummaryByForeignKeys(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryDao trainingTeacherSummaryDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherSummaryDao = new TrainingTeacherSummaryDao();

                //执行DAO操作
                objDataTable = trainingTeacherSummaryDao.SelectAllTrainingTeacherSummaryByForeignKeys(curConnectionEntity, paramTrainingTeacherSummary);

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