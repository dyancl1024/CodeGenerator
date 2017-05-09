using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Country ( RH_Country ) Logic类
    ///</summary>
    public class CountryLogic
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

            CountryBiz countryBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                countryBiz = new CountryBiz();

                //执行Biz操作
                countryBiz.AddCountry(curConnectionEntity, paramCountry);

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

            CountryBiz countryBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                countryBiz = new CountryBiz();

                //执行Biz操作
                countryBiz.ModifyCountry(curConnectionEntity, paramCountry);

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

            CountryBiz countryBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                countryBiz = new CountryBiz();

                //执行Biz操作
                countryBiz.RemoveCountry(curConnectionEntity, paramCountry);

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

            CountryBiz countryBiz = null;

            CountryEntity countryEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                countryBiz = new CountryBiz();

                //执行Biz操作
                country = countryBiz.FindCountryByPK(curConnectionEntity, paramCountry);

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

            CountryBiz countryBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                countryBiz = new CountryBiz();

                //执行Biz操作
                objDataTable = countryBiz.FindAllCountryByForeignKeys(curConnectionEntity, paramCountry);

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