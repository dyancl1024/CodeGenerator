using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingSubSubject ( RH_TrainingSubSubject ) Biz类
    ///</summary>
    public class TrainingSubSubjectBiz
    {

        /// <summary>
        /// 添加RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingSubSubject(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectDao trainingSubSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubSubjectDao = new TrainingSubSubjectDao();

                //执行DAO操作
                trainingSubSubjectDao.Insert(curConnectionEntity, paramTrainingSubSubject);

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
        /// 修改RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingSubSubject(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectDao trainingSubSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubSubjectDao = new TrainingSubSubjectDao();

                //执行DAO操作
                trainingSubSubjectDao.Update(curConnectionEntity, paramTrainingSubSubject);

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
        /// 删除RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingSubSubject(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectDao trainingSubSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubSubjectDao = new TrainingSubSubjectDao();

                //执行DAO操作
                trainingSubSubjectDao.Delete(curConnectionEntity, paramTrainingSubSubject);

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
        /// 查看RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingSubSubjectByPK(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectDao trainingSubSubjectDao = null;

            TrainingSubSubjectEntity trainingSubSubjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubSubjectDao = new TrainingSubSubjectDao();

                //执行DAO操作
                trainingSubSubject = trainingSubSubjectDao.SelectByPK(curConnectionEntity, paramTrainingSubSubject);

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

            return TrainingSubSubject;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingSubSubjectByForeignKeys(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectDao trainingSubSubjectDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingSubSubjectDao = new TrainingSubSubjectDao();

                //执行DAO操作
                objDataTable = trainingSubSubjectDao.SelectAllTrainingSubSubjectByForeignKeys(curConnectionEntity, paramTrainingSubSubject);

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