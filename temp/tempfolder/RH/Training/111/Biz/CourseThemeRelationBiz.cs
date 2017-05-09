using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) Biz类
    ///</summary>
    public class CourseThemeRelationBiz
    {

        /// <summary>
        /// 添加RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseThemeRelation(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationDao courseThemeRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeRelationDao = new CourseThemeRelationDao();

                //执行DAO操作
                courseThemeRelationDao.Insert(curConnectionEntity, paramCourseThemeRelation);

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
        /// 修改RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseThemeRelation(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationDao courseThemeRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeRelationDao = new CourseThemeRelationDao();

                //执行DAO操作
                courseThemeRelationDao.Update(curConnectionEntity, paramCourseThemeRelation);

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
        /// 删除RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseThemeRelation(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationDao courseThemeRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeRelationDao = new CourseThemeRelationDao();

                //执行DAO操作
                courseThemeRelationDao.Delete(curConnectionEntity, paramCourseThemeRelation);

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
        /// 查看RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseThemeRelationByPK(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationDao courseThemeRelationDao = null;

            CourseThemeRelationEntity courseThemeRelationEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeRelationDao = new CourseThemeRelationDao();

                //执行DAO操作
                courseThemeRelation = courseThemeRelationDao.SelectByPK(curConnectionEntity, paramCourseThemeRelation);

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

            return CourseThemeRelation;
        }

        /// <summary>
        /// 根据外键查找RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseThemeRelationByForeignKeys(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationDao courseThemeRelationDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseThemeRelationDao = new CourseThemeRelationDao();

                //执行DAO操作
                objDataTable = courseThemeRelationDao.SelectAllCourseThemeRelationByForeignKeys(curConnectionEntity, paramCourseThemeRelation);

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