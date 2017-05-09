using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Product ( RH_Product ) Dao类
    ///</summary>
    public class ProductDao
    {

        /// <summary>
        /// 添加
        /// RH_Product : RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Product");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    ProductName,");
                strBuilder.Append("    ProductCode,");
                strBuilder.Append("    ProductLevel,");
                strBuilder.Append("    ProductUrl,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    ProvinceID,");
                strBuilder.Append("    CityID,");
                strBuilder.Append("    DistrictID,");
                strBuilder.Append("    StaticUrl,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @ProductName,");
                strBuilder.Append("    @ProductCode,");
                strBuilder.Append("    @ProductLevel,");
                strBuilder.Append("    @ProductUrl,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @ProvinceID,");
                strBuilder.Append("    @CityID,");
                strBuilder.Append("    @DistrictID,");
                strBuilder.Append("    @StaticUrl,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
                strBuilder.Append("    @UpdateBy,");
                strBuilder.Append("    @UpdateTime");
                strBuilder.Append("  )");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramProductEntity.ID);

                ///ProductName : nvarchar(50) ProductName
                if (paramProductEntity.ProductName != null && "".Equals(paramProductEntity.ProductName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductName", paramProductEntity.ProductName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductName", DBNull.Value);
                }

                ///ProductCode : varchar(50) ProductCode
                if (paramProductEntity.ProductCode != null && "".Equals(paramProductEntity.ProductCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductCode", paramProductEntity.ProductCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductCode", DBNull.Value);
                }

                ///产品级别 1.省 2. 市 3.区县 : int ProductLevel
                m_sqlCmd.Parameters.AddWithValue("@ProductLevel",paramProductEntity.ProductLevel);

                ///ProductUrl : nvarchar(50) ProductUrl
                if (paramProductEntity.ProductUrl != null && "".Equals(paramProductEntity.ProductUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductUrl", paramProductEntity.ProductUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductUrl", DBNull.Value);
                }

                ///1.正常 2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramProductEntity.Status);

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramProductEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramProductEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramProductEntity.DistrictID);

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramProductEntity.StaticUrl != null && "".Equals(paramProductEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramProductEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramProductEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramProductEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramProductEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramProductEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramProductEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramProductEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 修改
        /// RH_Product : RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Product");
                strBuilder.Append("  set ");
                strBuilder.Append("    ProductName=@ProductName,");
                strBuilder.Append("    ProductCode=@ProductCode,");
                strBuilder.Append("    ProductLevel=@ProductLevel,");
                strBuilder.Append("    ProductUrl=@ProductUrl,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    ProvinceID=@ProvinceID,");
                strBuilder.Append("    CityID=@CityID,");
                strBuilder.Append("    DistrictID=@DistrictID,");
                strBuilder.Append("    StaticUrl=@StaticUrl,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
                strBuilder.Append("    UpdateBy=@UpdateBy,");
                strBuilder.Append("    UpdateTime=@UpdateTime");
                strBuilder.Append("  where ");
                strBuilder.Append("    ID=@ID");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramProductEntity.ID);

                ///ProductName : nvarchar(50) ProductName
                if (paramProductEntity.ProductName != null && "".Equals(paramProductEntity.ProductName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductName", paramProductEntity.ProductName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductName", DBNull.Value);
                }

                ///ProductCode : varchar(50) ProductCode
                if (paramProductEntity.ProductCode != null && "".Equals(paramProductEntity.ProductCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductCode", paramProductEntity.ProductCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductCode", DBNull.Value);
                }

                ///产品级别 1.省 2. 市 3.区县 : int ProductLevel
                m_sqlCmd.Parameters.AddWithValue("@ProductLevel",paramProductEntity.ProductLevel);

                ///ProductUrl : nvarchar(50) ProductUrl
                if (paramProductEntity.ProductUrl != null && "".Equals(paramProductEntity.ProductUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductUrl", paramProductEntity.ProductUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProductUrl", DBNull.Value);
                }

                ///1.正常 2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramProductEntity.Status);

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramProductEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramProductEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramProductEntity.DistrictID);

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramProductEntity.StaticUrl != null && "".Equals(paramProductEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramProductEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramProductEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramProductEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramProductEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramProductEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramProductEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramProductEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 删除
        /// RH_Product : RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Product");
                strBuilder.Append(" where ");
                strBuilder.Append("    ID=@ID");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramProductEntity.ID);

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 查看
        /// RH_Product : RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="ProductEntity"></returns>
        public ProductEntity SelectByPK(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            ProductEntity productEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ProductName AS ProductName,");
                strBuilder.Append("   ProductCode AS ProductCode,");
                strBuilder.Append("   ProductLevel AS ProductLevel,");
                strBuilder.Append("   ProductUrl AS ProductUrl,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   ProvinceID AS ProvinceID,");
                strBuilder.Append("   CityID AS CityID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_Product");
                strBuilder.Append("   where 1=1 ");
                strBuilder.Append("   AND ID=@ID ");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramProductEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        productEntity = ParseDataRowToEntity(dataRows[0]);
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }

            return productEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Product : RH_Product
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProductEntity" type="ProductEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllProductByForeignKeys(Object paramConnectionEntity, ProductEntity paramProductEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable productEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ProductName AS ProductName,");
                strBuilder.Append("   ProductCode AS ProductCode,");
                strBuilder.Append("   ProductLevel AS ProductLevel,");
                strBuilder.Append("   ProductUrl AS ProductUrl,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   ProvinceID AS ProvinceID,");
                strBuilder.Append("   CityID AS CityID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_Product");
                strBuilder.Append(" where 1=1 ");

                //---设置查询条件

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                //执行数据库操作
                SqlDataAdapter dat = new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }

            return objDataTable;
        }

        /// <summary>
        /// 实体映射
        /// </summary>
        /// <param name="dataRow" type="DataRow"></param>
        /// <returns type="ProductEntity"></returns>
        private ProductEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return ProductMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}