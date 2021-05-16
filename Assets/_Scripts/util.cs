using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;

public class util : MonoBehaviour
{
    private string lastData;

    // vector3 -> 字符串
    public string vec2string(Vector3 vec)
    {
        //return vec.ToString();    // 直接使用tostring方法得到的精度为0.1
        return "(" + vec.x.ToString("0.00") + ", " + vec.y.ToString("0.00") + ", " + vec.z.ToString("0.00") + ")";  // 精度为0.01
    }  

    // 字符串 -> vector3
    public Vector3 string2vec(string str)
    {
        string[] strs = str.Split(',');
        float x = float.Parse(strs[0]);
        float y = float.Parse(strs[1]);
        float z = float.Parse(strs[2]);
        return new Vector3(x, y, z);
    }

    // 获取现在时间
    public string getTime()
    {
        string Time = DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day + " " + string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond) + " ";
        return Time;
    }

    // Usage: Writefile (Application.dataPath, "FileName", "TestInfo0");
    public void Writefile(string path, string name, string info)
    {
        StreamWriter sw;//流信息
        FileInfo t = new FileInfo(path + "//" + name);
        if (!t.Exists)
        {//判断文件是否存在
            sw = t.CreateText();//不存在，创建
        }
        else
        {
            sw = t.AppendText();//存在，则打开
        }
        // 如果和上一条记录相同，则不写入文件
        if (info != lastData)
        {
            sw.WriteLine(info);//以行的形式写入信息
        }
        lastData = info;
        sw.Close();//关闭流
        sw.Dispose();//销毁流
    }
}