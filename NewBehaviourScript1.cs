using UnityEngine;
using System.Collections;


public class _ScreenFit : MonoBehaviour
{

    [System.Serializable]

    public class ScreenFit
    {

        public Transform fitTrans;

        public bool isFitScale = true;



        public void initFit()
        {

            //  Fit Position

            if (fitTrans == null) return;



            Vector3 position = fitTrans.localPosition;

            position.x *= _Public.ratioScreen.x;

            position.y *= _Public.ratioScreen.y;

            position.z *= _Public.ratioScreen.z;

            fitTrans.localPosition = position;



            // Fit Scale

            if (isFitScale)
            {
                
                Vector3 scale = fitTrans.localScale;

                if (scale == Vector3.one)
                {

                    scale.y *= _Public.ratioScreen.y;

                    scale.x *= _Public.ratioScreen.y;

                    scale.z *= _Public.ratioScreen.z;

                    //scale.x*=_Public.ratioScreen.x;

                }

                else
                {

                    scale.x *= _Public.ratioScreen.x;

                    scale.y *= _Public.ratioScreen.y;

                    scale.z *= _Public.ratioScreen.z;

                }

                fitTrans.localScale = scale;



            }

        }

    }

    public ScreenFit[] screenFitS;

    public Transform backTrans;



    // Use this for initialization

    void Start()
    {

        initScreenFit();

    }
    void initScreenFit()
    {

        foreach (ScreenFit screenFit in screenFitS)
        {

            screenFit.initFit();

        }
        if (backTrans == null) return;

        Vector3 scale = backTrans.localScale;

        scale.x = _Public.helfScreen.x * 2;

        scale.y = _Public.helfScreen.y * 2;

        backTrans.localScale = scale;



    }

}
