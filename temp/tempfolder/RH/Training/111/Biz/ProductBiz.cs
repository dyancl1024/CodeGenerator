using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Product ( RH_Product ) Biz类
    ///</summary>
    public class ProductBiz
    {

        /// <summary>
        /// 添加RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="void"></returns>
        public void AddProduct(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProductDao productDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                productDao = new ProductDao();

                //执行DAO操作
                productDao.Insert(curConnectionEntity, paramProduct);

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
        /// 修改RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyProduct(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProductDao productDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                productDao = new ProductDao();

                //执行DAO操作
                productDao.Update(curConnectionEntity, paramProduct);

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
        /// 删除RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveProduct(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProductDao productDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                productDao = new ProductDao();

                //执行DAO操作
                productDao.Delete(curConnectionEntity, paramProduct);

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
        /// 查看RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="void"></returns>
        public void FindProductByPK(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProductDao productDao = null;

            ProductEntity productEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                productDao = new ProductDao();

                //执行DAO操作
                product = productDao.SelectByPK(curConnectionEntity, paramProduct);

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

            return Product;
        }

        /// <summary>
        /// 根据外键查找RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllProductByForeignKeys(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProductDao productDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                productDao = new ProductDao();

                //执行DAO操作
                objDataTable = productDao.SelectAllProductByForeignKeys(curConnectionEntity, paramProduct);

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