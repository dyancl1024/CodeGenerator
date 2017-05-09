using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingHomeWorkAttachment ( RH_TrainingHomeWorkAttachment ) Biz类
    ///</summary>
    public class TrainingHomeWorkAttachmentBiz
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingHomeWorkAttachment(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAttachmentDao trainingHomeWorkAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAttachmentDao = new TrainingHomeWorkAttachmentDao();

                //执行DAO操作
                trainingHomeWorkAttachmentDao.Insert(curConnectionEntity, paramTrainingHomeWorkAttachment);

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
        /// 修改RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingHomeWorkAttachment(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAttachmentDao trainingHomeWorkAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAttachmentDao = new TrainingHomeWorkAttachmentDao();

                //执行DAO操作
                trainingHomeWorkAttachmentDao.Update(curConnectionEntity, paramTrainingHomeWorkAttachment);

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
        /// 删除RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingHomeWorkAttachment(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAttachmentDao trainingHomeWorkAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAttachmentDao = new TrainingHomeWorkAttachmentDao();

                //执行DAO操作
                trainingHomeWorkAttachmentDao.Delete(curConnectionEntity, paramTrainingHomeWorkAttachment);

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
        /// 查看RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingHomeWorkAttachmentByPK(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAttachmentDao trainingHomeWorkAttachmentDao = null;

            TrainingHomeWorkAttachmentEntity trainingHomeWorkAttachmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAttachmentDao = new TrainingHomeWorkAttachmentDao();

                //执行DAO操作
                trainingHomeWorkAttachment = trainingHomeWorkAttachmentDao.SelectByPK(curConnectionEntity, paramTrainingHomeWorkAttachment);

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

            return TrainingHomeWorkAttachment;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingHomeWorkAttachmentByForeignKeys(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkAttachmentDao trainingHomeWorkAttachmentDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkAttachmentDao = new TrainingHomeWorkAttachmentDao();

                //执行DAO操作
                objDataTable = trainingHomeWorkAttachmentDao.SelectAllTrainingHomeWorkAttachmentByForeignKeys(curConnectionEntity, paramTrainingHomeWorkAttachment);

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