using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_CourseCategory ( RH_CourseCategory ) Dao类
    ///</summary>
    public class CourseCategoryDao
    {

        /// <summary>
        /// 添加
        /// RH_CourseCategory : RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_CourseCategory");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    Name,");
                strBuilder.Append("    Code,");
                strBuilder.Append("    Type,");
                strBuilder.Append("    Sort");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @Name,");
                strBuilder.Append("    @Code,");
                strBuilder.Append("    @Type,");
                strBuilder.Append("    @Sort");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseCategoryEntity.ID);

                ///通识、技术、教研、科研、专业、技术素养、计划与准备、组织与管理、评估与诊断、组织与发展 : nvarchar(50) Name
                if (paramCourseCategoryEntity.Name != null && "".Equals(paramCourseCategoryEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramCourseCategoryEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///Code : varchar(50) Code
                if (paramCourseCategoryEntity.Code != null && "".Equals(paramCourseCategoryEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramCourseCategoryEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///课程类型：1非能力2能力 : int Type
                m_sqlCmd.Parameters.AddWithValue("@Type",paramCourseCategoryEntity.Type);

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramCourseCategoryEntity.Sort);

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
        /// RH_CourseCategory : RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_CourseCategory");
                strBuilder.Append("  set ");
                strBuilder.Append("    Name=@Name,");
                strBuilder.Append("    Code=@Code,");
                strBuilder.Append("    Type=@Type,");
                strBuilder.Append("    Sort=@Sort");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseCategoryEntity.ID);

                ///通识、技术、教研、科研、专业、技术素养、计划与准备、组织与管理、评估与诊断、组织与发展 : nvarchar(50) Name
                if (paramCourseCategoryEntity.Name != null && "".Equals(paramCourseCategoryEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramCourseCategoryEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///Code : varchar(50) Code
                if (paramCourseCategoryEntity.Code != null && "".Equals(paramCourseCategoryEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramCourseCategoryEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///课程类型：1非能力2能力 : int Type
                m_sqlCmd.Parameters.AddWithValue("@Type",paramCourseCategoryEntity.Type);

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramCourseCategoryEntity.Sort);

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
        /// RH_CourseCategory : RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_CourseCategory");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseCategoryEntity.ID);

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
        /// RH_CourseCategory : RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="CourseCategoryEntity"></returns>
        public CourseCategoryEntity SelectByPK(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CourseCategoryEntity courseCategoryEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Type AS Type,");
                strBuilder.Append("   Sort AS Sort");
                strBuilder.Append(" from RH_CourseCategory");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseCategoryEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        courseCategoryEntity = ParseDataRowToEntity(dataRows[0]);
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

            return courseCategoryEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_CourseCategory : RH_CourseCategory
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseCategoryEntity" type="CourseCategoryEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCourseCategoryByForeignKeys(Object paramConnectionEntity, CourseCategoryEntity paramCourseCategoryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable courseCategoryEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Type AS Type,");
                strBuilder.Append("   Sort AS Sort");
                strBuilder.Append(" from RH_CourseCategory");
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
        /// <returns type="CourseCategoryEntity"></returns>
        private CourseCategoryEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CourseCategoryMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}