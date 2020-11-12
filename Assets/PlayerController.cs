using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rigi;
    public float move_speed = 10f;
    void Start()
    {
        anim = this.GetComponent<Animator>();
        rigi = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            gameObject.transform.Translate(new Vector3(-Time.deltaTime * move_speed, 0, 0));
            anim.SetInteger("condition", 1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            gameObject.transform.Translate(new Vector3(Time.deltaTime * move_speed, 0, 0));
            anim.SetInteger("condition", 1);
        }


    }
}
