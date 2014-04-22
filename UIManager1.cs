using UnityEngine;
using System.Collections;

public class UIManager1 : MonoBehaviour 
{
    public GameObject ButtonF;
    UIPlayTween TweenPlay;
    #region  方法2：
    //public GameObject ButtonF;
    //public GameObject ButtonB;
    //void Start()
    //{
    //    ButtonB.SetActive(false);
    //    ButtonF.SetActive(true);
    //    UIEventListener.Get(ButtonF).onClick = TweenPosF;
    //}
    //void TweenPosF(GameObject Button)
    //{
    //    ButtonB.SetActive(true);
    //    ButtonF.SetActive(false);
    //    UIEventListener.Get(ButtonB).onClick = TweenPosB;
    //}
    //void TweenPosB(GameObject Button)
    //{
    //    ButtonB.SetActive(false);
    //    ButtonF.SetActive(true);
    //    UIEventListener.Get(ButtonF).onClick = TweenPosF;
    //}
    #endregion
    void Start()
    {
       TweenPlay= ButtonF.GetComponent<UIPlayTween>();
       TweenPlay.playDirection = AnimationOrTween.Direction.Forward;
        UIEventListener.Get(ButtonF).onClick = TweenF;
    }
    void TweenF(GameObject Button)
    {
        TweenPlay.playDirection = AnimationOrTween.Direction.Reverse;
        UIEventListener.Get(ButtonF).onClick = TweenR;
    }
    void TweenR(GameObject Button)
    {
        TweenPlay.playDirection = AnimationOrTween.Direction.Forward;
        UIEventListener.Get(ButtonF).onClick = TweenF;
    }
}
