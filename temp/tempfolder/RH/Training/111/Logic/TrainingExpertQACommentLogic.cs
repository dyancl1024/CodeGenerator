using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingExpertQAComment ( RH_TrainingExpertQAComment ) Logic类
    ///</summary>
    public class TrainingExpertQACommentLogic
    {

        /// <summary>
        /// 添加RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingExpertQAComment(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQACommentBiz trainingExpertQACommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQACommentBiz = new TrainingExpertQACommentBiz();

                //执行Biz操作
                trainingExpertQACommentBiz.AddTrainingExpertQAComment(curConnectionEntity, paramTrainingExpertQAComment);

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
        /// 修改RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingExpertQAComment(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQACommentBiz trainingExpertQACommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQACommentBiz = new TrainingExpertQACommentBiz();

                //执行Biz操作
                trainingExpertQACommentBiz.ModifyTrainingExpertQAComment(curConnectionEntity, paramTrainingExpertQAComment);

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
        /// 删除RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingExpertQAComment(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQACommentBiz trainingExpertQACommentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQACommentBiz = new TrainingExpertQACommentBiz();

                //执行Biz操作
                trainingExpertQACommentBiz.RemoveTrainingExpertQAComment(curConnectionEntity, paramTrainingExpertQAComment);

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
        /// 查看RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingExpertQACommentByPK(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQACommentBiz trainingExpertQACommentBiz = null;

            TrainingExpertQACommentEntity trainingExpertQACommentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQACommentBiz = new TrainingExpertQACommentBiz();

                //执行Biz操作
                trainingExpertQAComment = trainingExpertQACommentBiz.FindTrainingExpertQACommentByPK(curConnectionEntity, paramTrainingExpertQAComment);

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

            return TrainingExpertQAComment;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingExpertQACommentByForeignKeys(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQACommentBiz trainingExpertQACommentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQACommentBiz = new TrainingExpertQACommentBiz();

                //执行Biz操作
                objDataTable = trainingExpertQACommentBiz.FindAllTrainingExpertQACommentByForeignKeys(curConnectionEntity, paramTrainingExpertQAComment);

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