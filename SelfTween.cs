using UnityEngine;
using System.Collections;

public  class SelfTween : MonoBehaviour 
{

    TweenAlpha    TA;
    TweenPosition TP;
    float a;
    float b;
    float c;
    float d;
    float e;

    void Start()
    {
        TA = gameObject.GetComponent<TweenAlpha>();
        TP=gameObject.GetComponent<TweenPosition>();
        TP.from = transform.localPosition;
        a = 1 - 0.25f;
        b = transform.localPosition.y +110;
    }
    public  void TransTween( )
    {
        TP.from = transform.localPosition;
        TA.from = 1;
        TA.to = a;
        TP.from = transform.localPosition;
        TP.to = new Vector3(TP.from.x, b , TP.from.z);
        TP.ResetToBeginning();
        TA.ResetToBeginning();
        TA.Play(true);
        TP.Play(true);
    }
    public void TransTweenTwo()
    {
        TA.from = a;
        TP.from.y = b;
        a = a - 0.25f;
        b =b+ 110;
        TA.to = a ;
        TP.to = new Vector3(TP.from.x, b, TP.from.z);
        TP.ResetToBeginning();
        TA.ResetToBeginning();
        TA.Play(true);
        TP.Play(true);
        if (gameObject.transform.localPosition.y >200)
        {
            Destroy(gameObject);
        }
    }
}
