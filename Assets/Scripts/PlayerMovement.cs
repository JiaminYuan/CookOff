using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 3.0f;
    private float gravityValue = -9.81f;
    private Vector2 turn;

    public Animator ac;
    public GameObject tray;
    private float walkSpeed = 5;
    private float runSpeed = 8; 
    private float charSpeed; 
    private float movementSpeed;


    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        ac = GetComponent<Animator>();
    }

    void Update()
    {
        UpdateAnimator();

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        turn.x = Input.GetAxis("Mouse X");
        turn.y = Input.GetAxis("Mouse Y");
        Vector3 movement = ((v *transform.forward *playerSpeed + h * transform.right * playerSpeed)); 
        movementSpeed = movement.magnitude;
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(movement * Time.deltaTime * playerSpeed);
        transform.Rotate(0, turn.x, 0, Space.Self);


        // Changes the height position of the player..
       
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    void UpdateAnimator()
    {
        float speed = GetMovementSpeed();
        groundedPlayer = controller.isGrounded;

        if (movementSpeed == 0)
        {
            ac.SetFloat("Character Speed", 0);
        }
        else if (speed == walkSpeed)
        {
            ac.SetFloat("Character Speed", 0.5f);
        }
        else if (speed == runSpeed)
        {
            ac.SetFloat("Character Speed", 1);
        }
    }

    float GetMovementSpeed()
    {
        if (Input.GetButton("Fire3")) // Left shift
        {
            return runSpeed;
        }
        else
        {
            return walkSpeed;
        }
    }

}

