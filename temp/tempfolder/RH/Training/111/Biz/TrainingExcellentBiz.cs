using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingExcellent ( RH_TrainingExcellent ) Biz类
    ///</summary>
    public class TrainingExcellentBiz
    {

        /// <summary>
        /// 添加RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingExcellent(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentDao trainingExcellentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExcellentDao = new TrainingExcellentDao();

                //执行DAO操作
                trainingExcellentDao.Insert(curConnectionEntity, paramTrainingExcellent);

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
        /// 修改RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingExcellent(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentDao trainingExcellentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExcellentDao = new TrainingExcellentDao();

                //执行DAO操作
                trainingExcellentDao.Update(curConnectionEntity, paramTrainingExcellent);

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
        /// 删除RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingExcellent(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentDao trainingExcellentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExcellentDao = new TrainingExcellentDao();

                //执行DAO操作
                trainingExcellentDao.Delete(curConnectionEntity, paramTrainingExcellent);

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
        /// 查看RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingExcellentByPK(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentDao trainingExcellentDao = null;

            TrainingExcellentEntity trainingExcellentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExcellentDao = new TrainingExcellentDao();

                //执行DAO操作
                trainingExcellent = trainingExcellentDao.SelectByPK(curConnectionEntity, paramTrainingExcellent);

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

            return TrainingExcellent;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingExcellentByForeignKeys(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentDao trainingExcellentDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExcellentDao = new TrainingExcellentDao();

                //执行DAO操作
                objDataTable = trainingExcellentDao.SelectAllTrainingExcellentByForeignKeys(curConnectionEntity, paramTrainingExcellent);

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