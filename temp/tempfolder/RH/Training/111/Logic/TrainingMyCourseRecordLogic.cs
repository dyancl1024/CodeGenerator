using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingMyCourseRecord ( RH_TrainingMyCourseRecord ) Logic类
    ///</summary>
    public class TrainingMyCourseRecordLogic
    {

        /// <summary>
        /// 添加RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingMyCourseRecord(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordBiz trainingMyCourseRecordBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseRecordBiz = new TrainingMyCourseRecordBiz();

                //执行Biz操作
                trainingMyCourseRecordBiz.AddTrainingMyCourseRecord(curConnectionEntity, paramTrainingMyCourseRecord);

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
        /// 修改RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingMyCourseRecord(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordBiz trainingMyCourseRecordBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseRecordBiz = new TrainingMyCourseRecordBiz();

                //执行Biz操作
                trainingMyCourseRecordBiz.ModifyTrainingMyCourseRecord(curConnectionEntity, paramTrainingMyCourseRecord);

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
        /// 删除RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingMyCourseRecord(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordBiz trainingMyCourseRecordBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseRecordBiz = new TrainingMyCourseRecordBiz();

                //执行Biz操作
                trainingMyCourseRecordBiz.RemoveTrainingMyCourseRecord(curConnectionEntity, paramTrainingMyCourseRecord);

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
        /// 查看RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingMyCourseRecordByPK(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordBiz trainingMyCourseRecordBiz = null;

            TrainingMyCourseRecordEntity trainingMyCourseRecordEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseRecordBiz = new TrainingMyCourseRecordBiz();

                //执行Biz操作
                trainingMyCourseRecord = trainingMyCourseRecordBiz.FindTrainingMyCourseRecordByPK(curConnectionEntity, paramTrainingMyCourseRecord);

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

            return TrainingMyCourseRecord;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseRecordEntity" type="TrainingMyCourseRecordEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingMyCourseRecordByForeignKeys(Object paramConnectionEntity, TrainingMyCourseRecordEntity paramTrainingMyCourseRecordEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseRecordBiz trainingMyCourseRecordBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseRecordBiz = new TrainingMyCourseRecordBiz();

                //执行Biz操作
                objDataTable = trainingMyCourseRecordBiz.FindAllTrainingMyCourseRecordByForeignKeys(curConnectionEntity, paramTrainingMyCourseRecord);

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