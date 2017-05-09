using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Assessment ( RH_Assessment ) Biz类
    ///</summary>
    public class AssessmentBiz
    {

        /// <summary>
        /// 添加RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void AddAssessment(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentDao assessmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentDao = new AssessmentDao();

                //执行DAO操作
                assessmentDao.Insert(curConnectionEntity, paramAssessment);

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
        /// 修改RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyAssessment(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentDao assessmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentDao = new AssessmentDao();

                //执行DAO操作
                assessmentDao.Update(curConnectionEntity, paramAssessment);

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
        /// 删除RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveAssessment(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentDao assessmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentDao = new AssessmentDao();

                //执行DAO操作
                assessmentDao.Delete(curConnectionEntity, paramAssessment);

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
        /// 查看RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void FindAssessmentByPK(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentDao assessmentDao = null;

            AssessmentEntity assessmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentDao = new AssessmentDao();

                //执行DAO操作
                assessment = assessmentDao.SelectByPK(curConnectionEntity, paramAssessment);

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

            return Assessment;
        }

        /// <summary>
        /// 根据外键查找RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllAssessmentByForeignKeys(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentDao assessmentDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentDao = new AssessmentDao();

                //执行DAO操作
                objDataTable = assessmentDao.SelectAllAssessmentByForeignKeys(curConnectionEntity, paramAssessment);

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