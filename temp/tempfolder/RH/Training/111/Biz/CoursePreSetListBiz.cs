using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) Biz类
    ///</summary>
    public class CoursePreSetListBiz
    {

        /// <summary>
        /// 添加RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void AddCoursePreSetList(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListDao coursePreSetListDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePreSetListDao = new CoursePreSetListDao();

                //执行DAO操作
                coursePreSetListDao.Insert(curConnectionEntity, paramCoursePreSetList);

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
        /// 修改RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCoursePreSetList(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListDao coursePreSetListDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePreSetListDao = new CoursePreSetListDao();

                //执行DAO操作
                coursePreSetListDao.Update(curConnectionEntity, paramCoursePreSetList);

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
        /// 删除RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCoursePreSetList(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListDao coursePreSetListDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePreSetListDao = new CoursePreSetListDao();

                //执行DAO操作
                coursePreSetListDao.Delete(curConnectionEntity, paramCoursePreSetList);

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
        /// 查看RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void FindCoursePreSetListByPK(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListDao coursePreSetListDao = null;

            CoursePreSetListEntity coursePreSetListEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePreSetListDao = new CoursePreSetListDao();

                //执行DAO操作
                coursePreSetList = coursePreSetListDao.SelectByPK(curConnectionEntity, paramCoursePreSetList);

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

            return CoursePreSetList;
        }

        /// <summary>
        /// 根据外键查找RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCoursePreSetListByForeignKeys(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListDao coursePreSetListDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePreSetListDao = new CoursePreSetListDao();

                //执行DAO操作
                objDataTable = coursePreSetListDao.SelectAllCoursePreSetListByForeignKeys(curConnectionEntity, paramCoursePreSetList);

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