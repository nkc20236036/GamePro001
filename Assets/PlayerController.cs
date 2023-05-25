using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    Rigidbody2D  rigid2D;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.03f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.03f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.03f,0,0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.03f, 0, 0);
        }
    }
}
