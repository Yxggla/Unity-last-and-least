using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private CharacterController controller;
    private Animator animator;
    private float movespeed;
    private float slow_run_speed = 3f;
    private float fast_run_speed = 6f;
    private float rotationSpeed = 5f;

    private Vector3 lastMoveDirection;
    private Vector3 smoothMoveVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        lastMoveDirection = transform.forward; // 初始化为初始朝向
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 inputDir = new Vector3(horizontal, 0f, vertical).normalized;
        Vector3 forward = transform.forward;

        Vector3 dir = Quaternion.FromToRotation(Vector3.forward, forward) * inputDir;

        if (dir.magnitude >= 0.1f)
        {
            // 仅当方向变化时才更新旋转和移动
            if (dir != lastMoveDirection)
            {
                Quaternion toRotation = Quaternion.LookRotation(dir, Vector3.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * rotationSpeed);

                Vector3 v = movespeed * Time.deltaTime * dir;
                controller.Move(v);
            }

            lastMoveDirection = dir;
        }

        // if (Input.GetButtonDown("shirt")) // 仅在按下瞬间调整朝向
        // {
        //     Quaternion toRotation = Quaternion.LookRotation(dir, Vector3.up);
        //     transform.rotation = toRotation;
        // }

        if (Input.GetButton("shirt"))
        {
            movespeed = fast_run_speed;
            animator.SetBool("isRun", true);
        }
        else
        {
            movespeed = slow_run_speed;
            animator.SetBool("isRun", false);
        }

        animator.SetFloat("speed", Mathf.Abs(horizontal) + Mathf.Abs(vertical)); // 使用水平和垂直输入的绝对值作为动画速度
    }
}




