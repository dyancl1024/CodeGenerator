using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) Logic类
    ///</summary>
    public class TrainingBriefingLogic
    {

        /// <summary>
        /// 添加RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingBriefing(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingBiz trainingBriefingBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingBiz = new TrainingBriefingBiz();

                //执行Biz操作
                trainingBriefingBiz.AddTrainingBriefing(curConnectionEntity, paramTrainingBriefing);

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
        /// 修改RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingBriefing(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingBiz trainingBriefingBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingBiz = new TrainingBriefingBiz();

                //执行Biz操作
                trainingBriefingBiz.ModifyTrainingBriefing(curConnectionEntity, paramTrainingBriefing);

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
        /// 删除RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingBriefing(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingBiz trainingBriefingBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingBiz = new TrainingBriefingBiz();

                //执行Biz操作
                trainingBriefingBiz.RemoveTrainingBriefing(curConnectionEntity, paramTrainingBriefing);

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
        /// 查看RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingBriefingByPK(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingBiz trainingBriefingBiz = null;

            TrainingBriefingEntity trainingBriefingEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingBiz = new TrainingBriefingBiz();

                //执行Biz操作
                trainingBriefing = trainingBriefingBiz.FindTrainingBriefingByPK(curConnectionEntity, paramTrainingBriefing);

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

            return TrainingBriefing;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingBriefingByForeignKeys(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBriefingBiz trainingBriefingBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBriefingBiz = new TrainingBriefingBiz();

                //执行Biz操作
                objDataTable = trainingBriefingBiz.FindAllTrainingBriefingByForeignKeys(curConnectionEntity, paramTrainingBriefing);

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