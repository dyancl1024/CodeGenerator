using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingClassUserRelation ( RH_TrainingClassUserRelation ) Biz类
    ///</summary>
    public class TrainingClassUserRelationBiz
    {

        /// <summary>
        /// 添加RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingClassUserRelation(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationDao trainingClassUserRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassUserRelationDao = new TrainingClassUserRelationDao();

                //执行DAO操作
                trainingClassUserRelationDao.Insert(curConnectionEntity, paramTrainingClassUserRelation);

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
        /// 修改RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingClassUserRelation(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationDao trainingClassUserRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassUserRelationDao = new TrainingClassUserRelationDao();

                //执行DAO操作
                trainingClassUserRelationDao.Update(curConnectionEntity, paramTrainingClassUserRelation);

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
        /// 删除RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingClassUserRelation(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationDao trainingClassUserRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassUserRelationDao = new TrainingClassUserRelationDao();

                //执行DAO操作
                trainingClassUserRelationDao.Delete(curConnectionEntity, paramTrainingClassUserRelation);

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
        /// 查看RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingClassUserRelationByPK(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationDao trainingClassUserRelationDao = null;

            TrainingClassUserRelationEntity trainingClassUserRelationEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassUserRelationDao = new TrainingClassUserRelationDao();

                //执行DAO操作
                trainingClassUserRelation = trainingClassUserRelationDao.SelectByPK(curConnectionEntity, paramTrainingClassUserRelation);

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

            return TrainingClassUserRelation;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingClassUserRelationByForeignKeys(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationDao trainingClassUserRelationDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassUserRelationDao = new TrainingClassUserRelationDao();

                //执行DAO操作
                objDataTable = trainingClassUserRelationDao.SelectAllTrainingClassUserRelationByForeignKeys(curConnectionEntity, paramTrainingClassUserRelation);

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