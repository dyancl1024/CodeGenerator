using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingPhase ( RH_TrainingPhase ) Biz类
    ///</summary>
    public class TrainingPhaseBiz
    {

        /// <summary>
        /// 添加RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingPhase(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseDao trainingPhaseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingPhaseDao = new TrainingPhaseDao();

                //执行DAO操作
                trainingPhaseDao.Insert(curConnectionEntity, paramTrainingPhase);

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
        /// 修改RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingPhase(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseDao trainingPhaseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingPhaseDao = new TrainingPhaseDao();

                //执行DAO操作
                trainingPhaseDao.Update(curConnectionEntity, paramTrainingPhase);

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
        /// 删除RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingPhase(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseDao trainingPhaseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingPhaseDao = new TrainingPhaseDao();

                //执行DAO操作
                trainingPhaseDao.Delete(curConnectionEntity, paramTrainingPhase);

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
        /// 查看RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingPhaseByPK(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseDao trainingPhaseDao = null;

            TrainingPhaseEntity trainingPhaseEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingPhaseDao = new TrainingPhaseDao();

                //执行DAO操作
                trainingPhase = trainingPhaseDao.SelectByPK(curConnectionEntity, paramTrainingPhase);

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

            return TrainingPhase;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingPhaseByForeignKeys(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseDao trainingPhaseDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingPhaseDao = new TrainingPhaseDao();

                //执行DAO操作
                objDataTable = trainingPhaseDao.SelectAllTrainingPhaseByForeignKeys(curConnectionEntity, paramTrainingPhase);

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