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
    public GameObject xueliangpanel;
    public room2xiaoshuai room2xiaoshuai;
    public GameObject passwordpanel;
    public GameObject stonePrefab;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool disapper = room2xiaoshuai.canDisappear;
        direction = new Vector3(horizontal, 0f, vertical).normalized;
        if (xueliangpanel.activeSelf)
        {
            ApplyGravity();
            
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
            if (Input.GetMouseButtonDown(0) && !passwordpanel.activeSelf )
            {
                animator.SetTrigger("attack");
                if (disapper)
                {
                    GameObject[] boxes = GameObject.FindGameObjectsWithTag("box");
                    foreach (GameObject box in boxes)
                    {
                        float distance = Vector3.Distance(transform.position, box.transform.position);
                        if (distance <= 3f)
                        {
                            Debug.Log(distance);
                            float dropChance = 0.7f;
                            // 检查是否生成石头
                            if (Random.value < dropChance)
                            {
                                Instantiate(stonePrefab, box.transform.position, Quaternion.identity);
                            }
                            Destroy(box); // 销毁距离小于或等于 3f 的 box
                        }
                    }
                }
            }

            animator.SetFloat("speed", Mathf.Abs(horizontal) + Mathf.Abs(vertical));
        
        }
        
    }
    void ApplyGravity()
    {
        // 应用重力和下落效果
        Vector3 gravity = new Vector3(0, -9.8f, 0); // 重力值
        controller.Move(gravity * Time.deltaTime);
    }
    

    // bool IsGrounded()
    // {
    //     RaycastHit hit;
    //     float distance = 1f; // 检测地面的射线长度
    //     Vector3 origin = transform.position; // 射线的起始位置
    //
    //     // 向下发射射线检测是否接触地面
    //     if (Physics.Raycast(origin, Vector3.down, out hit, distance))
    //     {
    //         if (hit.collider.tag == "ground") // 检查碰撞的对象是否是地板
    //         {
    //             return true;
    //         }
    //     }
    //     return false;
    // }
    
    
}