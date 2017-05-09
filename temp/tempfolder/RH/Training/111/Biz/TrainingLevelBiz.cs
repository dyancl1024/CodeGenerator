using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingLevel ( RH_TrainingLevel ) Biz类
    ///</summary>
    public class TrainingLevelBiz
    {

        /// <summary>
        /// 添加RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingLevel(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelDao trainingLevelDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingLevelDao = new TrainingLevelDao();

                //执行DAO操作
                trainingLevelDao.Insert(curConnectionEntity, paramTrainingLevel);

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
        /// 修改RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingLevel(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelDao trainingLevelDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingLevelDao = new TrainingLevelDao();

                //执行DAO操作
                trainingLevelDao.Update(curConnectionEntity, paramTrainingLevel);

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
        /// 删除RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingLevel(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelDao trainingLevelDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingLevelDao = new TrainingLevelDao();

                //执行DAO操作
                trainingLevelDao.Delete(curConnectionEntity, paramTrainingLevel);

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
        /// 查看RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingLevelByPK(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelDao trainingLevelDao = null;

            TrainingLevelEntity trainingLevelEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingLevelDao = new TrainingLevelDao();

                //执行DAO操作
                trainingLevel = trainingLevelDao.SelectByPK(curConnectionEntity, paramTrainingLevel);

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

            return TrainingLevel;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingLevelByForeignKeys(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelDao trainingLevelDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingLevelDao = new TrainingLevelDao();

                //执行DAO操作
                objDataTable = trainingLevelDao.SelectAllTrainingLevelByForeignKeys(curConnectionEntity, paramTrainingLevel);

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