using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) Biz类
    ///</summary>
    public class TrainingBriefingBiz
    {

        /// <summary>
        /// 添加RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingBriefing(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingDao trainingBriefingDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingBriefingDao = new TrainingBriefingDao();

                //执行DAO操作
                trainingBriefingDao.Insert(curConnectionEntity, paramTrainingBriefing);

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
        /// 修改RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingBriefing(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingDao trainingBriefingDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingBriefingDao = new TrainingBriefingDao();

                //执行DAO操作
                trainingBriefingDao.Update(curConnectionEntity, paramTrainingBriefing);

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
        /// 删除RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingBriefing(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingDao trainingBriefingDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingBriefingDao = new TrainingBriefingDao();

                //执行DAO操作
                trainingBriefingDao.Delete(curConnectionEntity, paramTrainingBriefing);

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
        /// 查看RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingBriefingByPK(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingDao trainingBriefingDao = null;

            TrainingBriefingEntity trainingBriefingEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingBriefingDao = new TrainingBriefingDao();

                //执行DAO操作
                trainingBriefing = trainingBriefingDao.SelectByPK(curConnectionEntity, paramTrainingBriefing);

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

            return TrainingBriefing;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingBriefingByForeignKeys(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingDao trainingBriefingDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingBriefingDao = new TrainingBriefingDao();

                //执行DAO操作
                objDataTable = trainingBriefingDao.SelectAllTrainingBriefingByForeignKeys(curConnectionEntity, paramTrainingBriefing);

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