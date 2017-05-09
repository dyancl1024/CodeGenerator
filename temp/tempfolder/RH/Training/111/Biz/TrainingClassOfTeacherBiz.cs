using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) Biz类
    ///</summary>
    public class TrainingClassOfTeacherBiz
    {

        /// <summary>
        /// 添加RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingClassOfTeacher(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherDao trainingClassOfTeacherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassOfTeacherDao = new TrainingClassOfTeacherDao();

                //执行DAO操作
                trainingClassOfTeacherDao.Insert(curConnectionEntity, paramTrainingClassOfTeacher);

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
        /// 修改RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingClassOfTeacher(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherDao trainingClassOfTeacherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassOfTeacherDao = new TrainingClassOfTeacherDao();

                //执行DAO操作
                trainingClassOfTeacherDao.Update(curConnectionEntity, paramTrainingClassOfTeacher);

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
        /// 删除RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingClassOfTeacher(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherDao trainingClassOfTeacherDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassOfTeacherDao = new TrainingClassOfTeacherDao();

                //执行DAO操作
                trainingClassOfTeacherDao.Delete(curConnectionEntity, paramTrainingClassOfTeacher);

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
        /// 查看RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingClassOfTeacherByPK(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherDao trainingClassOfTeacherDao = null;

            TrainingClassOfTeacherEntity trainingClassOfTeacherEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassOfTeacherDao = new TrainingClassOfTeacherDao();

                //执行DAO操作
                trainingClassOfTeacher = trainingClassOfTeacherDao.SelectByPK(curConnectionEntity, paramTrainingClassOfTeacher);

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

            return TrainingClassOfTeacher;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingClassOfTeacherByForeignKeys(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherDao trainingClassOfTeacherDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassOfTeacherDao = new TrainingClassOfTeacherDao();

                //执行DAO操作
                objDataTable = trainingClassOfTeacherDao.SelectAllTrainingClassOfTeacherByForeignKeys(curConnectionEntity, paramTrainingClassOfTeacher);

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