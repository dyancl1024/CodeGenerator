using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_AssessmentAnswerBak ( RH_AssessmentAnswerBak ) Biz类
    ///</summary>
    public class AssessmentAnswerBakBiz
    {

        /// <summary>
        /// 添加RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="void"></returns>
        public void AddAssessmentAnswerBak(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerBakDao assessmentAnswerBakDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerBakDao = new AssessmentAnswerBakDao();

                //执行DAO操作
                assessmentAnswerBakDao.Insert(curConnectionEntity, paramAssessmentAnswerBak);

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
        /// 修改RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyAssessmentAnswerBak(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerBakDao assessmentAnswerBakDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerBakDao = new AssessmentAnswerBakDao();

                //执行DAO操作
                assessmentAnswerBakDao.Update(curConnectionEntity, paramAssessmentAnswerBak);

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
        /// 删除RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveAssessmentAnswerBak(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerBakDao assessmentAnswerBakDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerBakDao = new AssessmentAnswerBakDao();

                //执行DAO操作
                assessmentAnswerBakDao.Delete(curConnectionEntity, paramAssessmentAnswerBak);

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
        /// 查看RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="void"></returns>
        public void FindAssessmentAnswerBakByPK(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerBakDao assessmentAnswerBakDao = null;

            AssessmentAnswerBakEntity assessmentAnswerBakEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerBakDao = new AssessmentAnswerBakDao();

                //执行DAO操作
                assessmentAnswerBak = assessmentAnswerBakDao.SelectByPK(curConnectionEntity, paramAssessmentAnswerBak);

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

            return AssessmentAnswerBak;
        }

        /// <summary>
        /// 根据外键查找RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentAnswerBakEntity" type="AssessmentAnswerBakEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllAssessmentAnswerBakByForeignKeys(Object paramConnectionEntity, AssessmentAnswerBakEntity paramAssessmentAnswerBakEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentAnswerBakDao assessmentAnswerBakDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentAnswerBakDao = new AssessmentAnswerBakDao();

                //执行DAO操作
                objDataTable = assessmentAnswerBakDao.SelectAllAssessmentAnswerBakByForeignKeys(curConnectionEntity, paramAssessmentAnswerBak);

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