﻿using System.Data;
namespace Albian.Pool.DbConnectionPool
{
    /// <summary>
    /// 对象池接口
    /// </summary>
    public interface IConnectionPool<T>
        where T :IDbConnection
    {
        /// <summary>
        /// 得到对象.
        /// </summary>

        /// <returns></returns>
        T GetObject(string connectionString);

        /// <summary>
        /// 将使用完毕的对象返回到对象池.
        /// </summary>
        void ReturnObject(T target);

        /// <summary>
        /// 关闭对象池并释放池中所有的资源
        /// </summary>
        void Close();

        /// <summary>
        /// 得到当前对象池中正在使用的对象数. 
        /// </summary>
        int NumActive { get; }

        /// <summary>
        /// 得到当前对象池中可用的对象数
        /// </summary>
        int NumIdle { get; }

        /// <summary>
        /// 强行创建一个对象
        /// </summary>
        /// <returns></returns>
        T RescueObject(string connectionString);
    }
}