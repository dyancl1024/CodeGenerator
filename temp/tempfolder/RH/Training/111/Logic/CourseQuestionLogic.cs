using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CourseQuestion ( RH_CourseQuestion ) Logic类
    ///</summary>
    public class CourseQuestionLogic
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

            CourseQuestionBiz courseQuestionBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseQuestionBiz = new CourseQuestionBiz();

                //执行Biz操作
                courseQuestionBiz.AddCourseQuestion(curConnectionEntity, paramCourseQuestion);

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

            CourseQuestionBiz courseQuestionBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseQuestionBiz = new CourseQuestionBiz();

                //执行Biz操作
                courseQuestionBiz.ModifyCourseQuestion(curConnectionEntity, paramCourseQuestion);

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

            CourseQuestionBiz courseQuestionBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseQuestionBiz = new CourseQuestionBiz();

                //执行Biz操作
                courseQuestionBiz.RemoveCourseQuestion(curConnectionEntity, paramCourseQuestion);

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

            CourseQuestionBiz courseQuestionBiz = null;

            CourseQuestionEntity courseQuestionEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseQuestionBiz = new CourseQuestionBiz();

                //执行Biz操作
                courseQuestion = courseQuestionBiz.FindCourseQuestionByPK(curConnectionEntity, paramCourseQuestion);

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

            CourseQuestionBiz courseQuestionBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseQuestionBiz = new CourseQuestionBiz();

                //执行Biz操作
                objDataTable = courseQuestionBiz.FindAllCourseQuestionByForeignKeys(curConnectionEntity, paramCourseQuestion);

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