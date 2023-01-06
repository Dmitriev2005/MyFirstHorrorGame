using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed = 30f;
    public float gravity = 2f;


    CharacterController controller;
    Vector3 direction;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {

        Move();


    }
    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = 0f;

        if (!controller.isGrounded)
            y -= gravity;


        direction = new Vector3(x * speed, y, z * speed);
        direction = transform.TransformDirection(direction);

        controller.Move(direction * Time.deltaTime);
    }

}
