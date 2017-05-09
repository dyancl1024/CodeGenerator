using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseAnswer ( RH_CourseAnswer ) Biz类
    ///</summary>
    public class CourseAnswerBiz
    {

        /// <summary>
        /// 添加RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseAnswer(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerDao courseAnswerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAnswerDao = new CourseAnswerDao();

                //执行DAO操作
                courseAnswerDao.Insert(curConnectionEntity, paramCourseAnswer);

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
        /// 修改RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseAnswer(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerDao courseAnswerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAnswerDao = new CourseAnswerDao();

                //执行DAO操作
                courseAnswerDao.Update(curConnectionEntity, paramCourseAnswer);

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
        /// 删除RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseAnswer(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerDao courseAnswerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAnswerDao = new CourseAnswerDao();

                //执行DAO操作
                courseAnswerDao.Delete(curConnectionEntity, paramCourseAnswer);

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
        /// 查看RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseAnswerByPK(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerDao courseAnswerDao = null;

            CourseAnswerEntity courseAnswerEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAnswerDao = new CourseAnswerDao();

                //执行DAO操作
                courseAnswer = courseAnswerDao.SelectByPK(curConnectionEntity, paramCourseAnswer);

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

            return CourseAnswer;
        }

        /// <summary>
        /// 根据外键查找RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseAnswerByForeignKeys(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerDao courseAnswerDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAnswerDao = new CourseAnswerDao();

                //执行DAO操作
                objDataTable = courseAnswerDao.SelectAllCourseAnswerByForeignKeys(curConnectionEntity, paramCourseAnswer);

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