using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Country ( RH_Country ) Dao类
    ///</summary>
    public class CountryDao
    {

        /// <summary>
        /// 添加
        /// RH_Country : RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Country");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    CountryName,");
                strBuilder.Append("    CountryPY");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @CountryName,");
                strBuilder.Append("    @CountryPY");
                strBuilder.Append("  )");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCountryEntity.ID);

                ///国家名 : nvarchar(50) CountryName
                if (paramCountryEntity.CountryName != null && "".Equals(paramCountryEntity.CountryName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CountryName", paramCountryEntity.CountryName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CountryName", DBNull.Value);
                }

                ///国家拼音 : nvarchar(50) CountryPY
                if (paramCountryEntity.CountryPY != null && "".Equals(paramCountryEntity.CountryPY.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CountryPY", paramCountryEntity.CountryPY);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CountryPY", DBNull.Value);
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
        /// RH_Country : RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Country");
                strBuilder.Append("  set ");
                strBuilder.Append("    CountryName=@CountryName,");
                strBuilder.Append("    CountryPY=@CountryPY");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCountryEntity.ID);

                ///国家名 : nvarchar(50) CountryName
                if (paramCountryEntity.CountryName != null && "".Equals(paramCountryEntity.CountryName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CountryName", paramCountryEntity.CountryName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CountryName", DBNull.Value);
                }

                ///国家拼音 : nvarchar(50) CountryPY
                if (paramCountryEntity.CountryPY != null && "".Equals(paramCountryEntity.CountryPY.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CountryPY", paramCountryEntity.CountryPY);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CountryPY", DBNull.Value);
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
        /// RH_Country : RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Country");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCountryEntity.ID);

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
        /// RH_Country : RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="CountryEntity"></returns>
        public CountryEntity SelectByPK(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CountryEntity countryEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CountryName AS CountryName,");
                strBuilder.Append("   CountryPY AS CountryPY");
                strBuilder.Append(" from RH_Country");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCountryEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        countryEntity = ParseDataRowToEntity(dataRows[0]);
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

            return countryEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Country : RH_Country
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCountryEntity" type="CountryEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCountryByForeignKeys(Object paramConnectionEntity, CountryEntity paramCountryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable countryEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CountryName AS CountryName,");
                strBuilder.Append("   CountryPY AS CountryPY");
                strBuilder.Append(" from RH_Country");
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
        /// <returns type="CountryEntity"></returns>
        private CountryEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CountryMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}