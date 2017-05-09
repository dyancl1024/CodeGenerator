using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseQuestion ( RH_CourseQuestion ) Biz类
    ///</summary>
    public class CourseQuestionBiz
    {

        /// <summary>
        /// 添加RH_CourseQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseQuestionEntity" type="CourseQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseQuestion(Object paramConnectionEntity, CourseQuestionEntity paramCourseQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseQuestionDao courseQuestionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseQuestionDao = new CourseQuestionDao();

                //执行DAO操作
                courseQuestionDao.Insert(curConnectionEntity, paramCourseQuestion);

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
        /// 修改RH_CourseQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseQuestionEntity" type="CourseQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseQuestion(Object paramConnectionEntity, CourseQuestionEntity paramCourseQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseQuestionDao courseQuestionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseQuestionDao = new CourseQuestionDao();

                //执行DAO操作
                courseQuestionDao.Update(curConnectionEntity, paramCourseQuestion);

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
        /// 删除RH_CourseQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseQuestionEntity" type="CourseQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseQuestion(Object paramConnectionEntity, CourseQuestionEntity paramCourseQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseQuestionDao courseQuestionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseQuestionDao = new CourseQuestionDao();

                //执行DAO操作
                courseQuestionDao.Delete(curConnectionEntity, paramCourseQuestion);

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
        /// 查看RH_CourseQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseQuestionEntity" type="CourseQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseQuestionByPK(Object paramConnectionEntity, CourseQuestionEntity paramCourseQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseQuestionDao courseQuestionDao = null;

            CourseQuestionEntity courseQuestionEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseQuestionDao = new CourseQuestionDao();

                //执行DAO操作
                courseQuestion = courseQuestionDao.SelectByPK(curConnectionEntity, paramCourseQuestion);

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

            return CourseQuestion;
        }

        /// <summary>
        /// 根据外键查找RH_CourseQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseQuestionEntity" type="CourseQuestionEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseQuestionByForeignKeys(Object paramConnectionEntity, CourseQuestionEntity paramCourseQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseQuestionDao courseQuestionDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseQuestionDao = new CourseQuestionDao();

                //执行DAO操作
                objDataTable = courseQuestionDao.SelectAllCourseQuestionByForeignKeys(curConnectionEntity, paramCourseQuestion);

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