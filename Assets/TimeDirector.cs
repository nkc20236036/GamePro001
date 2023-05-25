using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDirector : MonoBehaviour
{
    GameObject Time_gauge;

    // Start is called before the first frame update
    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
    }
    public void DecreaseTime()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
