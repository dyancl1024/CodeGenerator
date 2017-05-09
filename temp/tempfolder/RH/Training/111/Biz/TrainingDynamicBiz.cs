using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingDynamic ( RH_TrainingDynamic ) Biz类
    ///</summary>
    public class TrainingDynamicBiz
    {

        /// <summary>
        /// 添加RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingDynamic(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicDao trainingDynamicDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDynamicDao = new TrainingDynamicDao();

                //执行DAO操作
                trainingDynamicDao.Insert(curConnectionEntity, paramTrainingDynamic);

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
        /// 修改RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingDynamic(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicDao trainingDynamicDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDynamicDao = new TrainingDynamicDao();

                //执行DAO操作
                trainingDynamicDao.Update(curConnectionEntity, paramTrainingDynamic);

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
        /// 删除RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingDynamic(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicDao trainingDynamicDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDynamicDao = new TrainingDynamicDao();

                //执行DAO操作
                trainingDynamicDao.Delete(curConnectionEntity, paramTrainingDynamic);

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
        /// 查看RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingDynamicByPK(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicDao trainingDynamicDao = null;

            TrainingDynamicEntity trainingDynamicEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDynamicDao = new TrainingDynamicDao();

                //执行DAO操作
                trainingDynamic = trainingDynamicDao.SelectByPK(curConnectionEntity, paramTrainingDynamic);

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

            return TrainingDynamic;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingDynamicByForeignKeys(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicDao trainingDynamicDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingDynamicDao = new TrainingDynamicDao();

                //执行DAO操作
                objDataTable = trainingDynamicDao.SelectAllTrainingDynamicByForeignKeys(curConnectionEntity, paramTrainingDynamic);

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