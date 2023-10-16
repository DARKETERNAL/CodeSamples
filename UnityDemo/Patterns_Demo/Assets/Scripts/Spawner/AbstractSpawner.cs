using UnityEngine;

public abstract class AbstractSpawner<T> : MonoBehaviour, ISpawner
    where T : Object
{
    [SerializeField]
    protected float spawnFrequency = 2F;

    private AbstractObjectPool<T> objPool;

    

    protected abstract ObjectPool.EPoolType PoolType { get; }

    protected virtual void Start()
    {
        AbstractObjectPool<T>[] pools = FindObjectsByType<AbstractObjectPool<T>>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (AbstractObjectPool<T> pool in pools)
        {
            if (pool.PoolType.Equals(PoolType))
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

    protected void InstantiateObjects()
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