using System.Collections;
using System.Collections.Generic;
using static Enums;
using UnityEngine;

public class Walking : MonoBehaviour
{
    private FiniteStateMachine fsm;
    private Animator animator;

    public float walkSpeed = 3.0f;
    public float rotationSpeed = 400.0f;

    void Start()
    {
        fsm = GetComponent<FiniteStateMachine>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        PlayerState currentState = fsm.GetCurrentState();

        switch (currentState)
        {
            case PlayerState.Idle:

                animator.SetBool("IsWalking", false);
                break;

            case PlayerState.Walking:

                HandleWalking();
                break;


        }
    }

    void HandleWalking()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;

        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(new Vector3(movement.x, 0f, movement.z), Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
            fsm.ChangeState(PlayerState.Idle);
        }

        transform.Translate(movement * walkSpeed * Time.deltaTime, Space.World);
    }

}

