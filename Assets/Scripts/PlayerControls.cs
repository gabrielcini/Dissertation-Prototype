using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
  public CharacterController controller;

  public float speed = 5f;
  public float gravity = -9.81f;
  public float jumpAmount = 3f;

  public Transform groundCheck;
  public float groundDistance = 0.4f;
  public LayerMask groundMask;

  Vector3 velocity;
  bool isTouchingGround;

  // Update is called once per frame
  void Update()
  {
      isTouchingGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

      if(isTouchingGround && velocity.y < 0)
      {
          velocity.y = -2f;
      }

      float x = Input.GetAxis("Horizontal");
      float z = Input.GetAxis("Vertical");

      Vector3 move = transform.right * x + transform.forward * z;

      controller.Move(move * speed * Time.deltaTime);

      if(Input.GetButtonDown("Jump") && isTouchingGround)
      {
          velocity.y = Mathf.Sqrt(jumpAmount * -2f * gravity);
      }

      velocity.y += gravity * Time.deltaTime;

      controller.Move(velocity * Time.deltaTime);
  }

}
