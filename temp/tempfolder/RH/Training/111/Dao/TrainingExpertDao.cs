using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingExpert ( RH_TrainingExpert ) Dao类
    ///</summary>
    public class TrainingExpertDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingExpert : RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingExpert");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    TID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @TID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @UserID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertEntity.ID);

                ///TID : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingExpertEntity.TID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingExpertEntity.SubTID);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingExpertEntity.UserID);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingExpertEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingExpertEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingExpertEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingExpertEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingExpertEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingExpertEntity.UpdateTime);
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
        /// RH_TrainingExpert : RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingExpert");
                strBuilder.Append("  set ");
                strBuilder.Append("    TID=@TID,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    UserID=@UserID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertEntity.ID);

                ///TID : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingExpertEntity.TID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingExpertEntity.SubTID);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingExpertEntity.UserID);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingExpertEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingExpertEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingExpertEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingExpertEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingExpertEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingExpertEntity.UpdateTime);
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
        /// RH_TrainingExpert : RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingExpert");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertEntity.ID);

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
        /// RH_TrainingExpert : RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="TrainingExpertEntity"></returns>
        public TrainingExpertEntity SelectByPK(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingExpertEntity trainingExpertEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingExpert");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingExpertEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingExpertEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingExpert : RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingExpertByForeignKeys(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingExpertEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingExpert");
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
        /// <returns type="TrainingExpertEntity"></returns>
        private TrainingExpertEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingExpertMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}