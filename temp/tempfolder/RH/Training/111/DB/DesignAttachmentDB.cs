using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignAttachment ( RH_DesignAttachment ) DB类
    ///</summary>
    public class DesignAttachmentDB
    {

        /// <summary>
        /// 添加RH_DesignAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignAttachment(DesignAttachmentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignAttachment_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignAttachment(DesignAttachmentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_DesignAttachment_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignAttachment(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignAttachment_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignAttachmentEntity GetDesignAttachmentDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_DesignAttachment_Detail", param, DBConnEnm.TRDBWrite);
            return (DesignAttachmentEntity)ORMapping.MapSingleObject(typeof(DesignAttachmentEntity),dt);
        }
    }
}