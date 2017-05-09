using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) Dao类
    ///</summary>
    public class CourseThemeRelationDao
    {

        /// <summary>
        /// 添加
        /// RH_CourseThemeRelation : RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_CourseThemeRelation");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    CourseID,");
                strBuilder.Append("    CourseThemeCode");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @CourseID,");
                strBuilder.Append("    @CourseThemeCode");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseThemeRelationEntity.ID);

                ///课程id : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramCourseThemeRelationEntity.CourseID);

                ///能力提升课程代码 : varchar(50) CourseThemeCode
                if (paramCourseThemeRelationEntity.CourseThemeCode != null && "".Equals(paramCourseThemeRelationEntity.CourseThemeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseThemeCode", paramCourseThemeRelationEntity.CourseThemeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseThemeCode", DBNull.Value);
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
        /// RH_CourseThemeRelation : RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_CourseThemeRelation");
                strBuilder.Append("  set ");
                strBuilder.Append("    CourseID=@CourseID,");
                strBuilder.Append("    CourseThemeCode=@CourseThemeCode");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseThemeRelationEntity.ID);

                ///课程id : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramCourseThemeRelationEntity.CourseID);

                ///能力提升课程代码 : varchar(50) CourseThemeCode
                if (paramCourseThemeRelationEntity.CourseThemeCode != null && "".Equals(paramCourseThemeRelationEntity.CourseThemeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseThemeCode", paramCourseThemeRelationEntity.CourseThemeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CourseThemeCode", DBNull.Value);
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
        /// RH_CourseThemeRelation : RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_CourseThemeRelation");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseThemeRelationEntity.ID);

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
        /// RH_CourseThemeRelation : RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="CourseThemeRelationEntity"></returns>
        public CourseThemeRelationEntity SelectByPK(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CourseThemeRelationEntity courseThemeRelationEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   CourseThemeCode AS CourseThemeCode");
                strBuilder.Append(" from RH_CourseThemeRelation");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseThemeRelationEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        courseThemeRelationEntity = ParseDataRowToEntity(dataRows[0]);
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

            return courseThemeRelationEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_CourseThemeRelation : RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCourseThemeRelationByForeignKeys(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable courseThemeRelationEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   CourseThemeCode AS CourseThemeCode");
                strBuilder.Append(" from RH_CourseThemeRelation");
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
        /// <returns type="CourseThemeRelationEntity"></returns>
        private CourseThemeRelationEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CourseThemeRelationMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}