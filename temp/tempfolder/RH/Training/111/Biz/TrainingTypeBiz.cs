using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingType ( RH_TrainingType ) Biz类
    ///</summary>
    public class TrainingTypeBiz
    {

        /// <summary>
        /// 添加RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingType(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeDao trainingTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTypeDao = new TrainingTypeDao();

                //执行DAO操作
                trainingTypeDao.Insert(curConnectionEntity, paramTrainingType);

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
        /// 修改RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingType(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeDao trainingTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTypeDao = new TrainingTypeDao();

                //执行DAO操作
                trainingTypeDao.Update(curConnectionEntity, paramTrainingType);

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
        /// 删除RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingType(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeDao trainingTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTypeDao = new TrainingTypeDao();

                //执行DAO操作
                trainingTypeDao.Delete(curConnectionEntity, paramTrainingType);

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
        /// 查看RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingTypeByPK(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeDao trainingTypeDao = null;

            TrainingTypeEntity trainingTypeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTypeDao = new TrainingTypeDao();

                //执行DAO操作
                trainingType = trainingTypeDao.SelectByPK(curConnectionEntity, paramTrainingType);

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

            return TrainingType;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingTypeByForeignKeys(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeDao trainingTypeDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTypeDao = new TrainingTypeDao();

                //执行DAO操作
                objDataTable = trainingTypeDao.SelectAllTrainingTypeByForeignKeys(curConnectionEntity, paramTrainingType);

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