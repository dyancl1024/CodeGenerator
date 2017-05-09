using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingStudyGroup ( RH_TrainingStudyGroup ) Biz类
    ///</summary>
    public class TrainingStudyGroupBiz
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingStudyGroup(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupDao trainingStudyGroupDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupDao = new TrainingStudyGroupDao();

                //执行DAO操作
                trainingStudyGroupDao.Insert(curConnectionEntity, paramTrainingStudyGroup);

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
        /// 修改RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingStudyGroup(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupDao trainingStudyGroupDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupDao = new TrainingStudyGroupDao();

                //执行DAO操作
                trainingStudyGroupDao.Update(curConnectionEntity, paramTrainingStudyGroup);

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
        /// 删除RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingStudyGroup(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupDao trainingStudyGroupDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupDao = new TrainingStudyGroupDao();

                //执行DAO操作
                trainingStudyGroupDao.Delete(curConnectionEntity, paramTrainingStudyGroup);

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
        /// 查看RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingStudyGroupByPK(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupDao trainingStudyGroupDao = null;

            TrainingStudyGroupEntity trainingStudyGroupEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupDao = new TrainingStudyGroupDao();

                //执行DAO操作
                trainingStudyGroup = trainingStudyGroupDao.SelectByPK(curConnectionEntity, paramTrainingStudyGroup);

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

            return TrainingStudyGroup;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingStudyGroupByForeignKeys(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupDao trainingStudyGroupDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingStudyGroupDao = new TrainingStudyGroupDao();

                //执行DAO操作
                objDataTable = trainingStudyGroupDao.SelectAllTrainingStudyGroupByForeignKeys(curConnectionEntity, paramTrainingStudyGroup);

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