using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnObjects;

    public void SpawnFirstObject(Transform position)
    {
        Instantiate(spawnObjects[0], position.position, Quaternion.identity);
    }
}
