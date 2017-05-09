using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Subject ( RH_Subject ) Biz类
    ///</summary>
    public class SubjectBiz
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

            SubjectDao subjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                subjectDao = new SubjectDao();

                //执行DAO操作
                subjectDao.Insert(curConnectionEntity, paramSubject);

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

            SubjectDao subjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                subjectDao = new SubjectDao();

                //执行DAO操作
                subjectDao.Update(curConnectionEntity, paramSubject);

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

            SubjectDao subjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                subjectDao = new SubjectDao();

                //执行DAO操作
                subjectDao.Delete(curConnectionEntity, paramSubject);

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

            SubjectDao subjectDao = null;

            SubjectEntity subjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                subjectDao = new SubjectDao();

                //执行DAO操作
                subject = subjectDao.SelectByPK(curConnectionEntity, paramSubject);

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

            SubjectDao subjectDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                subjectDao = new SubjectDao();

                //执行DAO操作
                objDataTable = subjectDao.SelectAllSubjectByForeignKeys(curConnectionEntity, paramSubject);

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