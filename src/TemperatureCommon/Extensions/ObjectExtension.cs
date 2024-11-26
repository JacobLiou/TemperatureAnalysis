﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolSimulationTest.Common.Extensions;

public static class ObjectExtension
{
    public static IList<string> GetAllPropertyValues<T>(this T t)
    {
        var valueList = new List<string>();
        var properties = t.GetType().GetProperties();
        foreach (var property in properties)
        {
            valueList.Add(property.GetValue(t)?.ToString()!);
        }

        return valueList;
    }

    public static string ClassToString<T>(this T data) where T : class
    {
        var propertys = data.GetType().GetProperties();
        var str = string.Empty;
        foreach (var item in propertys)
        {
            str += $"{item.Name}:{item.GetValue(data)},";
        }
        return str.TrimEnd(',');
    }

    public static byte[] ObjectToByteArray(this object obj)
    {
        BinaryFormatter bf = new BinaryFormatter();
        using (var ms = new MemoryStream())
        {
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
    }

    public static object ByteArrayToObject(this byte[] arrBytes)
    {
        using (var memStream = new MemoryStream())
        {
            var binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            var obj = binForm.Deserialize(memStream);
            return obj;
        }
    }

    public static T ByteArrayToObject<T>(this byte[] data)
    {
        if (data == null) return default!;
        using (MemoryStream ms = new MemoryStream(data))
        {
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(ms);
            return (T)obj;
        }
    }

    /// <summary>
    /// 获取以0点0分0秒开始的日期
    /// </summary>
    /// <param name="d"></param>
    /// <returns></returns>
    public static DateTime GetStartDateTime(DateTime d)
    {
        if (d.Hour != 0)
        {
            var year = d.Year;
            var month = d.Month;
            var day = d.Day;
            var hour = "0";
            var minute = "0";
            var second = "0";
            d = Convert.ToDateTime(string.Format("{0}-{1}-{2} {3}:{4}:{5}", year, month, day, hour, minute, second));
        }
        return d;
    }

    /// <summary>
    /// 获取以23点59分59秒结束的日期
    /// </summary>
    /// <param name="d"></param>
    /// <returns></returns>
    public static DateTime GetEndDateTime(DateTime d)
    {
        if (d.Hour != 23)
        {
            var year = d.Year;
            var month = d.Month;
            var day = d.Day;
            var hour = "23";
            var minute = "59";
            var second = "59";
            d = Convert.ToDateTime(string.Format("{0}-{1}-{2} {3}:{4}:{5}", year, month, day, hour, minute, second));
        }
        return d;
    }

    /// <summary>
    /// 判断对象是否为空，为空返回true
    /// </summary>
    /// <typeparam name="T">要验证的对象的类型</typeparam>
    /// <param name="data">要验证的对象</param>
    public static bool IsNullOrEmpty<T>(T data)
    {
        //如果为null
        if (data == null)
        {
            return true;
        }

        //如果为""
        if (data.GetType() == typeof(string))
        {
            if (string.IsNullOrEmpty(data.ToString().Trim()))
            {
                return true;
            }
        }

        //如果为DBNull
        if (data.GetType() == typeof(DBNull))
        {
            return true;
        }

        //不为空
        return false;
    }
}