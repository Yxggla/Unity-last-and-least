using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wxrroom2suiji : MonoBehaviour
{
    public GameObject enemyPrefab; // 敌人的预制体
    public float spawnDelay = 3f;  // 生成敌人的延迟时间
    public Vector3 spawnAreaSize;  // 生成敌人的区域大小
    public bool isPaused = false;
    private void Start()
    {
        // 启动协程，等待生成敌人
        StartCoroutine(SpawnEnemyWithDelay());
    }

    private IEnumerator SpawnEnemyWithDelay()
    {
        while (true)
        {
            if (!isPaused)
            {
                // 等待一定时间
                yield return new WaitForSeconds(spawnDelay);

                // 在随机位置生成敌人
                Vector3 randomSpawnPoint = GetRandomSpawnPoint();
                Instantiate(enemyPrefab, randomSpawnPoint, Quaternion.identity);
            }
        }
    }

    private Vector3 GetRandomSpawnPoint()
    {
        // 生成随机位置
        float randomX = Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f);
        float randomY = Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f);
        float randomZ = Random.Range(-spawnAreaSize.z / 2f, spawnAreaSize.z / 2f);

        return transform.position + new Vector3(randomX, randomY, randomZ);
    }

    // 可视化生成区域的 Gizmo，方便在场景视图中观察生成区域大小
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, spawnAreaSize);
    }
    public void TogglePause()
    {
        isPaused = true;
    }
}
