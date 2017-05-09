using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Temp_BasicData_Class ( RH_Temp_BasicData_Class ) BL类
    ///</summary>
    public class Temp_BasicData_ClassBL
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTemp_BasicData_Class(Temp_BasicData_ClassEntity info)
        {
            return Temp_BasicData_ClassDB.AddTemp_BasicData_Class(info);
        }


        /// <summary>
        /// 修改RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTemp_BasicData_Class(Temp_BasicData_ClassEntity info)
        {
            return Temp_BasicData_ClassDB.ModifyTemp_BasicData_Class(info);
        }


        /// <summary>
        /// 删除RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTemp_BasicData_Class(int ID)
        {
            return Temp_BasicData_ClassDB.RemoveTemp_BasicData_Class(ID);
        }

        /// <summary>
        /// 查看RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_ClassEntity GetTemp_BasicData_ClassDetail(int ID)
        {
            return Temp_BasicData_ClassDB.GetTemp_BasicData_ClassDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_ClassEntityListResult GetTemp_BasicData_ClassEntityList(Temp_BasicData_ClassSearcher Searcher)
        {
            return Temp_BasicData_ClassDB.GetTemp_BasicData_ClassEntityList(Searcher);
        }
    }
}