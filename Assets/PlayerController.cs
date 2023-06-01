using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    Rigidbody2D  rigid2D;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float speed = 0.05f;
        transform.position += new Vector3(x * speed, y * speed, 0);

        if (y == 0)
        {
            anim.Play("Player");
        }
        else if (y == -1)
        {
            anim.Play("PlayerR");
        }
        else
        {
            anim.Play("PlayerL2");
        }
        if (x == 0)
        {
            anim.Play("Player");
        }
        else if(x == 1)
        {
            anim.Play("PlayerR");
        }
        else
        {
            anim.Play("PlayerL2");
        }
    }
}
