using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;

public class Pos : MonoBehaviour
{
    private util ut;
    private int count;
    public static int trial = 0;
    private string path;

    private void Start()
    {
        ut = new util();
        path = Application.dataPath + "/UserData";
        count = Directory.GetFiles(path).Length + 1;
     
    }

    // 重要！！！此处的 SteamVR_Controller.Input(i) i需和游戏实际运行时controller和tracker在steamVR_tracked_object里的index相对应
    void Update()
    { 
        string time = ut.getTime();

        // 在vec2string方法中定义精度
        string leftControllerPos = ut.vec2string(SteamVR_Controller.Input(3).transform.pos);
        string rightControllerPos = ut.vec2string(SteamVR_Controller.Input(4).transform.pos);
        string leftTrackerPos = ut.vec2string(SteamVR_Controller.Input(5).transform.pos);
        string rightTrackerPos = ut.vec2string(SteamVR_Controller.Input(6).transform.pos);
        string headset = ut.vec2string(SteamVR_Controller.Input(0).transform.pos);
        string leftControllerVel = ut.vec2string(SteamVR_Controller.Input(3).velocity);
        string rightControllerVel = ut.vec2string(SteamVR_Controller.Input(4).velocity);
        string leftTrackerVel = ut.vec2string(SteamVR_Controller.Input(5).velocity);
        string rightTrackerVel = ut.vec2string(SteamVR_Controller.Input(6).velocity);

        string write = time + "  leftController:" + leftControllerPos + "  rightController:" + rightControllerPos + "  leftTracker:" + leftTrackerPos + "  rightTracker:" + rightTrackerPos + "  headset:" + headset + 
            "  leftControllerVel:" + leftControllerVel + "  rightControllerVel:" + rightControllerVel  + "  leftTrackerVel:" + leftTrackerVel + "  rightTrackerVel:" + rightTrackerVel;
        ut.Writefile(path, count.ToString()+'-'+trial.ToString() + ".txt", write);
    } 
}
