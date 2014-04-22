using UnityEngine;
using System.Collections;

public class _Public : MonoBehaviour
{

    public static Vector3 helfScreen;

    Vector3 initScreen = new Vector3(480, 320, 1);

    public static Vector3 ratioScreen;



    // Use this for initialization

    void Awake()
    {

        getScreen();

    }

    public void getScreen()
    {



        if (helfScreen == Vector3.zero)
        {

            helfScreen.x = (float)(Screen.width / 2);

            helfScreen.y = (float)(Screen.height / 2);

            helfScreen.z = 1f;

        }

        if (ratioScreen == Vector3.zero)
        {
            float x = helfScreen.x / initScreen.x;

            float y = helfScreen.y / initScreen.y;

            ratioScreen.x = float.Parse(x.ToString("F2"));

            ratioScreen.y = float.Parse(y.ToString("F2"));

            ratioScreen.z = 1f;
        }
    }
}
 
