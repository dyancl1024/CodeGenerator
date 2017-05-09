using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Banner ( RH_Banner ) Dao类
    ///</summary>
    public class BannerDao
    {

        /// <summary>
        /// 添加
        /// RH_Banner : RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Banner");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    ADTitle,");
                strBuilder.Append("    AreaCode,");
                strBuilder.Append("    ADPhotoUrl,");
                strBuilder.Append("    ADContentType,");
                strBuilder.Append("    ADContentURL,");
                strBuilder.Append("    ADContent,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @ADTitle,");
                strBuilder.Append("    @AreaCode,");
                strBuilder.Append("    @ADPhotoUrl,");
                strBuilder.Append("    @ADContentType,");
                strBuilder.Append("    @ADContentURL,");
                strBuilder.Append("    @ADContent,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
                strBuilder.Append("    @UpdateBy,");
                strBuilder.Append("    @UpdateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerEntity.ID);

                ///AD标题 : nvarchar(200) ADTitle
                if (paramBannerEntity.ADTitle != null && "".Equals(paramBannerEntity.ADTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADTitle", paramBannerEntity.ADTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADTitle", DBNull.Value);
                }

                ///区域： 1- 区域1（图片），2-区域2（图片）  3-区域3（图片） 4-区域4.... : varchar(50) AreaCode
                if (paramBannerEntity.AreaCode != null && "".Equals(paramBannerEntity.AreaCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaCode", paramBannerEntity.AreaCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaCode", DBNull.Value);
                }

                ///上传广告图片URL(由区域决定是否为图片广告) : nvarchar(200) ADPhotoUrl
                if (paramBannerEntity.ADPhotoUrl != null && "".Equals(paramBannerEntity.ADPhotoUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADPhotoUrl", paramBannerEntity.ADPhotoUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADPhotoUrl", DBNull.Value);
                }

                ///广告内容形式  1-编辑内容  2-链接URL : int ADContentType
                m_sqlCmd.Parameters.AddWithValue("@ADContentType",paramBannerEntity.ADContentType);

                ///内容链接URL : nvarchar(200) ADContentURL
                if (paramBannerEntity.ADContentURL != null && "".Equals(paramBannerEntity.ADContentURL.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADContentURL", paramBannerEntity.ADContentURL);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADContentURL", DBNull.Value);
                }

                ///AD内容(存放编辑的内容或链接URL) : nvarchar(Max) ADContent
                if (paramBannerEntity.ADContent != null && "".Equals(paramBannerEntity.ADContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADContent", paramBannerEntity.ADContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADContent", DBNull.Value);
                }

                ///1-未发布 2-已发布  3-删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramBannerEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramBannerEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramBannerEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramBannerEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///修改人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramBannerEntity.UpdateBy);

                ///修改时间 : datetime UpdateTime
                if (paramBannerEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramBannerEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
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
        /// RH_Banner : RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Banner");
                strBuilder.Append("  set ");
                strBuilder.Append("    ADTitle=@ADTitle,");
                strBuilder.Append("    AreaCode=@AreaCode,");
                strBuilder.Append("    ADPhotoUrl=@ADPhotoUrl,");
                strBuilder.Append("    ADContentType=@ADContentType,");
                strBuilder.Append("    ADContentURL=@ADContentURL,");
                strBuilder.Append("    ADContent=@ADContent,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
                strBuilder.Append("    UpdateBy=@UpdateBy,");
                strBuilder.Append("    UpdateTime=@UpdateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerEntity.ID);

                ///AD标题 : nvarchar(200) ADTitle
                if (paramBannerEntity.ADTitle != null && "".Equals(paramBannerEntity.ADTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADTitle", paramBannerEntity.ADTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADTitle", DBNull.Value);
                }

                ///区域： 1- 区域1（图片），2-区域2（图片）  3-区域3（图片） 4-区域4.... : varchar(50) AreaCode
                if (paramBannerEntity.AreaCode != null && "".Equals(paramBannerEntity.AreaCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaCode", paramBannerEntity.AreaCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AreaCode", DBNull.Value);
                }

                ///上传广告图片URL(由区域决定是否为图片广告) : nvarchar(200) ADPhotoUrl
                if (paramBannerEntity.ADPhotoUrl != null && "".Equals(paramBannerEntity.ADPhotoUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADPhotoUrl", paramBannerEntity.ADPhotoUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADPhotoUrl", DBNull.Value);
                }

                ///广告内容形式  1-编辑内容  2-链接URL : int ADContentType
                m_sqlCmd.Parameters.AddWithValue("@ADContentType",paramBannerEntity.ADContentType);

                ///内容链接URL : nvarchar(200) ADContentURL
                if (paramBannerEntity.ADContentURL != null && "".Equals(paramBannerEntity.ADContentURL.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADContentURL", paramBannerEntity.ADContentURL);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADContentURL", DBNull.Value);
                }

                ///AD内容(存放编辑的内容或链接URL) : nvarchar(Max) ADContent
                if (paramBannerEntity.ADContent != null && "".Equals(paramBannerEntity.ADContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADContent", paramBannerEntity.ADContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ADContent", DBNull.Value);
                }

                ///1-未发布 2-已发布  3-删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramBannerEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramBannerEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramBannerEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramBannerEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///修改人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramBannerEntity.UpdateBy);

                ///修改时间 : datetime UpdateTime
                if (paramBannerEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramBannerEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
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
        /// RH_Banner : RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Banner");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerEntity.ID);

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
        /// RH_Banner : RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="BannerEntity"></returns>
        public BannerEntity SelectByPK(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            BannerEntity bannerEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ADTitle AS ADTitle,");
                strBuilder.Append("   AreaCode AS AreaCode,");
                strBuilder.Append("   ADPhotoUrl AS ADPhotoUrl,");
                strBuilder.Append("   ADContentType AS ADContentType,");
                strBuilder.Append("   ADContentURL AS ADContentURL,");
                strBuilder.Append("   ADContent AS ADContent,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_Banner");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        bannerEntity = ParseDataRowToEntity(dataRows[0]);
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

            return bannerEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Banner : RH_Banner
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerEntity" type="BannerEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllBannerByForeignKeys(Object paramConnectionEntity, BannerEntity paramBannerEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable bannerEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ADTitle AS ADTitle,");
                strBuilder.Append("   AreaCode AS AreaCode,");
                strBuilder.Append("   ADPhotoUrl AS ADPhotoUrl,");
                strBuilder.Append("   ADContentType AS ADContentType,");
                strBuilder.Append("   ADContentURL AS ADContentURL,");
                strBuilder.Append("   ADContent AS ADContent,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_Banner");
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
        /// <returns type="BannerEntity"></returns>
        private BannerEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return BannerMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}