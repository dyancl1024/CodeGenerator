using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_GradeSubjectRelation ( RH_GradeSubjectRelation ) DB类
    ///</summary>
    public class GradeSubjectRelationDB
    {

        /// <summary>
        /// 添加RH_GradeSubjectRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddGradeSubjectRelation(GradeSubjectRelationEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_GradeSubjectRelation_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_GradeSubjectRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyGradeSubjectRelation(GradeSubjectRelationEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_GradeSubjectRelation_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveGradeSubjectRelation(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_GradeSubjectRelation_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static GradeSubjectRelationEntity GetGradeSubjectRelationDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_GradeSubjectRelation_Detail", param, DBConnEnm.TRDBWrite);
            return (GradeSubjectRelationEntity)ORMapping.MapSingleObject(typeof(GradeSubjectRelationEntity),dt);
        }
    }
}