using UnityEngine;
using System.Collections;

public class WinTrans : MonoBehaviour
{
    public GameObject WindowTween;
    public TweenPosition OBJSET;
    public string XSet = "-30";
    public string YSet = "0";
    public string XStart = "0";
    public string YStart = "0";
    public string XEnd = "-200";
    public string YEnd = "0";
    public string EndTime = "1";
    void OnGUI()
    {
        //GUI.Label(new Rect(0, 5, 40, 20), "X位置");
        //XSet = GUI.TextArea(new Rect(30, 5, 60, 20), XSet);
        //GUI.Label(new Rect(0, 30, 40, 20), "Y位置");
        //YSet = GUI.TextArea(new Rect(30, 30, 60, 20), YSet);
        GUI.Label(new Rect(0, 200, 160, 80), "X的最大值为115，Y的最大值为115，X最小值-110，,Y最小值为-110");
        GUI.Label(new Rect(80, 5, 40, 40), "X开始位置");
        XStart = GUI.TextArea(new Rect(130, 5, 60, 20), XStart);
        GUI.Label(new Rect(80, 30, 40, 40), "Y开始位置");
        YStart = GUI.TextArea(new Rect(130, 30, 60, 20), YStart);

        GUI.Label(new Rect(180, 5, 80, 20), "X结束位置");
        XEnd = GUI.TextArea(new Rect(210, 5, 60, 20), XEnd);
        GUI.Label(new Rect(180, 30, 80, 20), "Y结束位置");
        YEnd = GUI.TextArea(new Rect(210, 30, 60, 20), YEnd);

        GUI.Label(new Rect(0, 120, 100, 20), "速度&时间");
        EndTime = GUI.TextArea(new Rect(80, 120, 40, 20), EndTime);

        if (GUI.Button(new Rect(200, 80, 40, 40), "修改"))
        {
            WindowTween.transform.localPosition = new Vector3(float.Parse(XSet), float.Parse(YSet), 0);
            OBJSET.from.x = float.Parse(XStart);
            OBJSET.from.y = float.Parse(YStart);
            OBJSET.to.x = float.Parse(XEnd);
            OBJSET.to.y = float.Parse(YEnd);
            OBJSET.duration = float.Parse(EndTime);
            
        }
        if (GUI.Button(new Rect(0, 120, 80, 40), "返回菜单"))
        {
            Application.LoadLevel(0);
        }

    }
}
