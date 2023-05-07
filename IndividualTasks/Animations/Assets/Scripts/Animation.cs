using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator;
    Player player;

    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Player>();
    }

    void Update()
    {
        animator.SetBool("isMoving", (Input.GetKey(KeyCode.W)));
        animator.SetBool("isLeft", (Input.GetKey(KeyCode.A)));
        animator.SetBool("isBack", (Input.GetKey(KeyCode.S)));
        animator.SetBool("isRight", (Input.GetKey(KeyCode.D)));


        if (Input.GetKey(KeyCode.Space) && (Input.GetKey(KeyCode.W) && player.grounded))
        {
            animator.SetBool("isJump", true);
        }
        else if ((Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.LeftShift)) && Input.GetKey(KeyCode.Space) && player.grounded))
        {
            animator.SetBool("isJump", true);
        }
        else if ((Input.GetKey(KeyCode.Space) && player.grounded))
        {
            animator.SetBool("isStayJump", true);
        }
        else
        {
            animator.SetBool("isJump", false);
            animator.SetBool("isStayJump", false);
            animator.SetBool("isBackJump", false);
        }

        if ((Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.LeftShift))))
        {
            animator.SetBool("isRunning", true);
        }
        else if ((Input.GetKey(KeyCode.S) && (Input.GetKey(KeyCode.LeftShift))))
        {
            animator.SetBool("isBackRun", true);
            player.JumpSpeed = 0;
        }
        else if ((Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Space) && player.grounded))
        {
            animator.SetBool("isBackJump", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isBackRun", false);
            animator.SetBool("isBackJump", false);
            player.JumpSpeed = 8;
        }

        if (Input.GetMouseButtonDown(0))
        {
            string[] attackTypes = { "Right Hook", "Uppercut" };
            string randomAttack = attackTypes[Random.Range(0, attackTypes.Length)];
            animator.Play(randomAttack);
        }
    }

    public void Death()
    {
        animator.Play("Death");
    }

}
