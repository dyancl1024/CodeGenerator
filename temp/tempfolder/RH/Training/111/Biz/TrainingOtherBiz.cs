using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingOther ( RH_TrainingOther ) Biz类
    ///</summary>
    public class TrainingOtherBiz
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

            TrainingOtherDao trainingOtherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingOtherDao = new TrainingOtherDao();

                //执行DAO操作
                trainingOtherDao.Insert(curConnectionEntity, paramTrainingOther);

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

            TrainingOtherDao trainingOtherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingOtherDao = new TrainingOtherDao();

                //执行DAO操作
                trainingOtherDao.Update(curConnectionEntity, paramTrainingOther);

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

            TrainingOtherDao trainingOtherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingOtherDao = new TrainingOtherDao();

                //执行DAO操作
                trainingOtherDao.Delete(curConnectionEntity, paramTrainingOther);

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

            TrainingOtherDao trainingOtherDao = null;

            TrainingOtherEntity trainingOtherEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingOtherDao = new TrainingOtherDao();

                //执行DAO操作
                trainingOther = trainingOtherDao.SelectByPK(curConnectionEntity, paramTrainingOther);

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

            TrainingOtherDao trainingOtherDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingOtherDao = new TrainingOtherDao();

                //执行DAO操作
                objDataTable = trainingOtherDao.SelectAllTrainingOtherByForeignKeys(curConnectionEntity, paramTrainingOther);

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