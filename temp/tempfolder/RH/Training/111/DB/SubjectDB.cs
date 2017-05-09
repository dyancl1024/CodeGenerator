using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Subject ( RH_Subject ) DB类
    ///</summary>
    public class SubjectDB
    {

        /// <summary>
        /// 添加RH_Subject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddSubject(SubjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Subject_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Subject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifySubject(SubjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Subject_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveSubject(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Subject_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Subject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SubjectEntity GetSubjectDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Subject_Detail", param, DBConnEnm.TRDBWrite);
            return (SubjectEntity)ORMapping.MapSingleObject(typeof(SubjectEntity),dt);
        }
    }
}