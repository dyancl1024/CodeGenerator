using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CoursePreset ( RH_CoursePreset ) Biz类
    ///</summary>
    public class CoursePresetBiz
    {

        /// <summary>
        /// 添加RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void AddCoursePreset(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetDao coursePresetDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePresetDao = new CoursePresetDao();

                //执行DAO操作
                coursePresetDao.Insert(curConnectionEntity, paramCoursePreset);

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
        /// 修改RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCoursePreset(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetDao coursePresetDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePresetDao = new CoursePresetDao();

                //执行DAO操作
                coursePresetDao.Update(curConnectionEntity, paramCoursePreset);

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
        /// 删除RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCoursePreset(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetDao coursePresetDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePresetDao = new CoursePresetDao();

                //执行DAO操作
                coursePresetDao.Delete(curConnectionEntity, paramCoursePreset);

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
        /// 查看RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void FindCoursePresetByPK(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetDao coursePresetDao = null;

            CoursePresetEntity coursePresetEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePresetDao = new CoursePresetDao();

                //执行DAO操作
                coursePreset = coursePresetDao.SelectByPK(curConnectionEntity, paramCoursePreset);

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

            return CoursePreset;
        }

        /// <summary>
        /// 根据外键查找RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCoursePresetByForeignKeys(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetDao coursePresetDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                coursePresetDao = new CoursePresetDao();

                //执行DAO操作
                objDataTable = coursePresetDao.SelectAllCoursePresetByForeignKeys(curConnectionEntity, paramCoursePreset);

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