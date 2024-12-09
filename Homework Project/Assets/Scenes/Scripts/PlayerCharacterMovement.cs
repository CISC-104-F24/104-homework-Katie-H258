using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerCharacterMovement : MonoBehaviour
{
    private float baseSpeed = 10.0f;

    public float jumpPower = 5f;

    public float sprintSpeed = 20.0f;

    private float currentSpeed;

    public float rotationSpeed = 30f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Proceed with steering protocol");

        currentSpeed = baseSpeed;

    }

    // Update is called once per frame
    void Update()
    {
       //horizontal movement
        float moveStep = currentSpeed * Time.deltaTime;

        bool is_up_pressed = Input.GetKey(KeyCode.UpArrow);
        if (is_up_pressed) 
        {
            transform.position = transform.position + Vector3.forward * moveStep;
        }

        bool is_right_pressed = Input.GetKey(KeyCode.RightArrow);
        if (is_right_pressed)
        {
            transform.position = transform.position + Vector3.right * moveStep;
        }

        bool is_left_pressed = Input.GetKey(KeyCode.LeftArrow);
        if (is_left_pressed)
        {
            transform.position = transform.position + Vector3.left * moveStep;
        }

        bool is_down_pressed = Input.GetKey(KeyCode.DownArrow);
        if (is_down_pressed)
        {
            transform.position = transform.position + Vector3.back * moveStep;
        }

        bool is_shift_pressed = Input.GetKey(KeyCode.LeftShift);
        if (is_shift_pressed)
        {
            currentSpeed = sprintSpeed;
        } 
        else 
        {
            currentSpeed = baseSpeed;
        }

        bool is_rotate_right_pressed = Input.GetKey(KeyCode.D);
        if (is_rotate_right_pressed) 
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        bool is_rotate_left_pressed = Input.GetKey(KeyCode.A);
       if (is_rotate_left_pressed)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * -1);
        }

        //vertical movement
        bool is_jump_pressed = Input.GetKeyDown(KeyCode.Space);
        if (is_jump_pressed)
        {
            Rigidbody myRigidbody = GetComponent<Rigidbody>();
            myRigidbody.AddForce(new Vector3(0, 5, 0) * jumpPower, ForceMode.Impulse);
        }

        //Makes a more gradual height change instead of just a short jump, for floating over a distance instead of a pulse
        bool is_hover_pressed = Input.GetKey(KeyCode.W);
        if (is_hover_pressed) 
        {
            Rigidbody myRigidbody = GetComponent<Rigidbody>();
            myRigidbody.AddForce(new Vector3(0, 4, 0), ForceMode.Force);
        }

    }
}
