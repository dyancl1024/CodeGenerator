using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_CourseOption ( RH_CourseOption ) Dao类
    ///</summary>
    public class CourseOptionDao
    {

        /// <summary>
        /// 添加
        /// RH_CourseOption : RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_CourseOption");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    QuestionID,");
                strBuilder.Append("    QOption,");
                strBuilder.Append("    Sort,");
                strBuilder.Append("    IsRight");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @QuestionID,");
                strBuilder.Append("    @QOption,");
                strBuilder.Append("    @Sort,");
                strBuilder.Append("    @IsRight");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseOptionEntity.ID);

                ///QuestionID : int QuestionID
                m_sqlCmd.Parameters.AddWithValue("@QuestionID",paramCourseOptionEntity.QuestionID);

                ///QOption : nvarchar(200) QOption
                if (paramCourseOptionEntity.QOption != null && "".Equals(paramCourseOptionEntity.QOption.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QOption", paramCourseOptionEntity.QOption);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QOption", DBNull.Value);
                }

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramCourseOptionEntity.Sort);

                ///是否标准答案1是2否 : int IsRight
                m_sqlCmd.Parameters.AddWithValue("@IsRight",paramCourseOptionEntity.IsRight);

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
        /// RH_CourseOption : RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_CourseOption");
                strBuilder.Append("  set ");
                strBuilder.Append("    QuestionID=@QuestionID,");
                strBuilder.Append("    QOption=@QOption,");
                strBuilder.Append("    Sort=@Sort,");
                strBuilder.Append("    IsRight=@IsRight");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseOptionEntity.ID);

                ///QuestionID : int QuestionID
                m_sqlCmd.Parameters.AddWithValue("@QuestionID",paramCourseOptionEntity.QuestionID);

                ///QOption : nvarchar(200) QOption
                if (paramCourseOptionEntity.QOption != null && "".Equals(paramCourseOptionEntity.QOption.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QOption", paramCourseOptionEntity.QOption);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QOption", DBNull.Value);
                }

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramCourseOptionEntity.Sort);

                ///是否标准答案1是2否 : int IsRight
                m_sqlCmd.Parameters.AddWithValue("@IsRight",paramCourseOptionEntity.IsRight);

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
        /// RH_CourseOption : RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_CourseOption");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseOptionEntity.ID);

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
        /// RH_CourseOption : RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="CourseOptionEntity"></returns>
        public CourseOptionEntity SelectByPK(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CourseOptionEntity courseOptionEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   QuestionID AS QuestionID,");
                strBuilder.Append("   QOption AS QOption,");
                strBuilder.Append("   Sort AS Sort,");
                strBuilder.Append("   IsRight AS IsRight");
                strBuilder.Append(" from RH_CourseOption");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseOptionEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        courseOptionEntity = ParseDataRowToEntity(dataRows[0]);
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

            return courseOptionEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_CourseOption : RH_CourseOption
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseOptionEntity" type="CourseOptionEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCourseOptionByForeignKeys(Object paramConnectionEntity, CourseOptionEntity paramCourseOptionEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable courseOptionEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   QuestionID AS QuestionID,");
                strBuilder.Append("   QOption AS QOption,");
                strBuilder.Append("   Sort AS Sort,");
                strBuilder.Append("   IsRight AS IsRight");
                strBuilder.Append(" from RH_CourseOption");
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
        /// <returns type="CourseOptionEntity"></returns>
        private CourseOptionEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CourseOptionMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}