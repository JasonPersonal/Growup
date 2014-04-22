using UnityEngine;
using System.Collections;

public class ChatManager : MonoBehaviour
{
    #region 聊天设置
    //public  GameObject PrafebSelf;
    //public  GameObject PrafebOther;
    //private GameObject ChatWindow;
    //public UIInput MyInput;

    //public Transform PosSelf;
    //public Transform PosOther;

    //private  UILabel Self;
    //private  UILabel Other;

    //private static string selfSay="aaaa";

    //private void Start()
    //{
    //    InitPra(1);
    //}
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Return))
    //    {
    //        Self = ChatWindow.GetComponentInChildren<UILabel>();

    //        if (MyInput != null)
    //            Self.text = MyInput.value;
    //        MyInput.value = null;
    //    }
    //}
    //public GameObject InitPra(int Type)
    //{
    //    if (Type == 0)
    //    {
    //        ChatWindow = (GameObject)Instantiate(PrafebSelf);
    //        ChatWindow.transform.parent = PosSelf;
    //        ChatWindow.transform.localScale = new Vector3(1, 1, 1);
    //        ChatWindow.transform.localPosition = new Vector3(1, 1, 1);
    //    }
    //    else if (Type == 1)
    //    {
    //        ChatWindow = (GameObject)Instantiate(PrafebOther);
    //        ChatWindow.transform.parent = PosOther;
    //        ChatWindow.transform.localScale = new Vector3(1, 1, 1);
    //        ChatWindow.transform.localPosition = new Vector3(1, 1, 1);
    //        Other = ChatWindow.GetComponentInChildren<UILabel>();
    //        if(MyInput!=null)
    //        Other.text = MyInput.value;
    //    }
    //    return ChatWindow;
    //}
    #endregion
   //public string stringToEdit = "1";
   //void OnGUI()
   //{
   //    GUI.Label(new Rect(10,10,40,20),"参数");
   //    stringToEdit=GUI.TextArea(new Rect(50, 10, 40, 20), stringToEdit, 200);
   //}
   //public string stringToEdit = "Hello World";
   //void OnGUI()
   //{
   //    stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
   //}
    public string XSet = "120";
    public string YSet = "-170";
    public string LabelXset = "0";
    public string LabelYset = "0";
    public string XScalStart = "0";
    public string YScalStart = "0";
    public string XScalEnd = "1";
    public string YScalEnd = "1";
    public string EndTime = "1";


}
