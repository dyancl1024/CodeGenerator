using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) DB类
    ///</summary>
    public class TrainingClassOfTeacherDB
    {

        /// <summary>
        /// 添加RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClassOfTeacher(TrainingClassOfTeacherEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClassOfTeacher_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClassOfTeacher(TrainingClassOfTeacherEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClassOfTeacher_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClassOfTeacher(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClassOfTeacher_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassOfTeacherEntity GetTrainingClassOfTeacherDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingClassOfTeacher_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingClassOfTeacherEntity)ORMapping.MapSingleObject(typeof(TrainingClassOfTeacherEntity),dt);
        }
    }
}