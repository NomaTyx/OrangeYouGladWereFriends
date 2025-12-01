using Unity.Mathematics;
using Unity.Mathematics.Geometry;
using UnityEngine;

public class SpawnApples : MonoBehaviour
{
    [SerializeField] private GameObject apple;

    private void Start()
    {
        for(int i = 15; i <= 1000; i += 10)
        {
            GameObject newApple = GameObject.Instantiate(apple);
            newApple.transform.position = new Vector3(2 - UnityEngine.Random.Range(0, 5), 1 - i / math.sqrt(3), math.sqrt(math.pow(i, 2) + i / math.sqrt(3)));
        }
    }
}
