using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingMyCourse ( RH_TrainingMyCourse ) Dao类
    ///</summary>
    public class TrainingMyCourseDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingMyCourse : RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingMyCourse");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    PCID,");
                strBuilder.Append("    CID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    Status");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @PCID,");
                strBuilder.Append("    @CID,");
                strBuilder.Append("    @UserID,");
                strBuilder.Append("    @CreateTime,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyCourseEntity.ID);

                ///项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingMyCourseEntity.SubTID);

                ///套餐id，对应课程预设表 : int PCID
                m_sqlCmd.Parameters.AddWithValue("@PCID",paramTrainingMyCourseEntity.PCID);

                ///课程id : int CID
                m_sqlCmd.Parameters.AddWithValue("@CID",paramTrainingMyCourseEntity.CID);

                ///学员id : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingMyCourseEntity.UserID);

                ///选课时间 : datetime CreateTime
                if (paramTrainingMyCourseEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingMyCourseEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///选课状态：1.正常2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingMyCourseEntity.Status);

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
        /// RH_TrainingMyCourse : RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingMyCourse");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    PCID=@PCID,");
                strBuilder.Append("    CID=@CID,");
                strBuilder.Append("    UserID=@UserID,");
                strBuilder.Append("    CreateTime=@CreateTime,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyCourseEntity.ID);

                ///项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingMyCourseEntity.SubTID);

                ///套餐id，对应课程预设表 : int PCID
                m_sqlCmd.Parameters.AddWithValue("@PCID",paramTrainingMyCourseEntity.PCID);

                ///课程id : int CID
                m_sqlCmd.Parameters.AddWithValue("@CID",paramTrainingMyCourseEntity.CID);

                ///学员id : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramTrainingMyCourseEntity.UserID);

                ///选课时间 : datetime CreateTime
                if (paramTrainingMyCourseEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingMyCourseEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///选课状态：1.正常2.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingMyCourseEntity.Status);

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
        /// RH_TrainingMyCourse : RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingMyCourse");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyCourseEntity.ID);

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
        /// RH_TrainingMyCourse : RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="TrainingMyCourseEntity"></returns>
        public TrainingMyCourseEntity SelectByPK(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingMyCourseEntity trainingMyCourseEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   PCID AS PCID,");
                strBuilder.Append("   CID AS CID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_TrainingMyCourse");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingMyCourseEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingMyCourseEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingMyCourseEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingMyCourse : RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingMyCourseByForeignKeys(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingMyCourseEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   PCID AS PCID,");
                strBuilder.Append("   CID AS CID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_TrainingMyCourse");
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
        /// <returns type="TrainingMyCourseEntity"></returns>
        private TrainingMyCourseEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingMyCourseMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}