using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignSubject ( RH_DesignSubject ) DB类
    ///</summary>
    public class DesignSubjectDB
    {

        /// <summary>
        /// 添加RH_DesignSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignSubject(DesignSubjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignSubject_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignSubject(DesignSubjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_DesignSubject_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignSubject(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignSubject_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSubjectEntity GetDesignSubjectDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_DesignSubject_Detail", param, DBConnEnm.TRDBWrite);
            return (DesignSubjectEntity)ORMapping.MapSingleObject(typeof(DesignSubjectEntity),dt);
        }
    }
}