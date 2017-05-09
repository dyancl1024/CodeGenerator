using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseOption ( RH_CourseOption ) Biz类
    ///</summary>
    public class CourseOptionBiz
    {

        /// <summary>
        /// 添加RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseOption(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseOptionDao courseOptionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseOptionDao = new CourseOptionDao();

                //执行DAO操作
                courseOptionDao.Insert(curConnectionEntity, paramCourseOption);

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
        /// 修改RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseOption(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseOptionDao courseOptionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseOptionDao = new CourseOptionDao();

                //执行DAO操作
                courseOptionDao.Update(curConnectionEntity, paramCourseOption);

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
        /// 删除RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseOption(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseOptionDao courseOptionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseOptionDao = new CourseOptionDao();

                //执行DAO操作
                courseOptionDao.Delete(curConnectionEntity, paramCourseOption);

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
        /// 查看RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseOptionByPK(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseOptionDao courseOptionDao = null;

            CourseOptionEntity courseOptionEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseOptionDao = new CourseOptionDao();

                //执行DAO操作
                courseOption = courseOptionDao.SelectByPK(curConnectionEntity, paramCourseOption);

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

            return CourseOption;
        }

        /// <summary>
        /// 根据外键查找RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseOptionByForeignKeys(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseOptionDao courseOptionDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseOptionDao = new CourseOptionDao();

                //执行DAO操作
                objDataTable = courseOptionDao.SelectAllCourseOptionByForeignKeys(curConnectionEntity, paramCourseOption);

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