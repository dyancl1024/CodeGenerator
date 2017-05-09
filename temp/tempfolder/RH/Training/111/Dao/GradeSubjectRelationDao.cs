using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_GradeSubjectRelation ( RH_GradeSubjectRelation ) Dao类
    ///</summary>
    public class GradeSubjectRelationDao
    {

        /// <summary>
        /// 添加
        /// RH_GradeSubjectRelation : RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_GradeSubjectRelation");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    GradeCode,");
                strBuilder.Append("    SubjectCode");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @GradeCode,");
                strBuilder.Append("    @SubjectCode");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramGradeSubjectRelationEntity.ID);

                ///学段代码 : varchar(50) GradeCode
                if (paramGradeSubjectRelationEntity.GradeCode != null && "".Equals(paramGradeSubjectRelationEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramGradeSubjectRelationEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///学科code : varchar(50) SubjectCode
                if (paramGradeSubjectRelationEntity.SubjectCode != null && "".Equals(paramGradeSubjectRelationEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramGradeSubjectRelationEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
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
        /// RH_GradeSubjectRelation : RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_GradeSubjectRelation");
                strBuilder.Append("  set ");
                strBuilder.Append("    GradeCode=@GradeCode,");
                strBuilder.Append("    SubjectCode=@SubjectCode");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramGradeSubjectRelationEntity.ID);

                ///学段代码 : varchar(50) GradeCode
                if (paramGradeSubjectRelationEntity.GradeCode != null && "".Equals(paramGradeSubjectRelationEntity.GradeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", paramGradeSubjectRelationEntity.GradeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@GradeCode", DBNull.Value);
                }

                ///学科code : varchar(50) SubjectCode
                if (paramGradeSubjectRelationEntity.SubjectCode != null && "".Equals(paramGradeSubjectRelationEntity.SubjectCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", paramGradeSubjectRelationEntity.SubjectCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SubjectCode", DBNull.Value);
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
        /// RH_GradeSubjectRelation : RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_GradeSubjectRelation");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramGradeSubjectRelationEntity.ID);

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
        /// RH_GradeSubjectRelation : RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="GradeSubjectRelationEntity"></returns>
        public GradeSubjectRelationEntity SelectByPK(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            GradeSubjectRelationEntity gradeSubjectRelationEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   SubjectCode AS SubjectCode");
                strBuilder.Append(" from RH_GradeSubjectRelation");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramGradeSubjectRelationEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        gradeSubjectRelationEntity = ParseDataRowToEntity(dataRows[0]);
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

            return gradeSubjectRelationEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_GradeSubjectRelation : RH_GradeSubjectRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeSubjectRelationEntity" type="GradeSubjectRelationEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllGradeSubjectRelationByForeignKeys(Object paramConnectionEntity, GradeSubjectRelationEntity paramGradeSubjectRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable gradeSubjectRelationEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   GradeCode AS GradeCode,");
                strBuilder.Append("   SubjectCode AS SubjectCode");
                strBuilder.Append(" from RH_GradeSubjectRelation");
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
        /// <returns type="GradeSubjectRelationEntity"></returns>
        private GradeSubjectRelationEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return GradeSubjectRelationMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}