using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingStudyGroupUser ( RH_TrainingStudyGroupUser ) Dao类
    ///</summary>
    public class TrainingStudyGroupUserDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingStudyGroupUser : RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingStudyGroupUser");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    StudyGroupID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @StudyGroupID,");
                strBuilder.Append("    @UserID,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @CreateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupUserEntity.ID);

                ///StudyGroupID : int StudyGroupID
                m_sqlCmd.Parameters.AddWithValue("@StudyGroupID",paramTrainingStudyGroupUserEntity.StudyGroupID);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingStudyGroupUserEntity.UserID);

                ///1.正常2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingStudyGroupUserEntity.Status);

                ///发布时间 : datetime CreateTime
                if (paramTrainingStudyGroupUserEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingStudyGroupUserEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
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
        /// RH_TrainingStudyGroupUser : RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingStudyGroupUser");
                strBuilder.Append("  set ");
                strBuilder.Append("    StudyGroupID=@StudyGroupID,");
                strBuilder.Append("    UserID=@UserID,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    CreateTime=@CreateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupUserEntity.ID);

                ///StudyGroupID : int StudyGroupID
                m_sqlCmd.Parameters.AddWithValue("@StudyGroupID",paramTrainingStudyGroupUserEntity.StudyGroupID);

                ///UserID : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingStudyGroupUserEntity.UserID);

                ///1.正常2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingStudyGroupUserEntity.Status);

                ///发布时间 : datetime CreateTime
                if (paramTrainingStudyGroupUserEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingStudyGroupUserEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
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
        /// RH_TrainingStudyGroupUser : RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingStudyGroupUser");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupUserEntity.ID);

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
        /// RH_TrainingStudyGroupUser : RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="TrainingStudyGroupUserEntity"></returns>
        public TrainingStudyGroupUserEntity SelectByPK(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingStudyGroupUserEntity trainingStudyGroupUserEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   StudyGroupID AS StudyGroupID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingStudyGroupUser");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupUserEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingStudyGroupUserEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingStudyGroupUserEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingStudyGroupUser : RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingStudyGroupUserByForeignKeys(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingStudyGroupUserEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   StudyGroupID AS StudyGroupID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingStudyGroupUser");
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
        /// <returns type="TrainingStudyGroupUserEntity"></returns>
        private TrainingStudyGroupUserEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingStudyGroupUserMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}