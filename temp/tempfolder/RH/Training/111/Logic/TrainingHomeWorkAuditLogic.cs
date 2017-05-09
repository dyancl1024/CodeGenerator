using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingHomeWorkAudit ( RH_TrainingHomeWorkAudit ) Logic类
    ///</summary>
    public class TrainingHomeWorkAuditLogic
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

            TrainingHomeWorkAuditBiz trainingHomeWorkAuditBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAuditBiz = new TrainingHomeWorkAuditBiz();

                //执行Biz操作
                trainingHomeWorkAuditBiz.AddTrainingHomeWorkAudit(curConnectionEntity, paramTrainingHomeWorkAudit);

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

            TrainingHomeWorkAuditBiz trainingHomeWorkAuditBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAuditBiz = new TrainingHomeWorkAuditBiz();

                //执行Biz操作
                trainingHomeWorkAuditBiz.ModifyTrainingHomeWorkAudit(curConnectionEntity, paramTrainingHomeWorkAudit);

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

            TrainingHomeWorkAuditBiz trainingHomeWorkAuditBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAuditBiz = new TrainingHomeWorkAuditBiz();

                //执行Biz操作
                trainingHomeWorkAuditBiz.RemoveTrainingHomeWorkAudit(curConnectionEntity, paramTrainingHomeWorkAudit);

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

            TrainingHomeWorkAuditBiz trainingHomeWorkAuditBiz = null;

            TrainingHomeWorkAuditEntity trainingHomeWorkAuditEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAuditBiz = new TrainingHomeWorkAuditBiz();

                //执行Biz操作
                trainingHomeWorkAudit = trainingHomeWorkAuditBiz.FindTrainingHomeWorkAuditByPK(curConnectionEntity, paramTrainingHomeWorkAudit);

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

            TrainingHomeWorkAuditBiz trainingHomeWorkAuditBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkAuditBiz = new TrainingHomeWorkAuditBiz();

                //执行Biz操作
                objDataTable = trainingHomeWorkAuditBiz.FindAllTrainingHomeWorkAuditByForeignKeys(curConnectionEntity, paramTrainingHomeWorkAudit);

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