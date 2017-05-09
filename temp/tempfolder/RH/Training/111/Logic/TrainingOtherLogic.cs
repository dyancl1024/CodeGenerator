using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingOther ( RH_TrainingOther ) Logic类
    ///</summary>
    public class TrainingOtherLogic
    {

        /// <summary>
        /// 添加RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingOther(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherBiz trainingOtherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherBiz = new TrainingOtherBiz();

                //执行Biz操作
                trainingOtherBiz.AddTrainingOther(curConnectionEntity, paramTrainingOther);

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
        /// 修改RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingOther(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherBiz trainingOtherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherBiz = new TrainingOtherBiz();

                //执行Biz操作
                trainingOtherBiz.ModifyTrainingOther(curConnectionEntity, paramTrainingOther);

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
        /// 删除RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingOther(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherBiz trainingOtherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherBiz = new TrainingOtherBiz();

                //执行Biz操作
                trainingOtherBiz.RemoveTrainingOther(curConnectionEntity, paramTrainingOther);

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
        /// 查看RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingOtherByPK(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherBiz trainingOtherBiz = null;

            TrainingOtherEntity trainingOtherEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherBiz = new TrainingOtherBiz();

                //执行Biz操作
                trainingOther = trainingOtherBiz.FindTrainingOtherByPK(curConnectionEntity, paramTrainingOther);

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

            return TrainingOther;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingOtherByForeignKeys(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingOtherBiz trainingOtherBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingOtherBiz = new TrainingOtherBiz();

                //执行Biz操作
                objDataTable = trainingOtherBiz.FindAllTrainingOtherByForeignKeys(curConnectionEntity, paramTrainingOther);

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