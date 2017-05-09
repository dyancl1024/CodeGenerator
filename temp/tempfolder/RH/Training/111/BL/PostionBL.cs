using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Postion ( RH_Postion ) BL类
    ///</summary>
    public class PostionBL
    {

        /// <summary>
        /// 添加RH_Postion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddPostion(PostionEntity info)
        {
            return PostionDB.AddPostion(info);
        }


        /// <summary>
        /// 修改RH_Postion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyPostion(PostionEntity info)
        {
            return PostionDB.ModifyPostion(info);
        }


        /// <summary>
        /// 删除RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemovePostion(int ID)
        {
            return PostionDB.RemovePostion(ID);
        }

        /// <summary>
        /// 查看RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static PostionEntity GetPostionDetail(int ID)
        {
            return PostionDB.GetPostionDetail(ID);
        }
    }
}