using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Animator animator;
    private float movespeed;
    private float slow_run_speed = 3f;
    private float fast_run_speed = 6f;
    private float rotationSpeed = 5f;

    private Vector3 lastMoveDirection;
    private Vector3 smoothMoveVelocity;
    public Transform cam;
    private Vector3 direction;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetangle, 0f) * Vector3.forward;
            controller.Move(moveDir * movespeed * Time.deltaTime);
        }

        if (Input.GetButton("shift")) // 修改为正确的按钮名字
        {
            movespeed = fast_run_speed;
            animator.SetBool("isRun", true);
        }
        else
        {
            movespeed = slow_run_speed;
            animator.SetBool("isRun", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
        }

        animator.SetFloat("speed", Mathf.Abs(horizontal) + Mathf.Abs(vertical));
    }
}