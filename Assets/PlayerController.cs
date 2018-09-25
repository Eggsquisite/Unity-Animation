using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    const int STATE_IDLE = 0;
    const int STATE_RUN = 1;
    const int STATE_CROUCH = 2;
    const int STATE_HURT = 3;
    const int STATE_JUMP = 4;
    const int STATE_CLIMB = 5;

    Animator animator;

    int current_AnimationState = STATE_IDLE;
    int myState = 0;

    // Use this for initialization
    void Start () {
        animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return) && myState == 0)
        {
            changeState(STATE_RUN);
            myState++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && myState == 1)
        {
            changeState(STATE_CLIMB);
            myState++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && myState == 2)
        {
            changeState(STATE_CROUCH);
            myState++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && myState == 3)
        {
            changeState(STATE_HURT);
            myState++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && myState == 4)
        {
            changeState(STATE_JUMP);
            myState++;
        }

    }

    // Change Players Animation State
    void changeState(int state) {
        if (current_AnimationState == state)
            return;

        switch (state) {
            case STATE_RUN:
                animator.SetInteger("state", STATE_RUN);
                break;
            case STATE_IDLE:
                animator.SetInteger("state", STATE_IDLE);
                break;
            case STATE_CROUCH:
                animator.SetInteger("state", STATE_CROUCH);
                break;
            case STATE_HURT:
                animator.SetInteger("state", STATE_HURT);
                break;
            case STATE_JUMP:
                animator.SetInteger("state", STATE_JUMP);
                break;
            case STATE_CLIMB:
                animator.SetInteger("state", STATE_CLIMB);
                break;
        }

        current_AnimationState = state;
    }
}
