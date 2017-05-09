using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingStudyGroupComment ( RH_TrainingStudyGroupComment ) Logic类
    ///</summary>
    public class TrainingStudyGroupCommentLogic
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

            TrainingStudyGroupCommentBiz trainingStudyGroupCommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupCommentBiz = new TrainingStudyGroupCommentBiz();

                //执行Biz操作
                trainingStudyGroupCommentBiz.AddTrainingStudyGroupComment(curConnectionEntity, paramTrainingStudyGroupComment);

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

            TrainingStudyGroupCommentBiz trainingStudyGroupCommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupCommentBiz = new TrainingStudyGroupCommentBiz();

                //执行Biz操作
                trainingStudyGroupCommentBiz.ModifyTrainingStudyGroupComment(curConnectionEntity, paramTrainingStudyGroupComment);

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

            TrainingStudyGroupCommentBiz trainingStudyGroupCommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupCommentBiz = new TrainingStudyGroupCommentBiz();

                //执行Biz操作
                trainingStudyGroupCommentBiz.RemoveTrainingStudyGroupComment(curConnectionEntity, paramTrainingStudyGroupComment);

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

            TrainingStudyGroupCommentBiz trainingStudyGroupCommentBiz = null;

            TrainingStudyGroupCommentEntity trainingStudyGroupCommentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupCommentBiz = new TrainingStudyGroupCommentBiz();

                //执行Biz操作
                trainingStudyGroupComment = trainingStudyGroupCommentBiz.FindTrainingStudyGroupCommentByPK(curConnectionEntity, paramTrainingStudyGroupComment);

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

            TrainingStudyGroupCommentBiz trainingStudyGroupCommentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupCommentBiz = new TrainingStudyGroupCommentBiz();

                //执行Biz操作
                objDataTable = trainingStudyGroupCommentBiz.FindAllTrainingStudyGroupCommentByForeignKeys(curConnectionEntity, paramTrainingStudyGroupComment);

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