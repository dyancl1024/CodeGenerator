using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingSubSubject ( RH_TrainingSubSubject ) DB类
    ///</summary>
    public class TrainingSubSubjectDB
    {

        /// <summary>
        /// 添加RH_TrainingSubSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingSubSubject(TrainingSubSubjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingSubSubject_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingSubSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingSubSubject(TrainingSubSubjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingSubSubject_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingSubSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingSubSubject(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingSubSubject_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingSubSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubSubjectEntity GetTrainingSubSubjectDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingSubSubject_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingSubSubjectEntity)ORMapping.MapSingleObject(typeof(TrainingSubSubjectEntity),dt);
        }
    }
}