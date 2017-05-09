using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignContentAttachment ( RH_DesignContentAttachment ) DB类
    ///</summary>
    public class DesignContentAttachmentDB
    {

        /// <summary>
        /// 添加RH_DesignContentAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignContentAttachment(DesignContentAttachmentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignContentAttachment_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignContentAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignContentAttachment(DesignContentAttachmentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_DesignContentAttachment_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignContentAttachment(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignContentAttachment_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentAttachmentEntity GetDesignContentAttachmentDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_DesignContentAttachment_Detail", param, DBConnEnm.TRDBWrite);
            return (DesignContentAttachmentEntity)ORMapping.MapSingleObject(typeof(DesignContentAttachmentEntity),dt);
        }
    }
}