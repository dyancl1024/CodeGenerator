using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingHomeWorkType ( RH_TrainingHomeWorkType ) Biz类
    ///</summary>
    public class TrainingHomeWorkTypeBiz
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingHomeWorkType(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeDao trainingHomeWorkTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkTypeDao = new TrainingHomeWorkTypeDao();

                //执行DAO操作
                trainingHomeWorkTypeDao.Insert(curConnectionEntity, paramTrainingHomeWorkType);

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
        /// 修改RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingHomeWorkType(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeDao trainingHomeWorkTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkTypeDao = new TrainingHomeWorkTypeDao();

                //执行DAO操作
                trainingHomeWorkTypeDao.Update(curConnectionEntity, paramTrainingHomeWorkType);

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
        /// 删除RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingHomeWorkType(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeDao trainingHomeWorkTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkTypeDao = new TrainingHomeWorkTypeDao();

                //执行DAO操作
                trainingHomeWorkTypeDao.Delete(curConnectionEntity, paramTrainingHomeWorkType);

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
        /// 查看RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingHomeWorkTypeByPK(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeDao trainingHomeWorkTypeDao = null;

            TrainingHomeWorkTypeEntity trainingHomeWorkTypeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkTypeDao = new TrainingHomeWorkTypeDao();

                //执行DAO操作
                trainingHomeWorkType = trainingHomeWorkTypeDao.SelectByPK(curConnectionEntity, paramTrainingHomeWorkType);

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

            return TrainingHomeWorkType;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingHomeWorkTypeByForeignKeys(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeDao trainingHomeWorkTypeDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingHomeWorkTypeDao = new TrainingHomeWorkTypeDao();

                //执行DAO操作
                objDataTable = trainingHomeWorkTypeDao.SelectAllTrainingHomeWorkTypeByForeignKeys(curConnectionEntity, paramTrainingHomeWorkType);

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