using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingTeacher ( RH_TrainingTeacher ) Biz类
    ///</summary>
    public class TrainingTeacherBiz
    {

        /// <summary>
        /// 添加RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingTeacher(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherDao trainingTeacherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherDao = new TrainingTeacherDao();

                //执行DAO操作
                trainingTeacherDao.Insert(curConnectionEntity, paramTrainingTeacher);

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
        /// 修改RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingTeacher(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherDao trainingTeacherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherDao = new TrainingTeacherDao();

                //执行DAO操作
                trainingTeacherDao.Update(curConnectionEntity, paramTrainingTeacher);

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
        /// 删除RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingTeacher(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherDao trainingTeacherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherDao = new TrainingTeacherDao();

                //执行DAO操作
                trainingTeacherDao.Delete(curConnectionEntity, paramTrainingTeacher);

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
        /// 查看RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingTeacherByPK(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherDao trainingTeacherDao = null;

            TrainingTeacherEntity trainingTeacherEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherDao = new TrainingTeacherDao();

                //执行DAO操作
                trainingTeacher = trainingTeacherDao.SelectByPK(curConnectionEntity, paramTrainingTeacher);

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

            return TrainingTeacher;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingTeacherByForeignKeys(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherDao trainingTeacherDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingTeacherDao = new TrainingTeacherDao();

                //执行DAO操作
                objDataTable = trainingTeacherDao.SelectAllTrainingTeacherByForeignKeys(curConnectionEntity, paramTrainingTeacher);

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