using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Country ( RH_Country ) Biz类
    ///</summary>
    public class CountryBiz
    {

        /// <summary>
        /// 添加RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="void"></returns>
        public void AddCountry(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CountryDao countryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                countryDao = new CountryDao();

                //执行DAO操作
                countryDao.Insert(curConnectionEntity, paramCountry);

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
        /// 修改RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCountry(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CountryDao countryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                countryDao = new CountryDao();

                //执行DAO操作
                countryDao.Update(curConnectionEntity, paramCountry);

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
        /// 删除RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCountry(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CountryDao countryDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                countryDao = new CountryDao();

                //执行DAO操作
                countryDao.Delete(curConnectionEntity, paramCountry);

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
        /// 查看RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="void"></returns>
        public void FindCountryByPK(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CountryDao countryDao = null;

            CountryEntity countryEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                countryDao = new CountryDao();

                //执行DAO操作
                country = countryDao.SelectByPK(curConnectionEntity, paramCountry);

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

            return Country;
        }

        /// <summary>
        /// 根据外键查找RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCountryByForeignKeys(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CountryDao countryDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                countryDao = new CountryDao();

                //执行DAO操作
                objDataTable = countryDao.SelectAllCountryByForeignKeys(curConnectionEntity, paramCountry);

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