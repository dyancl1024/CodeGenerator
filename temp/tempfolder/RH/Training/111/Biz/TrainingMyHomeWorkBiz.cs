using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingMyHomeWork ( RH_TrainingMyHomeWork ) Biz类
    ///</summary>
    public class TrainingMyHomeWorkBiz
    {

        /// <summary>
        /// 添加RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingMyHomeWork(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyHomeWorkDao trainingMyHomeWorkDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyHomeWorkDao = new TrainingMyHomeWorkDao();

                //执行DAO操作
                trainingMyHomeWorkDao.Insert(curConnectionEntity, paramTrainingMyHomeWork);

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
        /// 修改RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingMyHomeWork(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyHomeWorkDao trainingMyHomeWorkDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyHomeWorkDao = new TrainingMyHomeWorkDao();

                //执行DAO操作
                trainingMyHomeWorkDao.Update(curConnectionEntity, paramTrainingMyHomeWork);

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
        /// 删除RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingMyHomeWork(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyHomeWorkDao trainingMyHomeWorkDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyHomeWorkDao = new TrainingMyHomeWorkDao();

                //执行DAO操作
                trainingMyHomeWorkDao.Delete(curConnectionEntity, paramTrainingMyHomeWork);

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
        /// 查看RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingMyHomeWorkByPK(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyHomeWorkDao trainingMyHomeWorkDao = null;

            TrainingMyHomeWorkEntity trainingMyHomeWorkEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyHomeWorkDao = new TrainingMyHomeWorkDao();

                //执行DAO操作
                trainingMyHomeWork = trainingMyHomeWorkDao.SelectByPK(curConnectionEntity, paramTrainingMyHomeWork);

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

            return TrainingMyHomeWork;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyHomeWorkEntity" type="TrainingMyHomeWorkEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingMyHomeWorkByForeignKeys(Object paramConnectionEntity, TrainingMyHomeWorkEntity paramTrainingMyHomeWorkEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyHomeWorkDao trainingMyHomeWorkDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingMyHomeWorkDao = new TrainingMyHomeWorkDao();

                //执行DAO操作
                objDataTable = trainingMyHomeWorkDao.SelectAllTrainingMyHomeWorkByForeignKeys(curConnectionEntity, paramTrainingMyHomeWork);

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