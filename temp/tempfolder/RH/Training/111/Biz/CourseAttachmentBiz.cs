using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseAttachment ( RH_CourseAttachment ) Biz类
    ///</summary>
    public class CourseAttachmentBiz
    {

        /// <summary>
        /// 添加RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseAttachment(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAttachmentDao courseAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAttachmentDao = new CourseAttachmentDao();

                //执行DAO操作
                courseAttachmentDao.Insert(curConnectionEntity, paramCourseAttachment);

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
        /// 修改RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseAttachment(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAttachmentDao courseAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAttachmentDao = new CourseAttachmentDao();

                //执行DAO操作
                courseAttachmentDao.Update(curConnectionEntity, paramCourseAttachment);

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
        /// 删除RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseAttachment(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAttachmentDao courseAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAttachmentDao = new CourseAttachmentDao();

                //执行DAO操作
                courseAttachmentDao.Delete(curConnectionEntity, paramCourseAttachment);

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
        /// 查看RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseAttachmentByPK(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAttachmentDao courseAttachmentDao = null;

            CourseAttachmentEntity courseAttachmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAttachmentDao = new CourseAttachmentDao();

                //执行DAO操作
                courseAttachment = courseAttachmentDao.SelectByPK(curConnectionEntity, paramCourseAttachment);

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

            return CourseAttachment;
        }

        /// <summary>
        /// 根据外键查找RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseAttachmentByForeignKeys(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAttachmentDao courseAttachmentDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseAttachmentDao = new CourseAttachmentDao();

                //执行DAO操作
                objDataTable = courseAttachmentDao.SelectAllCourseAttachmentByForeignKeys(curConnectionEntity, paramCourseAttachment);

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