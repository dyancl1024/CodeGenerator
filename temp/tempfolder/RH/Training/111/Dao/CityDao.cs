using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_City ( RH_City ) Dao类
    ///</summary>
    public class CityDao
    {

        /// <summary>
        /// 添加
        /// RH_City : RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_City");
                strBuilder.Append("  (");
                strBuilder.Append("    id,");
                strBuilder.Append("    CityName,");
                strBuilder.Append("    CityPY,");
                strBuilder.Append("    ProvinceID");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @id,");
                strBuilder.Append("    @CityName,");
                strBuilder.Append("    @CityPY,");
                strBuilder.Append("    @ProvinceID");
                strBuilder.Append("  )");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramCityEntity.id);

                ///CityName : nvarchar(50) CityName
                if (paramCityEntity.CityName != null && "".Equals(paramCityEntity.CityName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CityName", paramCityEntity.CityName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CityName", DBNull.Value);
                }

                ///CityPY : varchar(50) CityPY
                if (paramCityEntity.CityPY != null && "".Equals(paramCityEntity.CityPY.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CityPY", paramCityEntity.CityPY);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CityPY", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramCityEntity.ProvinceID);

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
        /// RH_City : RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_City");
                strBuilder.Append("  set ");
                strBuilder.Append("    CityName=@CityName,");
                strBuilder.Append("    CityPY=@CityPY,");
                strBuilder.Append("    ProvinceID=@ProvinceID");
                strBuilder.Append("  where ");
                strBuilder.Append("    id=@id");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramCityEntity.id);

                ///CityName : nvarchar(50) CityName
                if (paramCityEntity.CityName != null && "".Equals(paramCityEntity.CityName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CityName", paramCityEntity.CityName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CityName", DBNull.Value);
                }

                ///CityPY : varchar(50) CityPY
                if (paramCityEntity.CityPY != null && "".Equals(paramCityEntity.CityPY.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CityPY", paramCityEntity.CityPY);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CityPY", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramCityEntity.ProvinceID);

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
        /// RH_City : RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_City");
                strBuilder.Append(" where ");
                strBuilder.Append("    id=@id");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramCityEntity.id);

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
        /// RH_City : RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="CityEntity"></returns>
        public CityEntity SelectByPK(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CityEntity cityEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   id AS id,");
                strBuilder.Append("   CityName AS CityName,");
                strBuilder.Append("   CityPY AS CityPY,");
                strBuilder.Append("   ProvinceID AS ProvinceID");
                strBuilder.Append(" from RH_City");
                strBuilder.Append("   where 1=1 ");
                strBuilder.Append("   AND id=@id ");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///id : int id
                m_sqlCmd.Parameters.AddWithValue("@id",paramCityEntity.id);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        cityEntity = ParseDataRowToEntity(dataRows[0]);
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

            return cityEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_City : RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCityByForeignKeys(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable cityEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   id AS id,");
                strBuilder.Append("   CityName AS CityName,");
                strBuilder.Append("   CityPY AS CityPY,");
                strBuilder.Append("   ProvinceID AS ProvinceID");
                strBuilder.Append(" from RH_City");
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
        /// <returns type="CityEntity"></returns>
        private CityEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CityMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}