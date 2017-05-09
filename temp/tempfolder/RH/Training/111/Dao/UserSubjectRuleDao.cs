using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_UserSubjectRule ( RH_UserSubjectRule ) Dao类
    ///</summary>
    public class UserSubjectRuleDao
    {

        /// <summary>
        /// 添加
        /// RH_UserSubjectRule : RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_UserSubjectRule");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    UserID,");
                strBuilder.Append("    GradeCode,");
                strBuilder.Append("    SubjectCode,");
                strBuilder.Append("    TID");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @UserID,");
                strBuilder.Append("    @GradeCode,");
                strBuilder.Append("    @SubjectCode,");
                strBuilder.Append("    @TID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramUserSubjectRuleEntity.ID);

                ///用户id : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramUserSubjectRuleEntity.UserID);

                ///学段id : varchar(50) GradeCode
                if (paramUserSubjectRuleEntity.GradeCode != null && "".Equals(paramUserSubjectRuleEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramUserSubjectRuleEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///学科ID : varchar(50) SubjectCode
                if (paramUserSubjectRuleEntity.SubjectCode != null && "".Equals(paramUserSubjectRuleEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramUserSubjectRuleEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
                }

                ///子项目ID  一个学员在一个项目下只有一个学段学科 : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramUserSubjectRuleEntity.TID);

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
        /// RH_UserSubjectRule : RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_UserSubjectRule");
                strBuilder.Append("  set ");
                strBuilder.Append("    UserID=@UserID,");
                strBuilder.Append("    GradeCode=@GradeCode,");
                strBuilder.Append("    SubjectCode=@SubjectCode,");
                strBuilder.Append("    TID=@TID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramUserSubjectRuleEntity.ID);

                ///用户id : int UserID
                m_sqlCmd.Parameters.AddWithValue("@UserID",paramUserSubjectRuleEntity.UserID);

                ///学段id : varchar(50) GradeCode
                if (paramUserSubjectRuleEntity.GradeCode != null && "".Equals(paramUserSubjectRuleEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramUserSubjectRuleEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///学科ID : varchar(50) SubjectCode
                if (paramUserSubjectRuleEntity.SubjectCode != null && "".Equals(paramUserSubjectRuleEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramUserSubjectRuleEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
                }

                ///子项目ID  一个学员在一个项目下只有一个学段学科 : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramUserSubjectRuleEntity.TID);

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
        /// RH_UserSubjectRule : RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_UserSubjectRule");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramUserSubjectRuleEntity.ID);

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
        /// RH_UserSubjectRule : RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="UserSubjectRuleEntity"></returns>
        public UserSubjectRuleEntity SelectByPK(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            UserSubjectRuleEntity userSubjectRuleEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   SubjectCode AS SubjectCode,");
                strBuilder.Append("   TID AS TID");
                strBuilder.Append(" from RH_UserSubjectRule");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramUserSubjectRuleEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        userSubjectRuleEntity = ParseDataRowToEntity(dataRows[0]);
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

            return userSubjectRuleEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_UserSubjectRule : RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllUserSubjectRuleByForeignKeys(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable userSubjectRuleEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   UserID AS UserID,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   SubjectCode AS SubjectCode,");
                strBuilder.Append("   TID AS TID");
                strBuilder.Append(" from RH_UserSubjectRule");
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
        /// <returns type="UserSubjectRuleEntity"></returns>
        private UserSubjectRuleEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return UserSubjectRuleMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}