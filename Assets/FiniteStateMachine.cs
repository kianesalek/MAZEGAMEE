using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

public class FiniteStateMachine : MonoBehaviour
{
    private PlayerState currentState;
    private Animator animator;

    void Start()
    {
  
    }

    void Update()
    {
        switch (currentState)
        {
            case PlayerState.Idle:
                HandleIdleState();
                break;
            case PlayerState.Walking:
                HandleWalkingState();
                break;
            case PlayerState.Attacking:
                HandleAttackingState();
                break;
            case PlayerState.Jumping:
                HandleJumpingState();
                break;
        }

        CheckTransitions();
    }

    void HandleIdleState()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            ChangeState(PlayerState.Walking);
            animator.SetBool("IsWalking", true);
        }
    }

    void HandleWalkingState()
    {
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            ChangeState(PlayerState.Idle);
            animator.SetBool("IsWalking", false);
        }
    }

    void HandleAttackingState()
    {

    }

    void HandleJumpingState()
    {
  
    }

    void CheckTransitions()
    {

    }

    public void ChangeState(PlayerState newState)
    {
        currentState = newState;
    }

    public PlayerState GetCurrentState()
    {
        return currentState;
    }
}
