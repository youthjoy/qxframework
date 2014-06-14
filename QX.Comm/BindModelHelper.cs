using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Web.Mvc;

namespace QX.Comm
{
    public class BindModelHelper
    {
        /// <summary>
        /// 把指定控件值集合绑定到对应实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="controls"></param>
        /// <returns></returns>
        public T BindFormToModel<T>(T obj,FormCollection formCollection)
        {
            try
            {
            }
            catch (System.Exception e)
            {
            	
            }
            if (obj != null)
            {
                PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(T));
                foreach (string key in formCollection.AllKeys)
                {
                    //Modify By QB 加上try catch
                    try
                    {
                        if (!string.IsNullOrEmpty(formCollection[key]) && p[key] != null)
                        {

                            if (p[key].PropertyType == typeof(DateTime))
                            {

                                p[key].SetValue(obj, DateTime.Parse(formCollection[key]));
                            }
                            else if (p[key].PropertyType == typeof(int))
                            {
                                p[key].SetValue(obj, int.Parse(formCollection[key]));
                            }
                            else if (p[key].PropertyType == typeof(decimal))
                            {
                                p[key].SetValue(obj, decimal.Parse(formCollection[key]));
                            }
                            else
                            {
                                p[key].SetValue(obj, formCollection[key]);
                            }

                        }
                        else if (p[key] != null)
                        {
                            //即使数据为空也改变当前控件值 Modify BY QB 2011-3-16
                            p[key].SetValue(obj, formCollection[key]);
                        }
                    }
                    catch (System.Exception)
                    {
                        continue;
                    }                   
                    
                }
            }
            return obj;
        }
    }
}
