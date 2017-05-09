using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Design ( RH_Design ) Dao类
    ///</summary>
    public class DesignDao
    {

        /// <summary>
        /// 添加
        /// RH_Design : RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Design");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DesignName,");
                strBuilder.Append("    TrainingLevelCode,");
                strBuilder.Append("    TrainingTypeCode,");
                strBuilder.Append("    ProvinceID,");
                strBuilder.Append("    CityID,");
                strBuilder.Append("    DistrictID,");
                strBuilder.Append("    OrgCode,");
                strBuilder.Append("    TrainingNum,");
                strBuilder.Append("    TrainingPhase,");
                strBuilder.Append("    TrainingDateB,");
                strBuilder.Append("    TrainingDateE,");
                strBuilder.Append("    DesignDesc,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DesignName,");
                strBuilder.Append("    @TrainingLevelCode,");
                strBuilder.Append("    @TrainingTypeCode,");
                strBuilder.Append("    @ProvinceID,");
                strBuilder.Append("    @CityID,");
                strBuilder.Append("    @DistrictID,");
                strBuilder.Append("    @OrgCode,");
                strBuilder.Append("    @TrainingNum,");
                strBuilder.Append("    @TrainingPhase,");
                strBuilder.Append("    @TrainingDateB,");
                strBuilder.Append("    @TrainingDateE,");
                strBuilder.Append("    @DesignDesc,");
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

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignEntity.ID);

                ///社区id : nvarchar(50) DesignName
                if (paramDesignEntity.DesignName != null && "".Equals(paramDesignEntity.DesignName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DesignName", paramDesignEntity.DesignName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DesignName", DBNull.Value);
                }

                ///承担机构id 对应表FJ_TrainingOrg的ID : varchar(50) TrainingLevelCode
                if (paramDesignEntity.TrainingLevelCode != null && "".Equals(paramDesignEntity.TrainingLevelCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", paramDesignEntity.TrainingLevelCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", DBNull.Value);
                }

                ///TrainingTypeCode : varchar(50) TrainingTypeCode
                if (paramDesignEntity.TrainingTypeCode != null && "".Equals(paramDesignEntity.TrainingTypeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", paramDesignEntity.TrainingTypeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramDesignEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramDesignEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramDesignEntity.DistrictID);

                ///OrgCode : varchar(50) OrgCode
                if (paramDesignEntity.OrgCode != null && "".Equals(paramDesignEntity.OrgCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@OrgCode", paramDesignEntity.OrgCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@OrgCode", DBNull.Value);
                }

                ///项目名称 : int TrainingNum
                m_sqlCmd.Parameters.AddWithValue("@TrainingNum",paramDesignEntity.TrainingNum);

                ///学时 : int TrainingPhase
                m_sqlCmd.Parameters.AddWithValue("@TrainingPhase",paramDesignEntity.TrainingPhase);

                ///时间安排起 : datetime TrainingDateB
                if (paramDesignEntity.TrainingDateB > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", paramDesignEntity.TrainingDateB);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", DBNull.Value);
                }

                ///时间安排止 : datetime TrainingDateE
                if (paramDesignEntity.TrainingDateE > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", paramDesignEntity.TrainingDateE);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", DBNull.Value);
                }

                ///DesignDesc : nvarchar(Max) DesignDesc
                if (paramDesignEntity.DesignDesc != null && "".Equals(paramDesignEntity.DesignDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DesignDesc", paramDesignEntity.DesignDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DesignDesc", DBNull.Value);
                }

                ///1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.不通过（对应的动作提交审批） 5.立项（对应的动作分配教务） 6.不立项（对应的动作分配教务） : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramDesignEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramDesignEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramDesignEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramDesignEntity.UpdateTime);
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
        /// RH_Design : RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Design");
                strBuilder.Append("  set ");
                strBuilder.Append("    DesignName=@DesignName,");
                strBuilder.Append("    TrainingLevelCode=@TrainingLevelCode,");
                strBuilder.Append("    TrainingTypeCode=@TrainingTypeCode,");
                strBuilder.Append("    ProvinceID=@ProvinceID,");
                strBuilder.Append("    CityID=@CityID,");
                strBuilder.Append("    DistrictID=@DistrictID,");
                strBuilder.Append("    OrgCode=@OrgCode,");
                strBuilder.Append("    TrainingNum=@TrainingNum,");
                strBuilder.Append("    TrainingPhase=@TrainingPhase,");
                strBuilder.Append("    TrainingDateB=@TrainingDateB,");
                strBuilder.Append("    TrainingDateE=@TrainingDateE,");
                strBuilder.Append("    DesignDesc=@DesignDesc,");
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

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignEntity.ID);

                ///社区id : nvarchar(50) DesignName
                if (paramDesignEntity.DesignName != null && "".Equals(paramDesignEntity.DesignName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DesignName", paramDesignEntity.DesignName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DesignName", DBNull.Value);
                }

                ///承担机构id 对应表FJ_TrainingOrg的ID : varchar(50) TrainingLevelCode
                if (paramDesignEntity.TrainingLevelCode != null && "".Equals(paramDesignEntity.TrainingLevelCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", paramDesignEntity.TrainingLevelCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", DBNull.Value);
                }

                ///TrainingTypeCode : varchar(50) TrainingTypeCode
                if (paramDesignEntity.TrainingTypeCode != null && "".Equals(paramDesignEntity.TrainingTypeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", paramDesignEntity.TrainingTypeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramDesignEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramDesignEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramDesignEntity.DistrictID);

                ///OrgCode : varchar(50) OrgCode
                if (paramDesignEntity.OrgCode != null && "".Equals(paramDesignEntity.OrgCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@OrgCode", paramDesignEntity.OrgCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@OrgCode", DBNull.Value);
                }

                ///项目名称 : int TrainingNum
                m_sqlCmd.Parameters.AddWithValue("@TrainingNum",paramDesignEntity.TrainingNum);

                ///学时 : int TrainingPhase
                m_sqlCmd.Parameters.AddWithValue("@TrainingPhase",paramDesignEntity.TrainingPhase);

                ///时间安排起 : datetime TrainingDateB
                if (paramDesignEntity.TrainingDateB > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", paramDesignEntity.TrainingDateB);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", DBNull.Value);
                }

                ///时间安排止 : datetime TrainingDateE
                if (paramDesignEntity.TrainingDateE > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", paramDesignEntity.TrainingDateE);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", DBNull.Value);
                }

                ///DesignDesc : nvarchar(Max) DesignDesc
                if (paramDesignEntity.DesignDesc != null && "".Equals(paramDesignEntity.DesignDesc.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DesignDesc", paramDesignEntity.DesignDesc);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DesignDesc", DBNull.Value);
                }

                ///1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.不通过（对应的动作提交审批） 5.立项（对应的动作分配教务） 6.不立项（对应的动作分配教务） : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramDesignEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramDesignEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramDesignEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramDesignEntity.UpdateTime);
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
        /// RH_Design : RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Design");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignEntity.ID);

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
        /// RH_Design : RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="DesignEntity"></returns>
        public DesignEntity SelectByPK(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DesignEntity designEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignName AS DesignName,");
                strBuilder.Append("   TrainingLevelCode AS TrainingLevelCode,");
                strBuilder.Append("   TrainingTypeCode AS TrainingTypeCode,");
                strBuilder.Append("   ProvinceID AS ProvinceID,");
                strBuilder.Append("   CityID AS CityID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   OrgCode AS OrgCode,");
                strBuilder.Append("   TrainingNum AS TrainingNum,");
                strBuilder.Append("   TrainingPhase AS TrainingPhase,");
                strBuilder.Append("   TrainingDateB AS TrainingDateB,");
                strBuilder.Append("   TrainingDateE AS TrainingDateE,");
                strBuilder.Append("   DesignDesc AS DesignDesc,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_Design");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        designEntity = ParseDataRowToEntity(dataRows[0]);
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

            return designEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Design : RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllDesignByForeignKeys(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable designEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignName AS DesignName,");
                strBuilder.Append("   TrainingLevelCode AS TrainingLevelCode,");
                strBuilder.Append("   TrainingTypeCode AS TrainingTypeCode,");
                strBuilder.Append("   ProvinceID AS ProvinceID,");
                strBuilder.Append("   CityID AS CityID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   OrgCode AS OrgCode,");
                strBuilder.Append("   TrainingNum AS TrainingNum,");
                strBuilder.Append("   TrainingPhase AS TrainingPhase,");
                strBuilder.Append("   TrainingDateB AS TrainingDateB,");
                strBuilder.Append("   TrainingDateE AS TrainingDateE,");
                strBuilder.Append("   DesignDesc AS DesignDesc,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_Design");
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
        /// <returns type="DesignEntity"></returns>
        private DesignEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return DesignMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}