using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingStudyGroupComment ( RH_TrainingStudyGroupComment ) Biz类
    ///</summary>
    public class TrainingStudyGroupCommentBiz
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingStudyGroupComment(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupCommentDao trainingStudyGroupCommentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupCommentDao = new TrainingStudyGroupCommentDao();

                //执行DAO操作
                trainingStudyGroupCommentDao.Insert(curConnectionEntity, paramTrainingStudyGroupComment);

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
        /// 修改RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingStudyGroupComment(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupCommentDao trainingStudyGroupCommentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupCommentDao = new TrainingStudyGroupCommentDao();

                //执行DAO操作
                trainingStudyGroupCommentDao.Update(curConnectionEntity, paramTrainingStudyGroupComment);

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
        /// 删除RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingStudyGroupComment(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupCommentDao trainingStudyGroupCommentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupCommentDao = new TrainingStudyGroupCommentDao();

                //执行DAO操作
                trainingStudyGroupCommentDao.Delete(curConnectionEntity, paramTrainingStudyGroupComment);

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
        /// 查看RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingStudyGroupCommentByPK(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupCommentDao trainingStudyGroupCommentDao = null;

            TrainingStudyGroupCommentEntity trainingStudyGroupCommentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupCommentDao = new TrainingStudyGroupCommentDao();

                //执行DAO操作
                trainingStudyGroupComment = trainingStudyGroupCommentDao.SelectByPK(curConnectionEntity, paramTrainingStudyGroupComment);

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

            return TrainingStudyGroupComment;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingStudyGroupCommentByForeignKeys(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupCommentDao trainingStudyGroupCommentDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupCommentDao = new TrainingStudyGroupCommentDao();

                //执行DAO操作
                objDataTable = trainingStudyGroupCommentDao.SelectAllTrainingStudyGroupCommentByForeignKeys(curConnectionEntity, paramTrainingStudyGroupComment);

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