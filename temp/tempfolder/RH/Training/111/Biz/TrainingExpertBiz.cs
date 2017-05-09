using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingExpert ( RH_TrainingExpert ) Biz类
    ///</summary>
    public class TrainingExpertBiz
    {

        /// <summary>
        /// 添加RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingExpert(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertDao trainingExpertDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertDao = new TrainingExpertDao();

                //执行DAO操作
                trainingExpertDao.Insert(curConnectionEntity, paramTrainingExpert);

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
        /// 修改RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingExpert(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertDao trainingExpertDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertDao = new TrainingExpertDao();

                //执行DAO操作
                trainingExpertDao.Update(curConnectionEntity, paramTrainingExpert);

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
        /// 删除RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingExpert(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertDao trainingExpertDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertDao = new TrainingExpertDao();

                //执行DAO操作
                trainingExpertDao.Delete(curConnectionEntity, paramTrainingExpert);

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
        /// 查看RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingExpertByPK(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertDao trainingExpertDao = null;

            TrainingExpertEntity trainingExpertEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertDao = new TrainingExpertDao();

                //执行DAO操作
                trainingExpert = trainingExpertDao.SelectByPK(curConnectionEntity, paramTrainingExpert);

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

            return TrainingExpert;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingExpertByForeignKeys(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertDao trainingExpertDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingExpertDao = new TrainingExpertDao();

                //执行DAO操作
                objDataTable = trainingExpertDao.SelectAllTrainingExpertByForeignKeys(curConnectionEntity, paramTrainingExpert);

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