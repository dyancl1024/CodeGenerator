using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingExpertQA ( RH_TrainingExpertQA ) Biz类
    ///</summary>
    public class TrainingExpertQABiz
    {

        /// <summary>
        /// 添加RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingExpertQA(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQADao trainingExpertQADao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertQADao = new TrainingExpertQADao();

                //执行DAO操作
                trainingExpertQADao.Insert(curConnectionEntity, paramTrainingExpertQA);

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
        /// 修改RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingExpertQA(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQADao trainingExpertQADao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertQADao = new TrainingExpertQADao();

                //执行DAO操作
                trainingExpertQADao.Update(curConnectionEntity, paramTrainingExpertQA);

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
        /// 删除RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingExpertQA(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQADao trainingExpertQADao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertQADao = new TrainingExpertQADao();

                //执行DAO操作
                trainingExpertQADao.Delete(curConnectionEntity, paramTrainingExpertQA);

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
        /// 查看RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingExpertQAByPK(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQADao trainingExpertQADao = null;

            TrainingExpertQAEntity trainingExpertQAEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertQADao = new TrainingExpertQADao();

                //执行DAO操作
                trainingExpertQA = trainingExpertQADao.SelectByPK(curConnectionEntity, paramTrainingExpertQA);

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

            return TrainingExpertQA;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingExpertQAByForeignKeys(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQADao trainingExpertQADao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertQADao = new TrainingExpertQADao();

                //执行DAO操作
                objDataTable = trainingExpertQADao.SelectAllTrainingExpertQAByForeignKeys(curConnectionEntity, paramTrainingExpertQA);

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