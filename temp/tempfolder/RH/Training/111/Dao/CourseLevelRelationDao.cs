using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) Dao类
    ///</summary>
    public class CourseLevelRelationDao
    {

        /// <summary>
        /// 添加
        /// RH_CourseLevelRelation : RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_CourseLevelRelation");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    CourseID,");
                strBuilder.Append("    CourseLevel");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @CourseID,");
                strBuilder.Append("    @CourseLevel");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseLevelRelationEntity.ID);

                ///CourseID : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramCourseLevelRelationEntity.CourseID);

                ///1初级2中级3高级 : int CourseLevel
                m_sqlCmd.Parameters.AddWithValue("@CourseLevel",paramCourseLevelRelationEntity.CourseLevel);

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
        /// RH_CourseLevelRelation : RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_CourseLevelRelation");
                strBuilder.Append("  set ");
                strBuilder.Append("    CourseID=@CourseID,");
                strBuilder.Append("    CourseLevel=@CourseLevel");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseLevelRelationEntity.ID);

                ///CourseID : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramCourseLevelRelationEntity.CourseID);

                ///1初级2中级3高级 : int CourseLevel
                m_sqlCmd.Parameters.AddWithValue("@CourseLevel",paramCourseLevelRelationEntity.CourseLevel);

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
        /// RH_CourseLevelRelation : RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_CourseLevelRelation");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseLevelRelationEntity.ID);

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
        /// RH_CourseLevelRelation : RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="CourseLevelRelationEntity"></returns>
        public CourseLevelRelationEntity SelectByPK(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CourseLevelRelationEntity courseLevelRelationEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   CourseLevel AS CourseLevel");
                strBuilder.Append(" from RH_CourseLevelRelation");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseLevelRelationEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        courseLevelRelationEntity = ParseDataRowToEntity(dataRows[0]);
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

            return courseLevelRelationEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_CourseLevelRelation : RH_CourseLevelRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseLevelRelationEntity" type="CourseLevelRelationEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCourseLevelRelationByForeignKeys(Object paramConnectionEntity, CourseLevelRelationEntity paramCourseLevelRelationEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable courseLevelRelationEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   CourseLevel AS CourseLevel");
                strBuilder.Append(" from RH_CourseLevelRelation");
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
        /// <returns type="CourseLevelRelationEntity"></returns>
        private CourseLevelRelationEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CourseLevelRelationMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}