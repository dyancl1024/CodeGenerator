using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseTheme ( RH_CourseTheme ) Biz类
    ///</summary>
    public class CourseThemeBiz
    {

        /// <summary>
        /// 添加RH_CourseTheme
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeEntity" type="CourseThemeEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseTheme(Object paramConnectionEntity, CourseThemeEntity paramCourseThemeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeDao courseThemeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeDao = new CourseThemeDao();

                //执行DAO操作
                courseThemeDao.Insert(curConnectionEntity, paramCourseTheme);

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
        /// 修改RH_CourseTheme
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeEntity" type="CourseThemeEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseTheme(Object paramConnectionEntity, CourseThemeEntity paramCourseThemeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeDao courseThemeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeDao = new CourseThemeDao();

                //执行DAO操作
                courseThemeDao.Update(curConnectionEntity, paramCourseTheme);

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
        /// 删除RH_CourseTheme
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeEntity" type="CourseThemeEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseTheme(Object paramConnectionEntity, CourseThemeEntity paramCourseThemeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeDao courseThemeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeDao = new CourseThemeDao();

                //执行DAO操作
                courseThemeDao.Delete(curConnectionEntity, paramCourseTheme);

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
        /// 查看RH_CourseTheme
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeEntity" type="CourseThemeEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseThemeByPK(Object paramConnectionEntity, CourseThemeEntity paramCourseThemeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeDao courseThemeDao = null;

            CourseThemeEntity courseThemeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeDao = new CourseThemeDao();

                //执行DAO操作
                courseTheme = courseThemeDao.SelectByPK(curConnectionEntity, paramCourseTheme);

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

            return CourseTheme;
        }

        /// <summary>
        /// 根据外键查找RH_CourseTheme
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeEntity" type="CourseThemeEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseThemeByForeignKeys(Object paramConnectionEntity, CourseThemeEntity paramCourseThemeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeDao courseThemeDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeDao = new CourseThemeDao();

                //执行DAO操作
                objDataTable = courseThemeDao.SelectAllCourseThemeByForeignKeys(curConnectionEntity, paramCourseTheme);

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