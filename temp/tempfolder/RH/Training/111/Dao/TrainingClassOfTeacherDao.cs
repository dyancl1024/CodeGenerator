using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) Dao类
    ///</summary>
    public class TrainingClassOfTeacherDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingClassOfTeacher : RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingClassOfTeacher");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    ClassID,");
                strBuilder.Append("    TeacherID,");
                strBuilder.Append("    Appointer,");
                strBuilder.Append("    AppointTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @ClassID,");
                strBuilder.Append("    @TeacherID,");
                strBuilder.Append("    @Appointer,");
                strBuilder.Append("    @AppointTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingClassOfTeacherEntity.ID);

                ///班级id  RH_Class : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingClassOfTeacherEntity.SubTID);

                ///ClassID : int ClassID
                m_sqlCmd.Parameters.AddWithValue("@ClassID",paramTrainingClassOfTeacherEntity.ClassID);

                ///辅导老师id RH_User表 : int TeacherID
                m_sqlCmd.Parameters.AddWithValue("@TeacherID",paramTrainingClassOfTeacherEntity.TeacherID);

                ///任命人 对应RH_User表id : int Appointer
                m_sqlCmd.Parameters.AddWithValue("@Appointer",paramTrainingClassOfTeacherEntity.Appointer);

                ///任命时间 : datetime AppointTime
                if (paramTrainingClassOfTeacherEntity.AppointTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@AppointTime", paramTrainingClassOfTeacherEntity.AppointTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AppointTime", DBNull.Value);
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
        /// RH_TrainingClassOfTeacher : RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingClassOfTeacher");
                strBuilder.Append("  set ");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    ClassID=@ClassID,");
                strBuilder.Append("    TeacherID=@TeacherID,");
                strBuilder.Append("    Appointer=@Appointer,");
                strBuilder.Append("    AppointTime=@AppointTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingClassOfTeacherEntity.ID);

                ///班级id  RH_Class : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingClassOfTeacherEntity.SubTID);

                ///ClassID : int ClassID
                m_sqlCmd.Parameters.AddWithValue("@ClassID",paramTrainingClassOfTeacherEntity.ClassID);

                ///辅导老师id RH_User表 : int TeacherID
                m_sqlCmd.Parameters.AddWithValue("@TeacherID",paramTrainingClassOfTeacherEntity.TeacherID);

                ///任命人 对应RH_User表id : int Appointer
                m_sqlCmd.Parameters.AddWithValue("@Appointer",paramTrainingClassOfTeacherEntity.Appointer);

                ///任命时间 : datetime AppointTime
                if (paramTrainingClassOfTeacherEntity.AppointTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@AppointTime", paramTrainingClassOfTeacherEntity.AppointTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AppointTime", DBNull.Value);
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
        /// RH_TrainingClassOfTeacher : RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingClassOfTeacher");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingClassOfTeacherEntity.ID);

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
        /// RH_TrainingClassOfTeacher : RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="TrainingClassOfTeacherEntity"></returns>
        public TrainingClassOfTeacherEntity SelectByPK(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingClassOfTeacherEntity trainingClassOfTeacherEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   ClassID AS ClassID,");
                strBuilder.Append("   TeacherID AS TeacherID,");
                strBuilder.Append("   Appointer AS Appointer,");
                strBuilder.Append("   AppointTime AS AppointTime");
                strBuilder.Append(" from RH_TrainingClassOfTeacher");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingClassOfTeacherEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingClassOfTeacherEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingClassOfTeacherEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingClassOfTeacher : RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingClassOfTeacherByForeignKeys(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingClassOfTeacherEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   ClassID AS ClassID,");
                strBuilder.Append("   TeacherID AS TeacherID,");
                strBuilder.Append("   Appointer AS Appointer,");
                strBuilder.Append("   AppointTime AS AppointTime");
                strBuilder.Append(" from RH_TrainingClassOfTeacher");
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
        /// <returns type="TrainingClassOfTeacherEntity"></returns>
        private TrainingClassOfTeacherEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingClassOfTeacherMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}