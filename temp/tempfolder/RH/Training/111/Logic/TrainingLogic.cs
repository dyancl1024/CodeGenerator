using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Training ( RH_Training ) Logic类
    ///</summary>
    public class TrainingLogic
    {

        /// <summary>
        /// 添加RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void AddTraining(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBiz trainingBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBiz = new TrainingBiz();

                //执行Biz操作
                trainingBiz.AddTraining(curConnectionEntity, paramTraining);

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
        /// 修改RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTraining(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBiz trainingBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBiz = new TrainingBiz();

                //执行Biz操作
                trainingBiz.ModifyTraining(curConnectionEntity, paramTraining);

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
        /// 删除RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTraining(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBiz trainingBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBiz = new TrainingBiz();

                //执行Biz操作
                trainingBiz.RemoveTraining(curConnectionEntity, paramTraining);

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
        /// 查看RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingByPK(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBiz trainingBiz = null;

            TrainingEntity trainingEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBiz = new TrainingBiz();

                //执行Biz操作
                training = trainingBiz.FindTrainingByPK(curConnectionEntity, paramTraining);

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

            return Training;
        }

        /// <summary>
        /// 根据外键查找RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingByForeignKeys(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingBiz trainingBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingBiz = new TrainingBiz();

                //执行Biz操作
                objDataTable = trainingBiz.FindAllTrainingByForeignKeys(curConnectionEntity, paramTraining);

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