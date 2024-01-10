using System.Collections;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public float respawnTime = 5f; // 重新出现的时间

    // 调用这个方法来隐藏食物并在一段时间后重新出现
    public void HideAndRespawn(GameObject foodObject)
    {
        StartCoroutine(RespawnFood(foodObject));
    }

    private IEnumerator RespawnFood(GameObject foodObject)
    {
        foodObject.SetActive(false);
        yield return new WaitForSeconds(respawnTime);
        foodObject.SetActive(true);
    }
}