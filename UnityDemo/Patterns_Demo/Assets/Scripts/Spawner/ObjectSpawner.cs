using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public static ObjectSpawner Instance { get; private set; }

    private List<ISpawner> spawners = new List<ISpawner>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SpawnFromNewSpawner(gameObject.AddComponent<CubeSpawner>());
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            SpawnFromNewSpawner(gameObject.AddComponent<SphereSpawner>());
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            foreach (ISpawner spawner in spawners)
            {
                spawner.Stop();
            }

            spawners.Clear();
        }
    }

    private void SpawnFromNewSpawner(ISpawner newSpawner)
    {
        spawners.Add(newSpawner);
        newSpawner.Spawn();
    }
}