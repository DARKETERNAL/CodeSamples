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
            ISpawner newSpawner = gameObject.AddComponent<CubeSpawner>();
            spawners.Add(newSpawner);
            newSpawner.Spawn();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            ISpawner newSpawner = gameObject.AddComponent<SphereSpawner>();
            spawners.Add(newSpawner);
            newSpawner.Spawn();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            foreach (ISpawner spawner in spawners)
            {
                //spawners.Remove(spawner);
                spawner.Stop();
            }

            spawners.Clear();
        }
    }
}