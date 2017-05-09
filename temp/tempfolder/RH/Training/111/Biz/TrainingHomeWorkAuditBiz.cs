using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingHomeWorkAudit ( RH_TrainingHomeWorkAudit ) Biz类
    ///</summary>
    public class TrainingHomeWorkAuditBiz
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingHomeWorkAudit(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAuditDao trainingHomeWorkAuditDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAuditDao = new TrainingHomeWorkAuditDao();

                //执行DAO操作
                trainingHomeWorkAuditDao.Insert(curConnectionEntity, paramTrainingHomeWorkAudit);

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
        /// 修改RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingHomeWorkAudit(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAuditDao trainingHomeWorkAuditDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAuditDao = new TrainingHomeWorkAuditDao();

                //执行DAO操作
                trainingHomeWorkAuditDao.Update(curConnectionEntity, paramTrainingHomeWorkAudit);

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
        /// 删除RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingHomeWorkAudit(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAuditDao trainingHomeWorkAuditDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAuditDao = new TrainingHomeWorkAuditDao();

                //执行DAO操作
                trainingHomeWorkAuditDao.Delete(curConnectionEntity, paramTrainingHomeWorkAudit);

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
        /// 查看RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingHomeWorkAuditByPK(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAuditDao trainingHomeWorkAuditDao = null;

            TrainingHomeWorkAuditEntity trainingHomeWorkAuditEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAuditDao = new TrainingHomeWorkAuditDao();

                //执行DAO操作
                trainingHomeWorkAudit = trainingHomeWorkAuditDao.SelectByPK(curConnectionEntity, paramTrainingHomeWorkAudit);

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

            return TrainingHomeWorkAudit;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingHomeWorkAuditByForeignKeys(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAuditDao trainingHomeWorkAuditDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAuditDao = new TrainingHomeWorkAuditDao();

                //执行DAO操作
                objDataTable = trainingHomeWorkAuditDao.SelectAllTrainingHomeWorkAuditByForeignKeys(curConnectionEntity, paramTrainingHomeWorkAudit);

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