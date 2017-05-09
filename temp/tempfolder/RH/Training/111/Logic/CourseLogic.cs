using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Course ( RH_Course ) Logic类
    ///</summary>
    public class CourseLogic
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

            CourseBiz courseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseBiz = new CourseBiz();

                //执行Biz操作
                courseBiz.AddCourse(curConnectionEntity, paramCourse);

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

            CourseBiz courseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseBiz = new CourseBiz();

                //执行Biz操作
                courseBiz.ModifyCourse(curConnectionEntity, paramCourse);

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

            CourseBiz courseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseBiz = new CourseBiz();

                //执行Biz操作
                courseBiz.RemoveCourse(curConnectionEntity, paramCourse);

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

            CourseBiz courseBiz = null;

            CourseEntity courseEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseBiz = new CourseBiz();

                //执行Biz操作
                course = courseBiz.FindCourseByPK(curConnectionEntity, paramCourse);

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

            CourseBiz courseBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseBiz = new CourseBiz();

                //执行Biz操作
                objDataTable = courseBiz.FindAllCourseByForeignKeys(curConnectionEntity, paramCourse);

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