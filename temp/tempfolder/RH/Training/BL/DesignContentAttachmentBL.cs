using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_DesignContentAttachment ( RH_DesignContentAttachment ) BL类
    ///</summary>
    public class DesignContentAttachmentBL
    {

        /// <summary>
        /// 添加RH_DesignContentAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignContentAttachment(DesignContentAttachmentEntity info)
        {
            return DesignContentAttachmentDB.AddDesignContentAttachment(info);
        }


        /// <summary>
        /// 修改RH_DesignContentAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignContentAttachment(DesignContentAttachmentEntity info)
        {
            return DesignContentAttachmentDB.ModifyDesignContentAttachment(info);
        }


        /// <summary>
        /// 删除RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignContentAttachment(int ID)
        {
            return DesignContentAttachmentDB.RemoveDesignContentAttachment(ID);
        }

        /// <summary>
        /// 查看RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentAttachmentEntity GetDesignContentAttachmentDetail(int ID)
        {
            return DesignContentAttachmentDB.GetDesignContentAttachmentDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentAttachmentEntityListResult GetDesignContentAttachmentEntityList(DesignContentAttachmentSearcher Searcher)
        {
            return DesignContentAttachmentDB.GetDesignContentAttachmentEntityList(Searcher);
        }
    }
}