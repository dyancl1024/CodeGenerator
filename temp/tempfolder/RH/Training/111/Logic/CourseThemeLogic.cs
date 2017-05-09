using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CourseTheme ( RH_CourseTheme ) Logic类
    ///</summary>
    public class CourseThemeLogic
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

            CourseThemeBiz courseThemeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeBiz = new CourseThemeBiz();

                //执行Biz操作
                courseThemeBiz.AddCourseTheme(curConnectionEntity, paramCourseTheme);

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

            CourseThemeBiz courseThemeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeBiz = new CourseThemeBiz();

                //执行Biz操作
                courseThemeBiz.ModifyCourseTheme(curConnectionEntity, paramCourseTheme);

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

            CourseThemeBiz courseThemeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeBiz = new CourseThemeBiz();

                //执行Biz操作
                courseThemeBiz.RemoveCourseTheme(curConnectionEntity, paramCourseTheme);

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

            CourseThemeBiz courseThemeBiz = null;

            CourseThemeEntity courseThemeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeBiz = new CourseThemeBiz();

                //执行Biz操作
                courseTheme = courseThemeBiz.FindCourseThemeByPK(curConnectionEntity, paramCourseTheme);

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

            CourseThemeBiz courseThemeBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeBiz = new CourseThemeBiz();

                //执行Biz操作
                objDataTable = courseThemeBiz.FindAllCourseThemeByForeignKeys(curConnectionEntity, paramCourseTheme);

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