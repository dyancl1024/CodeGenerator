using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseAttachment ( RH_CourseAttachment ) BL类
    ///</summary>
    public class CourseAttachmentBL
    {

        /// <summary>
        /// 添加RH_CourseAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseAttachment(CourseAttachmentEntity info)
        {
            return CourseAttachmentDB.AddCourseAttachment(info);
        }


        /// <summary>
        /// 修改RH_CourseAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseAttachment(CourseAttachmentEntity info)
        {
            return CourseAttachmentDB.ModifyCourseAttachment(info);
        }


        /// <summary>
        /// 删除RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseAttachment(int ID)
        {
            return CourseAttachmentDB.RemoveCourseAttachment(ID);
        }

        /// <summary>
        /// 查看RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseAttachmentEntity GetCourseAttachmentDetail(int ID)
        {
            return CourseAttachmentDB.GetCourseAttachmentDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseAttachmentEntityListResult GetCourseAttachmentEntityList(CourseAttachmentSearcher Searcher)
        {
            return CourseAttachmentDB.GetCourseAttachmentEntityList(Searcher);
        }
    }
}