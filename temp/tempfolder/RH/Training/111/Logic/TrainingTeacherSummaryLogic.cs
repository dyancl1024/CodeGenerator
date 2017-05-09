using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) Logic类
    ///</summary>
    public class TrainingTeacherSummaryLogic
    {

        /// <summary>
        /// 添加RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingTeacherSummary(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryBiz trainingTeacherSummaryBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherSummaryBiz = new TrainingTeacherSummaryBiz();

                //执行Biz操作
                trainingTeacherSummaryBiz.AddTrainingTeacherSummary(curConnectionEntity, paramTrainingTeacherSummary);

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
        /// 修改RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingTeacherSummary(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryBiz trainingTeacherSummaryBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherSummaryBiz = new TrainingTeacherSummaryBiz();

                //执行Biz操作
                trainingTeacherSummaryBiz.ModifyTrainingTeacherSummary(curConnectionEntity, paramTrainingTeacherSummary);

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
        /// 删除RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingTeacherSummary(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryBiz trainingTeacherSummaryBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherSummaryBiz = new TrainingTeacherSummaryBiz();

                //执行Biz操作
                trainingTeacherSummaryBiz.RemoveTrainingTeacherSummary(curConnectionEntity, paramTrainingTeacherSummary);

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
        /// 查看RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingTeacherSummaryByPK(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryBiz trainingTeacherSummaryBiz = null;

            TrainingTeacherSummaryEntity trainingTeacherSummaryEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherSummaryBiz = new TrainingTeacherSummaryBiz();

                //执行Biz操作
                trainingTeacherSummary = trainingTeacherSummaryBiz.FindTrainingTeacherSummaryByPK(curConnectionEntity, paramTrainingTeacherSummary);

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

            return TrainingTeacherSummary;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingTeacherSummaryByForeignKeys(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherSummaryBiz trainingTeacherSummaryBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherSummaryBiz = new TrainingTeacherSummaryBiz();

                //执行Biz操作
                objDataTable = trainingTeacherSummaryBiz.FindAllTrainingTeacherSummaryByForeignKeys(curConnectionEntity, paramTrainingTeacherSummary);

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