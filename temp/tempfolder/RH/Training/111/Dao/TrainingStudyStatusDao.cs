using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingStudyStatus ( RH_TrainingStudyStatus ) Dao类
    ///</summary>
    public class TrainingStudyStatusDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingStudyStatus : RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingStudyStatus");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    PCID,");
                strBuilder.Append("    CID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    UserID");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @PCID,");
                strBuilder.Append("    @CID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @UserID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyStatusEntity.ID);

                ///PCID : int PCID
                m_sqlCmd.Parameters.AddWithValue("@PCID",paramTrainingStudyStatusEntity.PCID);

                ///课程ID : int CID
                m_sqlCmd.Parameters.AddWithValue("@CID",paramTrainingStudyStatusEntity.CID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingStudyStatusEntity.SubTID);

                ///课程学习状态：1学习中2.完成学习 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingStudyStatusEntity.Status);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingStudyStatusEntity.UserID);

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
        /// RH_TrainingStudyStatus : RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingStudyStatus");
                strBuilder.Append("  set ");
                strBuilder.Append("    PCID=@PCID,");
                strBuilder.Append("    CID=@CID,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    UserID=@UserID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyStatusEntity.ID);

                ///PCID : int PCID
                m_sqlCmd.Parameters.AddWithValue("@PCID",paramTrainingStudyStatusEntity.PCID);

                ///课程ID : int CID
                m_sqlCmd.Parameters.AddWithValue("@CID",paramTrainingStudyStatusEntity.CID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingStudyStatusEntity.SubTID);

                ///课程学习状态：1学习中2.完成学习 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingStudyStatusEntity.Status);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingStudyStatusEntity.UserID);

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
        /// RH_TrainingStudyStatus : RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingStudyStatus");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyStatusEntity.ID);

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
        /// RH_TrainingStudyStatus : RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="TrainingStudyStatusEntity"></returns>
        public TrainingStudyStatusEntity SelectByPK(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingStudyStatusEntity trainingStudyStatusEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   PCID AS PCID,");
                strBuilder.Append("   CID AS CID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   UserID AS UserID");
                strBuilder.Append(" from RH_TrainingStudyStatus");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyStatusEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingStudyStatusEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingStudyStatusEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingStudyStatus : RH_TrainingStudyStatus
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyStatusEntity" type="TrainingStudyStatusEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingStudyStatusByForeignKeys(Object paramConnectionEntity, TrainingStudyStatusEntity paramTrainingStudyStatusEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingStudyStatusEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   PCID AS PCID,");
                strBuilder.Append("   CID AS CID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   UserID AS UserID");
                strBuilder.Append(" from RH_TrainingStudyStatus");
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
        /// <returns type="TrainingStudyStatusEntity"></returns>
        private TrainingStudyStatusEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingStudyStatusMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}