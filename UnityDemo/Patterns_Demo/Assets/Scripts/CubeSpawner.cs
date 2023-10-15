using UnityEngine;

public class CubeSpawner : MonoBehaviour, ISpawner
{
    [SerializeField]
    private float spawnFrequency = 2F;

    private ObjectPool objPool;

    private void Start()
    {
        ObjectPool[] pools = FindObjectsByType<ObjectPool>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (ObjectPool pool in pools)
        {
            if (pool.PoolType.Equals(ObjectPool.EPoolType.Cube))
            {
                objPool = pool;
                break;
            }
        }
    }

    public void Spawn()
    {
        InvokeRepeating("InstantiateObjects", 0F, spawnFrequency);
    }

    private void InstantiateObjects()
    {
        if (objPool != null)
        {
            objPool.Retrieve();
        }
    }

    public void Stop()
    {
        CancelInvoke();
        Destroy(this);
    }
}