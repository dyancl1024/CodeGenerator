using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingOtherAttachment ( RH_TrainingOtherAttachment ) Logic类
    ///</summary>
    public class TrainingOtherAttachmentLogic
    {

        /// <summary>
        /// 添加RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingOtherAttachment(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherAttachmentBiz trainingOtherAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherAttachmentBiz = new TrainingOtherAttachmentBiz();

                //执行Biz操作
                trainingOtherAttachmentBiz.AddTrainingOtherAttachment(curConnectionEntity, paramTrainingOtherAttachment);

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
        /// 修改RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingOtherAttachment(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherAttachmentBiz trainingOtherAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherAttachmentBiz = new TrainingOtherAttachmentBiz();

                //执行Biz操作
                trainingOtherAttachmentBiz.ModifyTrainingOtherAttachment(curConnectionEntity, paramTrainingOtherAttachment);

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
        /// 删除RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingOtherAttachment(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherAttachmentBiz trainingOtherAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherAttachmentBiz = new TrainingOtherAttachmentBiz();

                //执行Biz操作
                trainingOtherAttachmentBiz.RemoveTrainingOtherAttachment(curConnectionEntity, paramTrainingOtherAttachment);

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
        /// 查看RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingOtherAttachmentByPK(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherAttachmentBiz trainingOtherAttachmentBiz = null;

            TrainingOtherAttachmentEntity trainingOtherAttachmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherAttachmentBiz = new TrainingOtherAttachmentBiz();

                //执行Biz操作
                trainingOtherAttachment = trainingOtherAttachmentBiz.FindTrainingOtherAttachmentByPK(curConnectionEntity, paramTrainingOtherAttachment);

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

            return TrainingOtherAttachment;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingOtherAttachmentByForeignKeys(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherAttachmentBiz trainingOtherAttachmentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherAttachmentBiz = new TrainingOtherAttachmentBiz();

                //执行Biz操作
                objDataTable = trainingOtherAttachmentBiz.FindAllTrainingOtherAttachmentByForeignKeys(curConnectionEntity, paramTrainingOtherAttachment);

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