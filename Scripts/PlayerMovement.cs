using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed;

    Vector3 velocity;
    public float gravity = -9.8f;
    public float jump = 3; 

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

    float originalHeight;
    public float reducedHeight;d
    public Transform player;
    

    void Start()
    {
        originalHeight = controller.height;
        
    }
    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded) 
        {
            velocity.y = Mathf.Sqrt(jump * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

       // if(Input.GetKeyDown(KeyCode.LeftShift))
       // {
       //     Crouch();
      //  }
      //  if (Input.GetKeyUp(KeyCode.LeftShift))
      //  {
      //      GetUp();
     //   }

       // if(Input.GetKeyDown(KeyCode.RightShift))
      //  {
      //      player.transform.Translate(0, 50, 0);
      //  }

    }

   // void Crouch()
   // {
   //     controller.height = reducedHeight;
    //    player.transform.Translate(0, -1, 0); 
   // }
   // void GetUp()
   // {
    //    controller.height = originalHeight;
    //    player.transform.Translate(0, 2, 0);
    
}
