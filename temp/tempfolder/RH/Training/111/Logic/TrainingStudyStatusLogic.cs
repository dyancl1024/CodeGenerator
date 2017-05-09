using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingStudyStatus ( RH_TrainingStudyStatus ) Logic类
    ///</summary>
    public class TrainingStudyStatusLogic
    {

        /// <summary>
        /// 添加RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingStudyStatus(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusBiz trainingStudyStatusBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyStatusBiz = new TrainingStudyStatusBiz();

                //执行Biz操作
                trainingStudyStatusBiz.AddTrainingStudyStatus(curConnectionEntity, paramTrainingStudyStatus);

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
        /// 修改RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingStudyStatus(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusBiz trainingStudyStatusBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyStatusBiz = new TrainingStudyStatusBiz();

                //执行Biz操作
                trainingStudyStatusBiz.ModifyTrainingStudyStatus(curConnectionEntity, paramTrainingStudyStatus);

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
        /// 删除RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingStudyStatus(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusBiz trainingStudyStatusBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyStatusBiz = new TrainingStudyStatusBiz();

                //执行Biz操作
                trainingStudyStatusBiz.RemoveTrainingStudyStatus(curConnectionEntity, paramTrainingStudyStatus);

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
        /// 查看RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingStudyStatusByPK(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusBiz trainingStudyStatusBiz = null;

            TrainingStudyStatusEntity trainingStudyStatusEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyStatusBiz = new TrainingStudyStatusBiz();

                //执行Biz操作
                trainingStudyStatus = trainingStudyStatusBiz.FindTrainingStudyStatusByPK(curConnectionEntity, paramTrainingStudyStatus);

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

            return TrainingStudyStatus;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingStudyStatusByForeignKeys(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyStatusBiz trainingStudyStatusBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyStatusBiz = new TrainingStudyStatusBiz();

                //执行Biz操作
                objDataTable = trainingStudyStatusBiz.FindAllTrainingStudyStatusByForeignKeys(curConnectionEntity, paramTrainingStudyStatus);

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