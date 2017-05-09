using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseSubject ( RH_CourseSubject ) Biz类
    ///</summary>
    public class CourseSubjectBiz
    {

        /// <summary>
        /// 添加RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseSubject(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectDao courseSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseSubjectDao = new CourseSubjectDao();

                //执行DAO操作
                courseSubjectDao.Insert(curConnectionEntity, paramCourseSubject);

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
        /// 修改RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseSubject(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectDao courseSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseSubjectDao = new CourseSubjectDao();

                //执行DAO操作
                courseSubjectDao.Update(curConnectionEntity, paramCourseSubject);

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
        /// 删除RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseSubject(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectDao courseSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseSubjectDao = new CourseSubjectDao();

                //执行DAO操作
                courseSubjectDao.Delete(curConnectionEntity, paramCourseSubject);

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
        /// 查看RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseSubjectByPK(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectDao courseSubjectDao = null;

            CourseSubjectEntity courseSubjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseSubjectDao = new CourseSubjectDao();

                //执行DAO操作
                courseSubject = courseSubjectDao.SelectByPK(curConnectionEntity, paramCourseSubject);

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

            return CourseSubject;
        }

        /// <summary>
        /// 根据外键查找RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseSubjectByForeignKeys(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectDao courseSubjectDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseSubjectDao = new CourseSubjectDao();

                //执行DAO操作
                objDataTable = courseSubjectDao.SelectAllCourseSubjectByForeignKeys(curConnectionEntity, paramCourseSubject);

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