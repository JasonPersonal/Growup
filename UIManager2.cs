using UnityEngine;
using System.Collections;

public class UIManager2 : MonoBehaviour 
{
    public GameObject PrafebSelf;
    public GameObject PrafebOther;


    public string InitTitle = "0";
    public string InitPos = "-120";
    public GameObject ButNext;

    GameObject[] TweenObj;

    void Start()
    {
        TweenObj = GameObject.FindGameObjectsWithTag("TweenChat");

        UIEventListener.Get(ButNext).onClick = Tween;
    }

    #region   GUI显示
    void OnGUI()
    {
        GUI.Label(new Rect(60, 10, 60, 20), "输入0或1");
        GUI.Label(new Rect(0, 10, 20, 40), "类型");
        InitTitle = GUI.TextField(new Rect(10, 10, 40, 20), InitTitle);
        GUI.Label(new Rect(0, 30, 60, 20), "生成位置");
        InitPos = GUI.TextField(new Rect(70,30,40,20),InitPos);
        if (GUI.Button(new Rect(0, 80, 80, 40), "返回菜单"))
        {
            Application.LoadLevel(0);
        }
    }
    #endregion

    #region  点击生成
    public void InitPra(float Type)
    {
        if (Type == 0)
        {
         GameObject OBJSelf = (GameObject)Instantiate(PrafebSelf);
         OBJSelf.transform.parent = GameObject.Find("UI Root/Camera/BG/Manager2/Scroll View/Grid/ChatTeam").transform;
         OBJSelf.transform.localPosition = new Vector3(-90, float.Parse(InitPos), 0);
         OBJSelf.transform.localScale = new Vector3(1, 1, 1);

        }
        if (Type == 1)
        {
            GameObject OBJOther = (GameObject)Instantiate(PrafebOther);
            OBJOther.transform.parent = GameObject.Find("UI Root/Camera/BG/Manager2/Scroll View/Grid/ChatTeam").transform;
            OBJOther.transform.localPosition = new Vector3(120, float.Parse(InitPos), 0);
            OBJOther.transform.localScale = new Vector3(1, 1, 1);
        }
    }
    void Tween(GameObject Button)
    {
        TweenObj = GameObject.FindGameObjectsWithTag("TweenChat");
        if (TweenObj != null)
        {
            for (int i = 0; i < TweenObj.Length; i++)
            {
                TweenObj[i].GetComponent<SelfTween>().TransTween();
            }
        }
        
        UIEventListener.Get(ButNext).onClick = Tween2;
        InitPra(float.Parse(InitTitle));
    }
    void Tween2(GameObject Button)
    {
        TweenObj = GameObject.FindGameObjectsWithTag("TweenChat");
        UIEventListener.Get(ButNext).onClick = Tween2;
        if (TweenObj != null)
        {
            for (int i = 0; i < TweenObj.Length; i++)
            {
                TweenObj[i].GetComponent<SelfTween>().TransTweenTwo();
            }
        }
        InitPra(float.Parse(InitTitle));
    }
#endregion



}
