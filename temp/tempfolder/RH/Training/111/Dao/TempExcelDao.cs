using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TempExcel ( RH_TempExcel ) Dao类
    ///</summary>
    public class TempExcelDao
    {

        /// <summary>
        /// 添加
        /// RH_TempExcel : RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TempExcel");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    FileExcel,");
                strBuilder.Append("    TableName,");
                strBuilder.Append("    TempRemark");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @FileExcel,");
                strBuilder.Append("    @TableName,");
                strBuilder.Append("    @TempRemark");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTempExcelEntity.ID);

                ///FileExcel : nvarchar(200) FileExcel
                if (paramTempExcelEntity.FileExcel != null && "".Equals(paramTempExcelEntity.FileExcel.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@FileExcel", paramTempExcelEntity.FileExcel);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@FileExcel", DBNull.Value);
                }

                ///TableName : nvarchar(200) TableName
                if (paramTempExcelEntity.TableName != null && "".Equals(paramTempExcelEntity.TableName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TableName", paramTempExcelEntity.TableName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TableName", DBNull.Value);
                }

                ///TempRemark : nvarchar(100) TempRemark
                if (paramTempExcelEntity.TempRemark != null && "".Equals(paramTempExcelEntity.TempRemark.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempRemark", paramTempExcelEntity.TempRemark);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempRemark", DBNull.Value);
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
        /// RH_TempExcel : RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TempExcel");
                strBuilder.Append("  set ");
                strBuilder.Append("    FileExcel=@FileExcel,");
                strBuilder.Append("    TableName=@TableName,");
                strBuilder.Append("    TempRemark=@TempRemark");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTempExcelEntity.ID);

                ///FileExcel : nvarchar(200) FileExcel
                if (paramTempExcelEntity.FileExcel != null && "".Equals(paramTempExcelEntity.FileExcel.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@FileExcel", paramTempExcelEntity.FileExcel);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@FileExcel", DBNull.Value);
                }

                ///TableName : nvarchar(200) TableName
                if (paramTempExcelEntity.TableName != null && "".Equals(paramTempExcelEntity.TableName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TableName", paramTempExcelEntity.TableName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TableName", DBNull.Value);
                }

                ///TempRemark : nvarchar(100) TempRemark
                if (paramTempExcelEntity.TempRemark != null && "".Equals(paramTempExcelEntity.TempRemark.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempRemark", paramTempExcelEntity.TempRemark);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TempRemark", DBNull.Value);
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
        /// RH_TempExcel : RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TempExcel");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTempExcelEntity.ID);

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
        /// RH_TempExcel : RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="TempExcelEntity"></returns>
        public TempExcelEntity SelectByPK(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TempExcelEntity tempExcelEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   FileExcel AS FileExcel,");
                strBuilder.Append("   TableName AS TableName,");
                strBuilder.Append("   TempRemark AS TempRemark");
                strBuilder.Append(" from RH_TempExcel");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTempExcelEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        tempExcelEntity = ParseDataRowToEntity(dataRows[0]);
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

            return tempExcelEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TempExcel : RH_TempExcel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTempExcelEntity" type="TempExcelEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTempExcelByForeignKeys(Object paramConnectionEntity, TempExcelEntity paramTempExcelEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable tempExcelEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   FileExcel AS FileExcel,");
                strBuilder.Append("   TableName AS TableName,");
                strBuilder.Append("   TempRemark AS TempRemark");
                strBuilder.Append(" from RH_TempExcel");
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
        /// <returns type="TempExcelEntity"></returns>
        private TempExcelEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TempExcelMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}