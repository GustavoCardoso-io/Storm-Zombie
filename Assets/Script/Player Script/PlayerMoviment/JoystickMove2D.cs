using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMove2D : MonoBehaviour
{
    public float speed = 4.0f;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb;


    private void FixedUpdate()
    {
        Vector2 direction = Vector2.left * variableJoystick.Vertical + Vector2.up * variableJoystick.Horizontal;
        //Vector2 directionM = Vector2.left * Input.GetAxisRaw("Horizontal") + Vector2.up * Input.GetAxisRaw("Vertical");

        rb.AddForce(direction * speed * Time.deltaTime, ForceMode2D.Force);
        //rb.AddForce(directionM * speed * Time.deltaTime, ForceMode2D.Force);


    }


}


