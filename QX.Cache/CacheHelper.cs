using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Caching;
using System.Collections;

namespace QX.Cache
{

    /// <summary>
    /// 使用缓存类型
    /// </summary>
    public enum CacheType
    {
        /// <summary>
        /// .Net自带缓存体系
        /// </summary>
        ASPNET,
        /// <summary>
        /// MEMCACHE分布式缓存体系
        /// </summary>
        MEMCACHE
    }

    public enum CacheKeyEnum
    { 
        HtmlHelper,
        Permission,
        FormHtmlHelper,
        DictKey,
    }

    /// <summary>
    /// 缓存Helper类
    /// </summary>
    public static class CacheHelper
    {
        private static System.Web.Caching.Cache _cache;

        public static double SaveTime
        {
            get;
            set;
        }

        static CacheHelper()
        {
            _cache = System.Web.HttpRuntime.Cache;
            SaveTime = 15.0;
        }

        public static object Get(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }

            return _cache.Get(key);
        }

        public static T Get<T>(string key)
        {
            object obj = Get(key);
            return obj == null ? default(T) : (T)obj;
        }

        public static bool IsExsit(string key)
        {
            bool flag = false;
            if (Get(key) != null)
            {
                flag = true;
            }
            return flag;
        }

        public static void Insert(string key, object value, CacheDependency dependency, CacheItemPriority priority, CacheItemRemovedCallback callback)
        {
            if (IsExsit(key))
            {
                _cache[key] = value;
            }
            else
            {
                _cache.Insert(key, value, dependency, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(SaveTime), priority, callback);
            }

        }

        public static void Insert(string key, object value, CacheDependency dependency, CacheItemRemovedCallback callback)
        {
            Insert(key, value, dependency, CacheItemPriority.Default, callback);
        }

        public static void Insert(string key, object value, CacheDependency dependency)
        {
            Insert(key, value, dependency, CacheItemPriority.Default, null);
        }

        public static void Insert(string key, object value)
        {
            Insert(key, value, null, CacheItemPriority.Default, null);
        }

        public static void Remove(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return;
            }

            _cache.Remove(key);
        }

        public static IList<string> GetKeys()
        {
            List<string> keys = new List<string>();
            IDictionaryEnumerator enumerator = _cache.GetEnumerator();
            while (enumerator.MoveNext())
            {
                keys.Add(enumerator.Key.ToString());
            }

            return keys.AsReadOnly();
        }

        public static void RemoveAll()
        {
            IList<string> keys = GetKeys();
            foreach (string key in keys)
            {
                _cache.Remove(key);
            }
        }


        public static string MakeKey(string prefix,string type)
        {
            string key = string.Empty;
            switch (type)
            {
                case "HtmlHelper":
                    key = prefix + "_Htmlhelper";
                    break;
            }

            return key;
        }
    }


    /// <summary>
    /// .Net自身Cache
    /// </summary>
    //public static class AspNetCache
    //{

    //    /// <summary>
    //    /// 获取Cache对象
    //    /// </summary>
    //    private static System.Web.Caching.Cache cache =
    //        System.Web.HttpContext.Current.Cache;

    //    /// <summary>
    //    /// 缓存默认分钟数
    //    /// </summary>
    //    private static int Duration = 10;

    //    /// <summary>
    //    /// 检查缓存是否存在
    //    /// </summary>
    //    /// <param name="key">缓存主键:全局唯一,不重复</param>
    //    /// <returns>true/false</returns>
    //    public static bool IsExsit(string key)
    //    {
    //        bool flag = false;
    //        if (Get(key) != null)
    //        {
    //            flag = true;
    //        }
    //        return flag;
    //    }

    //    /// <summary>
    //    /// 通过Key获取缓存
    //    /// </summary>
    //    /// <param name="key">缓存主键:全局唯一,不重复</param>
    //    public static object Get(string key)
    //    {
    //        var obj = cache[key];
    //        return obj;
    //    }

    //    public static T GetEntity<T>(string key)
    //    {
    //        object obj = Get(key);
    //        return obj == null ? default(T) : (T)obj;
    //    }

    //    /// <summary>
    //    /// 将值存入Cache
    //    /// </summary>
    //    /// <param name="key">缓存主键:全局唯一,不重复</param>
    //    /// <param name="obj">缓存对象</param>
    //    public static void Set(string key, object obj)
    //    {
    //        Set(key, obj, Duration);
    //    }

    //    /// <summary>
    //    /// 设置缓存
    //    /// </summary>
    //    /// <param name="key">缓存主键:全局唯一,不重复</param>
    //    /// <param name="obj">缓存对象</param>
    //    /// <param name="Duration">缓存时间(分)</param>
    //    public static void Set(string key, object obj, int Duration)
    //    {
    //        if (IsExsit(key))
    //        {
    //            cache[key] = obj;
    //        }
    //        else
    //        {
    //            TimeSpan cacheDuration = TimeSpan.FromMinutes(Duration);
    //            cache.Insert(key, obj, null, DateTime.UtcNow.AddSeconds(Duration), cacheDuration);
    //        }
    //    }

    //    /// <summary>
    //    /// 移除Cache中指定键
    //    /// </summary>
    //    /// <param name="key">缓存主键:全局唯一,不重复</param>
    //    public static void Remove(string key)
    //    {
    //        if (IsExsit(key))
    //        {
    //            cache.Remove(key);
    //        }
    //    }

    //}
}



