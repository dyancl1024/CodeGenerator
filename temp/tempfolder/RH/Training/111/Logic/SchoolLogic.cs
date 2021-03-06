using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_School ( RH_School ) Logic类
    ///</summary>
    public class SchoolLogic
    {

        /// <summary>
        /// 添加RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="void"></returns>
        public void AddSchool(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SchoolBiz schoolBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                schoolBiz = new SchoolBiz();

                //执行Biz操作
                schoolBiz.AddSchool(curConnectionEntity, paramSchool);

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
        /// 修改RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="void"></returns>
        public void ModifySchool(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SchoolBiz schoolBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                schoolBiz = new SchoolBiz();

                //执行Biz操作
                schoolBiz.ModifySchool(curConnectionEntity, paramSchool);

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
        /// 删除RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveSchool(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SchoolBiz schoolBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                schoolBiz = new SchoolBiz();

                //执行Biz操作
                schoolBiz.RemoveSchool(curConnectionEntity, paramSchool);

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
        /// 查看RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="void"></returns>
        public void FindSchoolByPK(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SchoolBiz schoolBiz = null;

            SchoolEntity schoolEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                schoolBiz = new SchoolBiz();

                //执行Biz操作
                school = schoolBiz.FindSchoolByPK(curConnectionEntity, paramSchool);

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

            return School;
        }

        /// <summary>
        /// 根据外键查找RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllSchoolByForeignKeys(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            SchoolBiz schoolBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                schoolBiz = new SchoolBiz();

                //执行Biz操作
                objDataTable = schoolBiz.FindAllSchoolByForeignKeys(curConnectionEntity, paramSchool);

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