using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Grade ( RH_Grade ) DB类
    ///</summary>
    public class GradeDB
    {

        /// <summary>
        /// 添加RH_Grade
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddGrade(GradeEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Grade_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Grade
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyGrade(GradeEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Grade_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveGrade(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Grade_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static GradeEntity GetGradeDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Grade_Detail", param, DBConnEnm.TRDBWrite);
            return (GradeEntity)ORMapping.MapSingleObject(typeof(GradeEntity),dt);
        }
    }
}