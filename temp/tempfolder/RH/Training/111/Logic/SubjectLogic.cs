using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Subject ( RH_Subject ) Logic类
    ///</summary>
    public class SubjectLogic
    {

        /// <summary>
        /// 添加RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="void"></returns>
        public void AddSubject(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SubjectBiz subjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                subjectBiz = new SubjectBiz();

                //执行Biz操作
                subjectBiz.AddSubject(curConnectionEntity, paramSubject);

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
        /// 修改RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="void"></returns>
        public void ModifySubject(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SubjectBiz subjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                subjectBiz = new SubjectBiz();

                //执行Biz操作
                subjectBiz.ModifySubject(curConnectionEntity, paramSubject);

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
        /// 删除RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveSubject(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SubjectBiz subjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                subjectBiz = new SubjectBiz();

                //执行Biz操作
                subjectBiz.RemoveSubject(curConnectionEntity, paramSubject);

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
        /// 查看RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="void"></returns>
        public void FindSubjectByPK(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SubjectBiz subjectBiz = null;

            SubjectEntity subjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                subjectBiz = new SubjectBiz();

                //执行Biz操作
                subject = subjectBiz.FindSubjectByPK(curConnectionEntity, paramSubject);

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

            return Subject;
        }

        /// <summary>
        /// 根据外键查找RH_Subject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSubjectEntity" type="SubjectEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllSubjectByForeignKeys(Object paramConnectionEntity, SubjectEntity paramSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SubjectBiz subjectBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                subjectBiz = new SubjectBiz();

                //执行Biz操作
                objDataTable = subjectBiz.FindAllSubjectByForeignKeys(curConnectionEntity, paramSubject);

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