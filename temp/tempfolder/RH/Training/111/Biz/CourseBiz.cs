using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Course ( RH_Course ) Biz类
    ///</summary>
    public class CourseBiz
    {

        /// <summary>
        /// 添加RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourse(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseDao courseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseDao = new CourseDao();

                //执行DAO操作
                courseDao.Insert(curConnectionEntity, paramCourse);

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
        /// 修改RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourse(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseDao courseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseDao = new CourseDao();

                //执行DAO操作
                courseDao.Update(curConnectionEntity, paramCourse);

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
        /// 删除RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourse(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseDao courseDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseDao = new CourseDao();

                //执行DAO操作
                courseDao.Delete(curConnectionEntity, paramCourse);

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
        /// 查看RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseByPK(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseDao courseDao = null;

            CourseEntity courseEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseDao = new CourseDao();

                //执行DAO操作
                course = courseDao.SelectByPK(curConnectionEntity, paramCourse);

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

            return Course;
        }

        /// <summary>
        /// 根据外键查找RH_Course
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseEntity" type="CourseEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseByForeignKeys(Object paramConnectionEntity, CourseEntity paramCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseDao courseDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseDao = new CourseDao();

                //执行DAO操作
                objDataTable = courseDao.SelectAllCourseByForeignKeys(curConnectionEntity, paramCourse);

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