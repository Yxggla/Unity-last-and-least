using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwaixingren : MonoBehaviour
{
    private CharacterController controller;
    public Transform player; // 玩家的Transform
    public float attackDistance ; // 攻击距离
    public float walkDistance ; // 追踪距离
    private Animator animator; // Animator组件
    private codeforhealthbar healthBarScript1;
    public GameObject healthBarObject;
    private bool canTakeDamage = true;  // 控制是否可以扣血
    private float damageCooldown = 2f;  // 扣血的冷却时间
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>(); // 获取Animator组件
        if (healthBarObject != null)
        {
            healthBarScript1 = healthBarObject.GetComponent<codeforhealthbar>();
        }
        else
        {
            Debug.LogError("HealthBar object not found!");
        }   
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        
        if (distance <= attackDistance && canTakeDamage)
        {
            TakeDamage1();
            StartCoroutine(StartCooldown());
        }
        else if (distance <= walkDistance)
        {
            // 走向玩家
            animator.SetBool("IsWalking", true);
            Vector3 lookAtPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.LookAt(lookAtPosition);
            ApplyGravity();
        }
        else
        {
            // 空闲状态
            animator.SetBool("IsWalking", false);
        }
    }
    
    void ApplyGravity()
    {
        // 应用重力和下落效果
        Vector3 gravity = new Vector3(0, -9.8f, 0); // 重力值
        controller.Move(gravity * Time.deltaTime);
    }
    
    public void TakeDamage1()
    {
        Debug.Log("attack");
        healthBarScript1.TakeDamage();
    }
    private IEnumerator StartCooldown()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageCooldown);
        canTakeDamage = true;
    }
}
