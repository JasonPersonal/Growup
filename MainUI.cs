using UnityEngine;
using System.Collections;

public class MainUI : MonoBehaviour 
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 10, 80, 40), "移动动画"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(0, 50, 80, 40), "大小动画"))
        {
            Application.LoadLevel(2);
        }
        if (GUI.Button(new Rect(90, 10, 80, 40), "对话动画"))
        {
            Application.LoadLevel(3);
        }
        if (GUI.Button(new Rect(90, 50, 80, 40), "属性界面"))
        {
            Application.LoadLevel(4);
        }
        if (GUI.Button(new Rect(190, 10,80,50), "退出"))
        {
            Application.Quit();
        }
    }
}
