using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingEducationer ( RH_TrainingEducationer ) Biz类
    ///</summary>
    public class TrainingEducationerBiz
    {

        /// <summary>
        /// 添加RH_TrainingEducationer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEducationerEntity" type="TrainingEducationerEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingEducationer(Object paramConnectionEntity, TrainingEducationerEntity paramTrainingEducationerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingEducationerDao trainingEducationerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingEducationerDao = new TrainingEducationerDao();

                //执行DAO操作
                trainingEducationerDao.Insert(curConnectionEntity, paramTrainingEducationer);

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
        /// 修改RH_TrainingEducationer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEducationerEntity" type="TrainingEducationerEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingEducationer(Object paramConnectionEntity, TrainingEducationerEntity paramTrainingEducationerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingEducationerDao trainingEducationerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingEducationerDao = new TrainingEducationerDao();

                //执行DAO操作
                trainingEducationerDao.Update(curConnectionEntity, paramTrainingEducationer);

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
        /// 删除RH_TrainingEducationer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEducationerEntity" type="TrainingEducationerEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingEducationer(Object paramConnectionEntity, TrainingEducationerEntity paramTrainingEducationerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingEducationerDao trainingEducationerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingEducationerDao = new TrainingEducationerDao();

                //执行DAO操作
                trainingEducationerDao.Delete(curConnectionEntity, paramTrainingEducationer);

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
        /// 查看RH_TrainingEducationer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEducationerEntity" type="TrainingEducationerEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingEducationerByPK(Object paramConnectionEntity, TrainingEducationerEntity paramTrainingEducationerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingEducationerDao trainingEducationerDao = null;

            TrainingEducationerEntity trainingEducationerEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingEducationerDao = new TrainingEducationerDao();

                //执行DAO操作
                trainingEducationer = trainingEducationerDao.SelectByPK(curConnectionEntity, paramTrainingEducationer);

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

            return TrainingEducationer;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingEducationer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEducationerEntity" type="TrainingEducationerEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingEducationerByForeignKeys(Object paramConnectionEntity, TrainingEducationerEntity paramTrainingEducationerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingEducationerDao trainingEducationerDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingEducationerDao = new TrainingEducationerDao();

                //执行DAO操作
                objDataTable = trainingEducationerDao.SelectAllTrainingEducationerByForeignKeys(curConnectionEntity, paramTrainingEducationer);

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