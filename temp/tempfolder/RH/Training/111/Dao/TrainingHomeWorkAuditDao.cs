using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingHomeWorkAudit ( RH_TrainingHomeWorkAudit ) Dao类
    ///</summary>
    public class TrainingHomeWorkAuditDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingHomeWorkAudit : RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingHomeWorkAudit");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    HomeWorkID,");
                strBuilder.Append("    Auditor,");
                strBuilder.Append("    AuditTime,");
                strBuilder.Append("    AuditDesc,");
                strBuilder.Append("    Status");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @HomeWorkID,");
                strBuilder.Append("    @Auditor,");
                strBuilder.Append("    @AuditTime,");
                strBuilder.Append("    @AuditDesc,");
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

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkAuditEntity.ID);

                ///HomeWorkID : int HomeWorkID
                m_sqlCmd.Parameters.AddWithValue("@HomeWorkID",paramTrainingHomeWorkAuditEntity.HomeWorkID);

                ///Auditor : int Auditor
                m_sqlCmd.Parameters.AddWithValue("@Auditor",paramTrainingHomeWorkAuditEntity.Auditor);

                ///AuditTime : datetime AuditTime
                if (paramTrainingHomeWorkAuditEntity.AuditTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@AuditTime", paramTrainingHomeWorkAuditEntity.AuditTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AuditTime", DBNull.Value);
                }

                ///审批意见 : nvarchar(200) AuditDesc
                if (paramTrainingHomeWorkAuditEntity.AuditDesc != null && "".Equals(paramTrainingHomeWorkAuditEntity.AuditDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AuditDesc", paramTrainingHomeWorkAuditEntity.AuditDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AuditDesc", DBNull.Value);
                }

                ///作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交） : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingHomeWorkAuditEntity.Status);

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
        /// RH_TrainingHomeWorkAudit : RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingHomeWorkAudit");
                strBuilder.Append("  set ");
                strBuilder.Append("    HomeWorkID=@HomeWorkID,");
                strBuilder.Append("    Auditor=@Auditor,");
                strBuilder.Append("    AuditTime=@AuditTime,");
                strBuilder.Append("    AuditDesc=@AuditDesc,");
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

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkAuditEntity.ID);

                ///HomeWorkID : int HomeWorkID
                m_sqlCmd.Parameters.AddWithValue("@HomeWorkID",paramTrainingHomeWorkAuditEntity.HomeWorkID);

                ///Auditor : int Auditor
                m_sqlCmd.Parameters.AddWithValue("@Auditor",paramTrainingHomeWorkAuditEntity.Auditor);

                ///AuditTime : datetime AuditTime
                if (paramTrainingHomeWorkAuditEntity.AuditTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@AuditTime", paramTrainingHomeWorkAuditEntity.AuditTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AuditTime", DBNull.Value);
                }

                ///审批意见 : nvarchar(200) AuditDesc
                if (paramTrainingHomeWorkAuditEntity.AuditDesc != null && "".Equals(paramTrainingHomeWorkAuditEntity.AuditDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AuditDesc", paramTrainingHomeWorkAuditEntity.AuditDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AuditDesc", DBNull.Value);
                }

                ///作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交） : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingHomeWorkAuditEntity.Status);

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
        /// RH_TrainingHomeWorkAudit : RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingHomeWorkAudit");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkAuditEntity.ID);

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
        /// RH_TrainingHomeWorkAudit : RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="TrainingHomeWorkAuditEntity"></returns>
        public TrainingHomeWorkAuditEntity SelectByPK(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingHomeWorkAuditEntity trainingHomeWorkAuditEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   HomeWorkID AS HomeWorkID,");
                strBuilder.Append("   Auditor AS Auditor,");
                strBuilder.Append("   AuditTime AS AuditTime,");
                strBuilder.Append("   AuditDesc AS AuditDesc,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_TrainingHomeWorkAudit");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkAuditEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingHomeWorkAuditEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingHomeWorkAuditEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingHomeWorkAudit : RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAuditEntity" type="TrainingHomeWorkAuditEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingHomeWorkAuditByForeignKeys(Object paramConnectionEntity, TrainingHomeWorkAuditEntity paramTrainingHomeWorkAuditEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingHomeWorkAuditEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   HomeWorkID AS HomeWorkID,");
                strBuilder.Append("   Auditor AS Auditor,");
                strBuilder.Append("   AuditTime AS AuditTime,");
                strBuilder.Append("   AuditDesc AS AuditDesc,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_TrainingHomeWorkAudit");
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
        /// <returns type="TrainingHomeWorkAuditEntity"></returns>
        private TrainingHomeWorkAuditEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingHomeWorkAuditMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}