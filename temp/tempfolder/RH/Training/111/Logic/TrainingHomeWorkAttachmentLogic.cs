using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingHomeWorkAttachment ( RH_TrainingHomeWorkAttachment ) Logic类
    ///</summary>
    public class TrainingHomeWorkAttachmentLogic
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

            TrainingHomeWorkAttachmentBiz trainingHomeWorkAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAttachmentBiz = new TrainingHomeWorkAttachmentBiz();

                //执行Biz操作
                trainingHomeWorkAttachmentBiz.AddTrainingHomeWorkAttachment(curConnectionEntity, paramTrainingHomeWorkAttachment);

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

            TrainingHomeWorkAttachmentBiz trainingHomeWorkAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAttachmentBiz = new TrainingHomeWorkAttachmentBiz();

                //执行Biz操作
                trainingHomeWorkAttachmentBiz.ModifyTrainingHomeWorkAttachment(curConnectionEntity, paramTrainingHomeWorkAttachment);

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

            TrainingHomeWorkAttachmentBiz trainingHomeWorkAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAttachmentBiz = new TrainingHomeWorkAttachmentBiz();

                //执行Biz操作
                trainingHomeWorkAttachmentBiz.RemoveTrainingHomeWorkAttachment(curConnectionEntity, paramTrainingHomeWorkAttachment);

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

            TrainingHomeWorkAttachmentBiz trainingHomeWorkAttachmentBiz = null;

            TrainingHomeWorkAttachmentEntity trainingHomeWorkAttachmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAttachmentBiz = new TrainingHomeWorkAttachmentBiz();

                //执行Biz操作
                trainingHomeWorkAttachment = trainingHomeWorkAttachmentBiz.FindTrainingHomeWorkAttachmentByPK(curConnectionEntity, paramTrainingHomeWorkAttachment);

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

            TrainingHomeWorkAttachmentBiz trainingHomeWorkAttachmentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAttachmentBiz = new TrainingHomeWorkAttachmentBiz();

                //执行Biz操作
                objDataTable = trainingHomeWorkAttachmentBiz.FindAllTrainingHomeWorkAttachmentByForeignKeys(curConnectionEntity, paramTrainingHomeWorkAttachment);

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