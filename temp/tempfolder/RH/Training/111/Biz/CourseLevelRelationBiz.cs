using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) Biz类
    ///</summary>
    public class CourseLevelRelationBiz
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

            CourseLevelRelationDao courseLevelRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseLevelRelationDao = new CourseLevelRelationDao();

                //执行DAO操作
                courseLevelRelationDao.Insert(curConnectionEntity, paramCourseLevelRelation);

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

            CourseLevelRelationDao courseLevelRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseLevelRelationDao = new CourseLevelRelationDao();

                //执行DAO操作
                courseLevelRelationDao.Update(curConnectionEntity, paramCourseLevelRelation);

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

            CourseLevelRelationDao courseLevelRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseLevelRelationDao = new CourseLevelRelationDao();

                //执行DAO操作
                courseLevelRelationDao.Delete(curConnectionEntity, paramCourseLevelRelation);

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

            CourseLevelRelationDao courseLevelRelationDao = null;

            CourseLevelRelationEntity courseLevelRelationEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseLevelRelationDao = new CourseLevelRelationDao();

                //执行DAO操作
                courseLevelRelation = courseLevelRelationDao.SelectByPK(curConnectionEntity, paramCourseLevelRelation);

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

            CourseLevelRelationDao courseLevelRelationDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                courseLevelRelationDao = new CourseLevelRelationDao();

                //执行DAO操作
                objDataTable = courseLevelRelationDao.SelectAllCourseLevelRelationByForeignKeys(curConnectionEntity, paramCourseLevelRelation);

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