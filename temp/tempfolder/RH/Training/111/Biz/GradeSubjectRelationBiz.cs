using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_GradeSubjectRelation ( RH_GradeSubjectRelation ) Biz类
    ///</summary>
    public class GradeSubjectRelationBiz
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

            GradeSubjectRelationDao gradeSubjectRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeSubjectRelationDao = new GradeSubjectRelationDao();

                //执行DAO操作
                gradeSubjectRelationDao.Insert(curConnectionEntity, paramGradeSubjectRelation);

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

            GradeSubjectRelationDao gradeSubjectRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeSubjectRelationDao = new GradeSubjectRelationDao();

                //执行DAO操作
                gradeSubjectRelationDao.Update(curConnectionEntity, paramGradeSubjectRelation);

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

            GradeSubjectRelationDao gradeSubjectRelationDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeSubjectRelationDao = new GradeSubjectRelationDao();

                //执行DAO操作
                gradeSubjectRelationDao.Delete(curConnectionEntity, paramGradeSubjectRelation);

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

            GradeSubjectRelationDao gradeSubjectRelationDao = null;

            GradeSubjectRelationEntity gradeSubjectRelationEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeSubjectRelationDao = new GradeSubjectRelationDao();

                //执行DAO操作
                gradeSubjectRelation = gradeSubjectRelationDao.SelectByPK(curConnectionEntity, paramGradeSubjectRelation);

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

            GradeSubjectRelationDao gradeSubjectRelationDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeSubjectRelationDao = new GradeSubjectRelationDao();

                //执行DAO操作
                objDataTable = gradeSubjectRelationDao.SelectAllGradeSubjectRelationByForeignKeys(curConnectionEntity, paramGradeSubjectRelation);

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