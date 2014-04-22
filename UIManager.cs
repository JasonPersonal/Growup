using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour 
{
    public GameObject PraProup;
    public GameObject ButtonRT;
	void Start() 
    {
        PraProup.active = false;
        UIEventListener.Get(ButtonRT).onClick = InitPra;
    }
    public   void InitPra(GameObject button)
    {
        PraProup.SetActive(true);
        UIEventListener.Get(ButtonRT).onClick =Reset;
    }
    void Reset(GameObject button)
    {
        PraProup.GetComponent<TweenScale>().ResetToBeginning();
        PraProup.GetComponent<TweenScale>().Play(true);
        UIEventListener.Get(ButtonRT).onClick = InitPra;
    }

}
