using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_AssessmentAnswer ( RH_AssessmentAnswer ) Biz类
    ///</summary>
    public class AssessmentAnswerBiz
    {

        /// <summary>
        /// 添加RH_AssessmentAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerEntity" type="AssessmentAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void AddAssessmentAnswer(Object paramConnectionEntity, AssessmentAnswerEntity paramAssessmentAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerDao assessmentAnswerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerDao = new AssessmentAnswerDao();

                //执行DAO操作
                assessmentAnswerDao.Insert(curConnectionEntity, paramAssessmentAnswer);

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
        /// 修改RH_AssessmentAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerEntity" type="AssessmentAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyAssessmentAnswer(Object paramConnectionEntity, AssessmentAnswerEntity paramAssessmentAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerDao assessmentAnswerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerDao = new AssessmentAnswerDao();

                //执行DAO操作
                assessmentAnswerDao.Update(curConnectionEntity, paramAssessmentAnswer);

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
        /// 删除RH_AssessmentAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerEntity" type="AssessmentAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveAssessmentAnswer(Object paramConnectionEntity, AssessmentAnswerEntity paramAssessmentAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerDao assessmentAnswerDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerDao = new AssessmentAnswerDao();

                //执行DAO操作
                assessmentAnswerDao.Delete(curConnectionEntity, paramAssessmentAnswer);

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
        /// 查看RH_AssessmentAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerEntity" type="AssessmentAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void FindAssessmentAnswerByPK(Object paramConnectionEntity, AssessmentAnswerEntity paramAssessmentAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerDao assessmentAnswerDao = null;

            AssessmentAnswerEntity assessmentAnswerEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerDao = new AssessmentAnswerDao();

                //执行DAO操作
                assessmentAnswer = assessmentAnswerDao.SelectByPK(curConnectionEntity, paramAssessmentAnswer);

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

            return AssessmentAnswer;
        }

        /// <summary>
        /// 根据外键查找RH_AssessmentAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerEntity" type="AssessmentAnswerEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllAssessmentAnswerByForeignKeys(Object paramConnectionEntity, AssessmentAnswerEntity paramAssessmentAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerDao assessmentAnswerDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerDao = new AssessmentAnswerDao();

                //执行DAO操作
                objDataTable = assessmentAnswerDao.SelectAllAssessmentAnswerByForeignKeys(curConnectionEntity, paramAssessmentAnswer);

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