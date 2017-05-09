using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_DesignAttachment ( RH_DesignAttachment ) BL类
    ///</summary>
    public class DesignAttachmentBL
    {

        /// <summary>
        /// 添加RH_DesignAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignAttachment(DesignAttachmentEntity info)
        {
            return DesignAttachmentDB.AddDesignAttachment(info);
        }


        /// <summary>
        /// 修改RH_DesignAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignAttachment(DesignAttachmentEntity info)
        {
            return DesignAttachmentDB.ModifyDesignAttachment(info);
        }


        /// <summary>
        /// 删除RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignAttachment(int ID)
        {
            return DesignAttachmentDB.RemoveDesignAttachment(ID);
        }

        /// <summary>
        /// 查看RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignAttachmentEntity GetDesignAttachmentDetail(int ID)
        {
            return DesignAttachmentDB.GetDesignAttachmentDetail(ID);
        }
    }
}