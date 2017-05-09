using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CourseAttachment ( RH_CourseAttachment ) Logic类
    ///</summary>
    public class CourseAttachmentLogic
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

            CourseAttachmentBiz courseAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAttachmentBiz = new CourseAttachmentBiz();

                //执行Biz操作
                courseAttachmentBiz.AddCourseAttachment(curConnectionEntity, paramCourseAttachment);

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

            CourseAttachmentBiz courseAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAttachmentBiz = new CourseAttachmentBiz();

                //执行Biz操作
                courseAttachmentBiz.ModifyCourseAttachment(curConnectionEntity, paramCourseAttachment);

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

            CourseAttachmentBiz courseAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAttachmentBiz = new CourseAttachmentBiz();

                //执行Biz操作
                courseAttachmentBiz.RemoveCourseAttachment(curConnectionEntity, paramCourseAttachment);

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

            CourseAttachmentBiz courseAttachmentBiz = null;

            CourseAttachmentEntity courseAttachmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAttachmentBiz = new CourseAttachmentBiz();

                //执行Biz操作
                courseAttachment = courseAttachmentBiz.FindCourseAttachmentByPK(curConnectionEntity, paramCourseAttachment);

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

            CourseAttachmentBiz courseAttachmentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAttachmentBiz = new CourseAttachmentBiz();

                //执行Biz操作
                objDataTable = courseAttachmentBiz.FindAllCourseAttachmentByForeignKeys(curConnectionEntity, paramCourseAttachment);

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