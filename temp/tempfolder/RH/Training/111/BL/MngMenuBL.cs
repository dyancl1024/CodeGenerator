using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_MngMenu ( RH_MngMenu ) BL类
    ///</summary>
    public class MngMenuBL
    {

        /// <summary>
        /// 添加RH_MngMenu
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngMenu(MngMenuEntity info)
        {
            return MngMenuDB.AddMngMenu(info);
        }


        /// <summary>
        /// 修改RH_MngMenu
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngMenu(MngMenuEntity info)
        {
            return MngMenuDB.ModifyMngMenu(info);
        }


        /// <summary>
        /// 删除RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngMenu(int ID)
        {
            return MngMenuDB.RemoveMngMenu(ID);
        }

        /// <summary>
        /// 查看RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngMenuEntity GetMngMenuDetail(int ID)
        {
            return MngMenuDB.GetMngMenuDetail(ID);
        }
    }
}