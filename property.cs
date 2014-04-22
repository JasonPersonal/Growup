using UnityEngine;
using System.Collections;

public class property : MonoBehaviour 
{
    public Transform ForLeft;
    public Transform ForRight;
    public Transform ForUp;
    public Transform Up;
    public Transform Center;
    public string  LeftProperty="40";
    public string  RightProperty="20";
    public string UpProperty="30";

    private float UpDis;
    private float sqrt3;

	void Start () 
    {
        sqrt3 =1.73f/2.0f;
        Set();

    }
    void OnGUI()
    {
        GUI.Label(new Rect(0, 10, 20, 20), "左边数值");
        LeftProperty=  GUI.TextField(new Rect(20, 10, 40, 20), LeftProperty);
        GUI.Label(new Rect(70, 10, 20, 20), "右边数值");
        RightProperty = GUI.TextField(new Rect(100, 10, 40, 20), RightProperty);
        GUI.Label(new Rect(150, 10, 40, 40), "上边数值");
        UpProperty= GUI.TextField(new Rect(190, 10, 40, 20), UpProperty);
        
        if (GUI.Button(new Rect(230, 10, 40, 20), "修改"))
        {
            Set();
            Trigon.aa.SetProperty();
        }
        if (GUI.Button(new Rect(0, 80, 80, 40), "返回菜单"))
        {
            Application.LoadLevel(0);
        }
        GUI.Label(new Rect(0, 500, 80, 80), ""+ForLeft.localPosition);
    }
    void Set()
    {
        if (float.Parse(LeftProperty) <= 0)
        {
            LeftProperty = "0";
        }
        if (float.Parse(LeftProperty) >= 100)
        {
            LeftProperty = "100";
        }
        if (float.Parse(RightProperty) <= 0)
        {
            RightProperty = "0";
        }
        if (float.Parse(RightProperty) >= 100)
        {
            RightProperty = "100";
        }
        if (float.Parse(UpProperty) <= 0)
        {
            UpProperty = "0";
        }
        if (float.Parse(UpProperty) >= 100)
        {
            UpProperty = "100";
        }
        Vector3 CenterLPos = Center.localPosition;
        UpDis = Vector3.Distance(Center.localPosition, Up.localPosition);
        ForLeft.localPosition = new Vector3(CenterLPos.x - sqrt3 * (UpDis * float.Parse(LeftProperty) / 100), CenterLPos.y - (UpDis / 2 * float.Parse(LeftProperty) / 100), 0);
        ForRight.localPosition = new Vector3(CenterLPos.x + sqrt3 *(UpDis* float.Parse(RightProperty) / 100), CenterLPos.y - (UpDis / 2 * float.Parse(RightProperty) / 100), 0);
        ForUp.localPosition = new Vector3(0, CenterLPos.y + (UpDis * float.Parse(UpProperty) / 100), 0);
    }
}
