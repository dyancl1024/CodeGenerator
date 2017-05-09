using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_GradeSubjectRelation ( RH_GradeSubjectRelation ) Logic类
    ///</summary>
    public class GradeSubjectRelationLogic
    {

        /// <summary>
        /// 添加RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="void"></returns>
        public void AddGradeSubjectRelation(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeSubjectRelationBiz gradeSubjectRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeSubjectRelationBiz = new GradeSubjectRelationBiz();

                //执行Biz操作
                gradeSubjectRelationBiz.AddGradeSubjectRelation(curConnectionEntity, paramGradeSubjectRelation);

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
        /// 修改RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyGradeSubjectRelation(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeSubjectRelationBiz gradeSubjectRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeSubjectRelationBiz = new GradeSubjectRelationBiz();

                //执行Biz操作
                gradeSubjectRelationBiz.ModifyGradeSubjectRelation(curConnectionEntity, paramGradeSubjectRelation);

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
        /// 删除RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveGradeSubjectRelation(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeSubjectRelationBiz gradeSubjectRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeSubjectRelationBiz = new GradeSubjectRelationBiz();

                //执行Biz操作
                gradeSubjectRelationBiz.RemoveGradeSubjectRelation(curConnectionEntity, paramGradeSubjectRelation);

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
        /// 查看RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="void"></returns>
        public void FindGradeSubjectRelationByPK(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeSubjectRelationBiz gradeSubjectRelationBiz = null;

            GradeSubjectRelationEntity gradeSubjectRelationEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeSubjectRelationBiz = new GradeSubjectRelationBiz();

                //执行Biz操作
                gradeSubjectRelation = gradeSubjectRelationBiz.FindGradeSubjectRelationByPK(curConnectionEntity, paramGradeSubjectRelation);

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

            return GradeSubjectRelation;
        }

        /// <summary>
        /// 根据外键查找RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllGradeSubjectRelationByForeignKeys(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeSubjectRelationBiz gradeSubjectRelationBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeSubjectRelationBiz = new GradeSubjectRelationBiz();

                //执行Biz操作
                objDataTable = gradeSubjectRelationBiz.FindAllGradeSubjectRelationByForeignKeys(curConnectionEntity, paramGradeSubjectRelation);

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