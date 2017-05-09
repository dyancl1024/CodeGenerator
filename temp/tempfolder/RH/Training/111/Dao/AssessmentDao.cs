using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Assessment ( RH_Assessment ) Dao类
    ///</summary>
    public class AssessmentDao
    {

        /// <summary>
        /// 添加
        /// RH_Assessment : RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Assessment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    AName,");
                strBuilder.Append("    ADesc,");
                strBuilder.Append("    Status");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @AName,");
                strBuilder.Append("    @ADesc,");
                strBuilder.Append("    @Status");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentEntity.ID);

                ///测评工具名称 : nvarchar(200) AName
                if (paramAssessmentEntity.AName != null && "".Equals(paramAssessmentEntity.AName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AName", paramAssessmentEntity.AName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AName", DBNull.Value);
                }

                ///评测描述 : nvarchar(Max) ADesc
                if (paramAssessmentEntity.ADesc != null && "".Equals(paramAssessmentEntity.ADesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADesc", paramAssessmentEntity.ADesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADesc", DBNull.Value);
                }

                ///0.未发布  1.已发布 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramAssessmentEntity.Status);

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
        /// RH_Assessment : RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Assessment");
                strBuilder.Append("  set ");
                strBuilder.Append("    AName=@AName,");
                strBuilder.Append("    ADesc=@ADesc,");
                strBuilder.Append("    Status=@Status");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentEntity.ID);

                ///测评工具名称 : nvarchar(200) AName
                if (paramAssessmentEntity.AName != null && "".Equals(paramAssessmentEntity.AName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AName", paramAssessmentEntity.AName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AName", DBNull.Value);
                }

                ///评测描述 : nvarchar(Max) ADesc
                if (paramAssessmentEntity.ADesc != null && "".Equals(paramAssessmentEntity.ADesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADesc", paramAssessmentEntity.ADesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADesc", DBNull.Value);
                }

                ///0.未发布  1.已发布 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramAssessmentEntity.Status);

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
        /// RH_Assessment : RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Assessment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentEntity.ID);

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
        /// RH_Assessment : RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="AssessmentEntity"></returns>
        public AssessmentEntity SelectByPK(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            AssessmentEntity assessmentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   AName AS AName,");
                strBuilder.Append("   ADesc AS ADesc,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_Assessment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramAssessmentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        assessmentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return assessmentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Assessment : RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllAssessmentByForeignKeys(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable assessmentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   AName AS AName,");
                strBuilder.Append("   ADesc AS ADesc,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_Assessment");
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
        /// <returns type="AssessmentEntity"></returns>
        private AssessmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return AssessmentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}