using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) Dao类
    ///</summary>
    public class CoursePreSetListDao
    {

        /// <summary>
        /// 添加
        /// RH_CoursePreSetList : RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_CoursePreSetList");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    PreSetID,");
                strBuilder.Append("    CourseID");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @PreSetID,");
                strBuilder.Append("    @CourseID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCoursePreSetListEntity.ID);

                ///PreSetID : int PreSetID
                m_sqlCmd.Parameters.AddWithValue("@PreSetID",paramCoursePreSetListEntity.PreSetID);

                ///CourseID : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramCoursePreSetListEntity.CourseID);

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
        /// RH_CoursePreSetList : RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_CoursePreSetList");
                strBuilder.Append("  set ");
                strBuilder.Append("    PreSetID=@PreSetID,");
                strBuilder.Append("    CourseID=@CourseID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCoursePreSetListEntity.ID);

                ///PreSetID : int PreSetID
                m_sqlCmd.Parameters.AddWithValue("@PreSetID",paramCoursePreSetListEntity.PreSetID);

                ///CourseID : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramCoursePreSetListEntity.CourseID);

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
        /// RH_CoursePreSetList : RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_CoursePreSetList");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCoursePreSetListEntity.ID);

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
        /// RH_CoursePreSetList : RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="CoursePreSetListEntity"></returns>
        public CoursePreSetListEntity SelectByPK(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CoursePreSetListEntity coursePreSetListEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   PreSetID AS PreSetID,");
                strBuilder.Append("   CourseID AS CourseID");
                strBuilder.Append(" from RH_CoursePreSetList");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCoursePreSetListEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        coursePreSetListEntity = ParseDataRowToEntity(dataRows[0]);
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

            return coursePreSetListEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_CoursePreSetList : RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCoursePreSetListByForeignKeys(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable coursePreSetListEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   PreSetID AS PreSetID,");
                strBuilder.Append("   CourseID AS CourseID");
                strBuilder.Append(" from RH_CoursePreSetList");
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
        /// <returns type="CoursePreSetListEntity"></returns>
        private CoursePreSetListEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CoursePreSetListMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}