using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) DB类
    ///</summary>
    public class CourseLevelRelationDB
    {

        /// <summary>
        /// 添加RH_CourseLevelRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseLevelRelation(CourseLevelRelationEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseLevelRelation_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseLevelRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseLevelRelation(CourseLevelRelationEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CourseLevelRelation_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseLevelRelation(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseLevelRelation_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseLevelRelationEntity GetCourseLevelRelationDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CourseLevelRelation_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseLevelRelationEntity)ORMapping.MapSingleObject(typeof(CourseLevelRelationEntity),dt);
        }
    }
}