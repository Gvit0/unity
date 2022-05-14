using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float Speed = 10;
    public float movet;
    private float moveImputV, moveImputH, jumpForce, rotV, rotH;
    private bool IsGround;
    void Start() {
    }
    void OnCollisionStay(Collision other) {
        if(other.gameObject.tag == "ground"){
            IsGround = true;
        }
    }
    void OnCollisionExit(Collision other) {
        if(other.gameObject.tag == "ground"){
            IsGround = false;
        }
    }
    void FixedUpdate()
    {   

        if (IsGround) {jumpForce = Input.GetAxis("Jump");}
        moveImputH = Input.GetAxis("Horizontal");
        moveImputV = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(moveImputH * Speed, jumpForce, moveImputV * Speed)); 
        rotV = Mathf.Clamp(rotV, -60, 90);

        jumpForce = 0;
    }
}
