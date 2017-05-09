using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_BannerArea ( RH_BannerArea ) Dao类
    ///</summary>
    public class BannerAreaDao
    {

        /// <summary>
        /// 添加
        /// RH_BannerArea : RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_BannerArea");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    AreaCode,");
                strBuilder.Append("    AreaName,");
                strBuilder.Append("    AreaWidth,");
                strBuilder.Append("    AreaHight,");
                strBuilder.Append("    AreaType,");
                strBuilder.Append("    AreaPicUrl");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @AreaCode,");
                strBuilder.Append("    @AreaName,");
                strBuilder.Append("    @AreaWidth,");
                strBuilder.Append("    @AreaHight,");
                strBuilder.Append("    @AreaType,");
                strBuilder.Append("    @AreaPicUrl");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerAreaEntity.ID);

                ///广告区域编码 : varchar(50) AreaCode
                if (paramBannerAreaEntity.AreaCode != null && "".Equals(paramBannerAreaEntity.AreaCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaCode", paramBannerAreaEntity.AreaCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaCode", DBNull.Value);
                }

                ///AreaName : nvarchar(50) AreaName
                if (paramBannerAreaEntity.AreaName != null && "".Equals(paramBannerAreaEntity.AreaName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaName", paramBannerAreaEntity.AreaName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaName", DBNull.Value);
                }

                ///AreaWidth : int AreaWidth
                m_sqlCmd.Parameters.AddWithValue("@AreaWidth",paramBannerAreaEntity.AreaWidth);

                ///AreaHight : int AreaHight
                m_sqlCmd.Parameters.AddWithValue("@AreaHight",paramBannerAreaEntity.AreaHight);

                ///区域位置:  1-主项目页面 2-阶段项目页面 3-学习页面 : int AreaType
                m_sqlCmd.Parameters.AddWithValue("@AreaType",paramBannerAreaEntity.AreaType);

                ///广告位置指示效果图 : nvarchar(50) AreaPicUrl
                if (paramBannerAreaEntity.AreaPicUrl != null && "".Equals(paramBannerAreaEntity.AreaPicUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaPicUrl", paramBannerAreaEntity.AreaPicUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaPicUrl", DBNull.Value);
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
        /// RH_BannerArea : RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_BannerArea");
                strBuilder.Append("  set ");
                strBuilder.Append("    AreaCode=@AreaCode,");
                strBuilder.Append("    AreaName=@AreaName,");
                strBuilder.Append("    AreaWidth=@AreaWidth,");
                strBuilder.Append("    AreaHight=@AreaHight,");
                strBuilder.Append("    AreaType=@AreaType,");
                strBuilder.Append("    AreaPicUrl=@AreaPicUrl");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerAreaEntity.ID);

                ///广告区域编码 : varchar(50) AreaCode
                if (paramBannerAreaEntity.AreaCode != null && "".Equals(paramBannerAreaEntity.AreaCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaCode", paramBannerAreaEntity.AreaCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaCode", DBNull.Value);
                }

                ///AreaName : nvarchar(50) AreaName
                if (paramBannerAreaEntity.AreaName != null && "".Equals(paramBannerAreaEntity.AreaName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaName", paramBannerAreaEntity.AreaName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaName", DBNull.Value);
                }

                ///AreaWidth : int AreaWidth
                m_sqlCmd.Parameters.AddWithValue("@AreaWidth",paramBannerAreaEntity.AreaWidth);

                ///AreaHight : int AreaHight
                m_sqlCmd.Parameters.AddWithValue("@AreaHight",paramBannerAreaEntity.AreaHight);

                ///区域位置:  1-主项目页面 2-阶段项目页面 3-学习页面 : int AreaType
                m_sqlCmd.Parameters.AddWithValue("@AreaType",paramBannerAreaEntity.AreaType);

                ///广告位置指示效果图 : nvarchar(50) AreaPicUrl
                if (paramBannerAreaEntity.AreaPicUrl != null && "".Equals(paramBannerAreaEntity.AreaPicUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaPicUrl", paramBannerAreaEntity.AreaPicUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaPicUrl", DBNull.Value);
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
        /// RH_BannerArea : RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_BannerArea");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerAreaEntity.ID);

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
        /// RH_BannerArea : RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="BannerAreaEntity"></returns>
        public BannerAreaEntity SelectByPK(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            BannerAreaEntity bannerAreaEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   AreaCode AS AreaCode,");
                strBuilder.Append("   AreaName AS AreaName,");
                strBuilder.Append("   AreaWidth AS AreaWidth,");
                strBuilder.Append("   AreaHight AS AreaHight,");
                strBuilder.Append("   AreaType AS AreaType,");
                strBuilder.Append("   AreaPicUrl AS AreaPicUrl");
                strBuilder.Append(" from RH_BannerArea");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerAreaEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        bannerAreaEntity = ParseDataRowToEntity(dataRows[0]);
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

            return bannerAreaEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_BannerArea : RH_BannerArea
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerAreaEntity" type="BannerAreaEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllBannerAreaByForeignKeys(Object paramConnectionEntity, BannerAreaEntity paramBannerAreaEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable bannerAreaEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   AreaCode AS AreaCode,");
                strBuilder.Append("   AreaName AS AreaName,");
                strBuilder.Append("   AreaWidth AS AreaWidth,");
                strBuilder.Append("   AreaHight AS AreaHight,");
                strBuilder.Append("   AreaType AS AreaType,");
                strBuilder.Append("   AreaPicUrl AS AreaPicUrl");
                strBuilder.Append(" from RH_BannerArea");
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
        /// <returns type="BannerAreaEntity"></returns>
        private BannerAreaEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return BannerAreaMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}