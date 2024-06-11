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
    private float fitstspeed = 10f;
    Vector3 move;
    private Vector3 lastMoveDirection;
    private Vector3 smoothMoveVelocity;
    public Transform cam;
    public Vector3 direction;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public GameObject xueliangpanel;
    public room2xiaoshuai room2xiaoshuai;
    public GameObject passwordpanel;
    public GameObject stonePrefab;
    public GameObject bookPrefab;
    public GameObject book2Prefab;
    private bool canSpawnEnemy = true; // 控制是否可以生成敌人
    public wxrroom2suiji wxrroom2;
    private AudioSource audioSource;
    public value playvalue;
    private bool gengxin=true;
    public jixvgame Jixvgame;
    public bool disapper=false;
    public GameObject passwordplane;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        gengxin=true;
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        disapper = room2xiaoshuai.canDisappear;
        direction = new Vector3(horizontal, 0f, vertical).normalized;
        if (gengxin && Jixvgame.jxyxjr)
        {
            Debug.Log("player");
            Debug.Log(playvalue.playerPosition);

            // 计算从当前位置到目标位置的方向
            Vector3 targetDirection = (playvalue.playerPosition - transform.position).normalized;

            // 仅在 x 和 z 轴上移动
            Vector3 m = new Vector3(targetDirection.x, 0f, targetDirection.z) * fitstspeed * Time.deltaTime;

            // 通过 CharacterController 移动
            controller.Move(m);

            // 检查是否到达目标位置
            if(Vector3.Distance(new Vector3(transform.position.x, 0f, transform.position.z), new Vector3(playvalue.playerPosition.x, 0f, playvalue.playerPosition.z)) < 0.1f) {
                gengxin = false; // 如果到达目标位置，停止更新
                Vector3 lookDirection = new Vector3(playvalue.playerPosition.x, transform.position.y, playvalue.playerPosition.z);
                transform.LookAt(lookDirection);
            }
        }



        if (xueliangpanel.activeSelf && !passwordplane.activeSelf)
        {
            ApplyGravity();
            if (direction.magnitude >= 0.1f)
            {
                float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
                Vector3 moveDir = Quaternion.Euler(0f, targetangle, 0f) * Vector3.forward;
            
                // 在有有效输入的情况下移动
                controller.Move(moveDir * movespeed * Time.deltaTime);
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
                GameObject[] wxyboxes = GameObject.FindGameObjectsWithTag("enemy");
                if (wxyboxes !=null)
                {
                    foreach (GameObject wxy in wxyboxes)
                    {
                        float distance = Vector3.Distance(transform.position, wxy.transform.position);
                        if (distance <= 2.5f)
                        {
                            Destroy(wxy); 
                        }
                    }
                }
                
                GameObject wxydl = GameObject.FindGameObjectWithTag("enemydl");
                if (wxydl !=null)
                {
                    float distancedl = Vector3.Distance(transform.position, wxydl.transform.position);
                    if (distancedl <= 2.5f)
                    {
                        Destroy(wxydl); 
                        Instantiate(bookPrefab, wxydl.transform.position, Quaternion.identity);
                    }
                }
                
                
                    // 生成敌人的逻辑
                // GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemysjdl");
                // if (enemies!=null)
                // {
                //     foreach (GameObject enemy in enemies)
                //     {
                //         float distance = Vector3.Distance(transform.position, enemy.transform.position);
                //
                //         if (distance <= 2.5f)
                //         {
                //             // 摧毁敌人并生成书本
                //             DestroyEnemyAndSpawnBook(enemy);
                //         }
                //     }
                // }
                
                GameObject wxydl2 = GameObject.FindGameObjectWithTag("enemysjdl");
                if (wxydl2 !=null)
                {
                    float distancesjdl = Vector3.Distance(transform.position, wxydl2.transform.position);
                    if (distancesjdl <= 2.5f)
                    {
                        Destroy(wxydl2); 
                        Instantiate(book2Prefab, wxydl2.transform.position, Quaternion.identity);
                    }
                }
                
            }
        
        }
        
    }
    void ApplyGravity()
    {
        // 应用重力和下落效果
        //Vector3 gravity = new Vector3(0, -9.8f, 0); // 重力值
        //controller.Move(gravity * Time.deltaTime);
    }
    // private void DestroyEnemyAndSpawnBook(GameObject enemy)
    // {
    //     float dropChance = 0.4f;
    //
    //     // 检查是否生成书本
    //     if (Random.value < dropChance && canSpawnEnemy)
    //     {
    //         Instantiate(book2Prefab, enemy.transform.position, Quaternion.identity);
    //         canSpawnEnemy = false;
    //         wxrroom2.TogglePause();
    //     }
    //
    //     // 摧毁敌人
    //     Destroy(enemy);
    //     
    // }
    public void attackvoice()
    {
        audioSource.Play();
    }
    
}