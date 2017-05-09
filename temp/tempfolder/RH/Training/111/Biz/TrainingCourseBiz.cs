using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingCourse ( RH_TrainingCourse ) Biz类
    ///</summary>
    public class TrainingCourseBiz
    {

        /// <summary>
        /// 添加RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingCourse(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseDao trainingCourseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingCourseDao = new TrainingCourseDao();

                //执行DAO操作
                trainingCourseDao.Insert(curConnectionEntity, paramTrainingCourse);

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
        /// 修改RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingCourse(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseDao trainingCourseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingCourseDao = new TrainingCourseDao();

                //执行DAO操作
                trainingCourseDao.Update(curConnectionEntity, paramTrainingCourse);

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
        /// 删除RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingCourse(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseDao trainingCourseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingCourseDao = new TrainingCourseDao();

                //执行DAO操作
                trainingCourseDao.Delete(curConnectionEntity, paramTrainingCourse);

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
        /// 查看RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingCourseByPK(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseDao trainingCourseDao = null;

            TrainingCourseEntity trainingCourseEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingCourseDao = new TrainingCourseDao();

                //执行DAO操作
                trainingCourse = trainingCourseDao.SelectByPK(curConnectionEntity, paramTrainingCourse);

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

            return TrainingCourse;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingCourseByForeignKeys(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseDao trainingCourseDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingCourseDao = new TrainingCourseDao();

                //执行DAO操作
                objDataTable = trainingCourseDao.SelectAllTrainingCourseByForeignKeys(curConnectionEntity, paramTrainingCourse);

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