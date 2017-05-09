using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_AssessmentAnswerBak ( RH_AssessmentAnswerBak ) Logic类
    ///</summary>
    public class AssessmentAnswerBakLogic
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

            AssessmentAnswerBakBiz assessmentAnswerBakBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentAnswerBakBiz = new AssessmentAnswerBakBiz();

                //执行Biz操作
                assessmentAnswerBakBiz.AddAssessmentAnswerBak(curConnectionEntity, paramAssessmentAnswerBak);

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

            AssessmentAnswerBakBiz assessmentAnswerBakBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentAnswerBakBiz = new AssessmentAnswerBakBiz();

                //执行Biz操作
                assessmentAnswerBakBiz.ModifyAssessmentAnswerBak(curConnectionEntity, paramAssessmentAnswerBak);

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

            AssessmentAnswerBakBiz assessmentAnswerBakBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentAnswerBakBiz = new AssessmentAnswerBakBiz();

                //执行Biz操作
                assessmentAnswerBakBiz.RemoveAssessmentAnswerBak(curConnectionEntity, paramAssessmentAnswerBak);

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

            AssessmentAnswerBakBiz assessmentAnswerBakBiz = null;

            AssessmentAnswerBakEntity assessmentAnswerBakEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentAnswerBakBiz = new AssessmentAnswerBakBiz();

                //执行Biz操作
                assessmentAnswerBak = assessmentAnswerBakBiz.FindAssessmentAnswerBakByPK(curConnectionEntity, paramAssessmentAnswerBak);

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

            AssessmentAnswerBakBiz assessmentAnswerBakBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentAnswerBakBiz = new AssessmentAnswerBakBiz();

                //执行Biz操作
                objDataTable = assessmentAnswerBakBiz.FindAllAssessmentAnswerBakByForeignKeys(curConnectionEntity, paramAssessmentAnswerBak);

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