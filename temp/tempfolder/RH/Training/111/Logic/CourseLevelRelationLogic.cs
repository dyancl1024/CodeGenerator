using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) Logic类
    ///</summary>
    public class CourseLevelRelationLogic
    {

        /// <summary>
        /// 添加RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseLevelRelation(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseLevelRelationBiz courseLevelRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseLevelRelationBiz = new CourseLevelRelationBiz();

                //执行Biz操作
                courseLevelRelationBiz.AddCourseLevelRelation(curConnectionEntity, paramCourseLevelRelation);

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
        /// 修改RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseLevelRelation(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseLevelRelationBiz courseLevelRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseLevelRelationBiz = new CourseLevelRelationBiz();

                //执行Biz操作
                courseLevelRelationBiz.ModifyCourseLevelRelation(curConnectionEntity, paramCourseLevelRelation);

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
        /// 删除RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseLevelRelation(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseLevelRelationBiz courseLevelRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseLevelRelationBiz = new CourseLevelRelationBiz();

                //执行Biz操作
                courseLevelRelationBiz.RemoveCourseLevelRelation(curConnectionEntity, paramCourseLevelRelation);

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
        /// 查看RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseLevelRelationByPK(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseLevelRelationBiz courseLevelRelationBiz = null;

            CourseLevelRelationEntity courseLevelRelationEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseLevelRelationBiz = new CourseLevelRelationBiz();

                //执行Biz操作
                courseLevelRelation = courseLevelRelationBiz.FindCourseLevelRelationByPK(curConnectionEntity, paramCourseLevelRelation);

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

            return CourseLevelRelation;
        }

        /// <summary>
        /// 根据外键查找RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseLevelRelationByForeignKeys(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseLevelRelationBiz courseLevelRelationBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseLevelRelationBiz = new CourseLevelRelationBiz();

                //执行Biz操作
                objDataTable = courseLevelRelationBiz.FindAllCourseLevelRelationByForeignKeys(curConnectionEntity, paramCourseLevelRelation);

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