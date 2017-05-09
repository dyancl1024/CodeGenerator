using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingBriefingComment ( RH_TrainingBriefingComment ) Logic类
    ///</summary>
    public class TrainingBriefingCommentLogic
    {

        /// <summary>
        /// 添加RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingBriefingComment(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingCommentBiz trainingBriefingCommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingCommentBiz = new TrainingBriefingCommentBiz();

                //执行Biz操作
                trainingBriefingCommentBiz.AddTrainingBriefingComment(curConnectionEntity, paramTrainingBriefingComment);

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
        /// 修改RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingBriefingComment(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingCommentBiz trainingBriefingCommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingCommentBiz = new TrainingBriefingCommentBiz();

                //执行Biz操作
                trainingBriefingCommentBiz.ModifyTrainingBriefingComment(curConnectionEntity, paramTrainingBriefingComment);

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
        /// 删除RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingBriefingComment(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingCommentBiz trainingBriefingCommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingCommentBiz = new TrainingBriefingCommentBiz();

                //执行Biz操作
                trainingBriefingCommentBiz.RemoveTrainingBriefingComment(curConnectionEntity, paramTrainingBriefingComment);

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
        /// 查看RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingBriefingCommentByPK(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingCommentBiz trainingBriefingCommentBiz = null;

            TrainingBriefingCommentEntity trainingBriefingCommentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingCommentBiz = new TrainingBriefingCommentBiz();

                //执行Biz操作
                trainingBriefingComment = trainingBriefingCommentBiz.FindTrainingBriefingCommentByPK(curConnectionEntity, paramTrainingBriefingComment);

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

            return TrainingBriefingComment;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingBriefingCommentByForeignKeys(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingCommentBiz trainingBriefingCommentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingCommentBiz = new TrainingBriefingCommentBiz();

                //执行Biz操作
                objDataTable = trainingBriefingCommentBiz.FindAllTrainingBriefingCommentByForeignKeys(curConnectionEntity, paramTrainingBriefingComment);

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