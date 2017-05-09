using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseCategory ( RH_CourseCategory ) Biz类
    ///</summary>
    public class CourseCategoryBiz
    {

        /// <summary>
        /// 添加RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseCategory(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseCategoryDao courseCategoryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseCategoryDao = new CourseCategoryDao();

                //执行DAO操作
                courseCategoryDao.Insert(curConnectionEntity, paramCourseCategory);

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
        /// 修改RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseCategory(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseCategoryDao courseCategoryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseCategoryDao = new CourseCategoryDao();

                //执行DAO操作
                courseCategoryDao.Update(curConnectionEntity, paramCourseCategory);

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
        /// 删除RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseCategory(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseCategoryDao courseCategoryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseCategoryDao = new CourseCategoryDao();

                //执行DAO操作
                courseCategoryDao.Delete(curConnectionEntity, paramCourseCategory);

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
        /// 查看RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseCategoryByPK(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseCategoryDao courseCategoryDao = null;

            CourseCategoryEntity courseCategoryEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseCategoryDao = new CourseCategoryDao();

                //执行DAO操作
                courseCategory = courseCategoryDao.SelectByPK(curConnectionEntity, paramCourseCategory);

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

            return CourseCategory;
        }

        /// <summary>
        /// 根据外键查找RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseCategoryByForeignKeys(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseCategoryDao courseCategoryDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseCategoryDao = new CourseCategoryDao();

                //执行DAO操作
                objDataTable = courseCategoryDao.SelectAllCourseCategoryByForeignKeys(curConnectionEntity, paramCourseCategory);

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