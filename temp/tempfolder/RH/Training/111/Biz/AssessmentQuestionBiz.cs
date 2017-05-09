using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_AssessmentQuestion ( RH_AssessmentQuestion ) Biz类
    ///</summary>
    public class AssessmentQuestionBiz
    {

        /// <summary>
        /// 添加RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void AddAssessmentQuestion(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionDao assessmentQuestionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionDao = new AssessmentQuestionDao();

                //执行DAO操作
                assessmentQuestionDao.Insert(curConnectionEntity, paramAssessmentQuestion);

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
        /// 修改RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyAssessmentQuestion(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionDao assessmentQuestionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionDao = new AssessmentQuestionDao();

                //执行DAO操作
                assessmentQuestionDao.Update(curConnectionEntity, paramAssessmentQuestion);

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
        /// 删除RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveAssessmentQuestion(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionDao assessmentQuestionDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionDao = new AssessmentQuestionDao();

                //执行DAO操作
                assessmentQuestionDao.Delete(curConnectionEntity, paramAssessmentQuestion);

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
        /// 查看RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="void"></returns>
        public void FindAssessmentQuestionByPK(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionDao assessmentQuestionDao = null;

            AssessmentQuestionEntity assessmentQuestionEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionDao = new AssessmentQuestionDao();

                //执行DAO操作
                assessmentQuestion = assessmentQuestionDao.SelectByPK(curConnectionEntity, paramAssessmentQuestion);

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

            return AssessmentQuestion;
        }

        /// <summary>
        /// 根据外键查找RH_AssessmentQuestion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionEntity" type="AssessmentQuestionEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllAssessmentQuestionByForeignKeys(Object paramConnectionEntity, AssessmentQuestionEntity paramAssessmentQuestionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionDao assessmentQuestionDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionDao = new AssessmentQuestionDao();

                //执行DAO操作
                objDataTable = assessmentQuestionDao.SelectAllAssessmentQuestionByForeignKeys(curConnectionEntity, paramAssessmentQuestion);

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