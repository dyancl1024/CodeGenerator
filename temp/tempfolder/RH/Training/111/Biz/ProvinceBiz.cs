using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Province ( RH_Province ) Biz类
    ///</summary>
    public class ProvinceBiz
    {

        /// <summary>
        /// 添加RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void AddProvince(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceDao provinceDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                provinceDao = new ProvinceDao();

                //执行DAO操作
                provinceDao.Insert(curConnectionEntity, paramProvince);

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
        /// 修改RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyProvince(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceDao provinceDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                provinceDao = new ProvinceDao();

                //执行DAO操作
                provinceDao.Update(curConnectionEntity, paramProvince);

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
        /// 删除RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveProvince(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceDao provinceDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                provinceDao = new ProvinceDao();

                //执行DAO操作
                provinceDao.Delete(curConnectionEntity, paramProvince);

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
        /// 查看RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void FindProvinceByPK(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceDao provinceDao = null;

            ProvinceEntity provinceEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                provinceDao = new ProvinceDao();

                //执行DAO操作
                province = provinceDao.SelectByPK(curConnectionEntity, paramProvince);

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

            return Province;
        }

        /// <summary>
        /// 根据外键查找RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllProvinceByForeignKeys(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceDao provinceDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                provinceDao = new ProvinceDao();

                //执行DAO操作
                objDataTable = provinceDao.SelectAllProvinceByForeignKeys(curConnectionEntity, paramProvince);

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