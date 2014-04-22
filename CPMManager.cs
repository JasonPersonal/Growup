using UnityEngine;
using System.Collections;

public class CPMManager : MonoBehaviour 
{
    public GameObject SpriteTween;
    public TweenScale OBJCPMSET;
    public string XSet = "-30";
    public string YSet = "0";
    public string XScalStart ="0" ;
    public string YScalStart = "0";
    public string XScalEnd = "1";
    public string YScalEnd = "1";
    public string EndTime = "1";
    void Start()
    {
    }
    void OnGUI()
    {
        GUI.Label(new Rect(0, 200, 160, 80), "X的最大值为115，Y的最大值为115，X最小值-110，,Y最小值为-110");
        GUI.Label(new Rect(0, 5, 40, 20), "X位置");
        XSet = GUI.TextArea(new Rect(30, 5, 60, 20), XSet);
        GUI.Label(new Rect(0,30,40,20),"Y位置");
        YSet = GUI.TextArea(new Rect(30, 30, 60, 20), YSet);

        GUI.Label(new Rect(80, 5, 40, 40), "X开始大小");
        XScalStart = GUI.TextArea(new Rect(130, 5, 60, 20), XScalStart);
        GUI.Label(new Rect(80, 30, 40, 40), "Y开始大小");
        YScalStart = GUI.TextArea(new Rect(130, 30, 60, 20), YScalStart);

        GUI.Label(new Rect(180, 5, 80, 20), "X结束大小");
        XScalEnd = GUI.TextArea(new Rect(210,5,60,20),XScalEnd );
        GUI.Label(new Rect(180, 30, 80, 20), "Y结束大小");
        YScalEnd = GUI.TextArea(new Rect(210,30,60,20),YScalEnd);

        GUI.Label(new Rect(0, 80, 100, 20), "速度&时间");
        EndTime = GUI.TextArea(new Rect(80, 80, 100, 20), EndTime);

        if(GUI.Button(new Rect(200,80,40,40),"修改"))
        {
            SpriteTween.transform.localPosition = new Vector3(float.Parse(XSet),float.Parse(YSet),0);
            OBJCPMSET.from.x = float.Parse(XScalStart);
            OBJCPMSET.from.y = float.Parse(YScalStart);
            OBJCPMSET.to.x = float.Parse(XScalEnd);
            OBJCPMSET.to.y = float.Parse(YScalEnd);
            OBJCPMSET.duration = float.Parse(EndTime);
            SpriteTween.active = false;
            OBJCPMSET.active = false;
        }
        if (GUI.Button(new Rect(0, 120, 80, 40), "返回菜单"))
        {
            Application.LoadLevel(0);
        }

    }

}
