using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDirector : MonoBehaviour
{
    GameObject Time;

    // Start is called before the first frame update
    void Start()
    {
        this.Time = GameObject.Find("Time");
    }
    public void DecreaseTime()
    {
        this.Time.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
