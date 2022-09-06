using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GroundManager : MonoBehaviour
{
    public GameObject groundPrefab;
    public GameObject foodPrefab;
    public int startSize = 20;

    public List<GameObject> groundObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startSize; i++)
        {
            if (i == 0)
            {
                var groundObject = Instantiate(groundPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                groundObjects.Add(groundObject);
            }
            else
            {
                bool toLeft = Random.value > 0.5f;
                var groundObject = Instantiate(groundPrefab, groundObjects.Last().transform.position + new Vector3(toLeft ? 1 : 0, 0, toLeft ? 0 : 1), Quaternion.identity);
                groundObjects.Add(groundObject);

                bool spawnFood = Random.value > 0.8f;
                if (spawnFood)
                {
                    Instantiate(foodPrefab, groundObject.transform.position + Vector3.up * 1, Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
