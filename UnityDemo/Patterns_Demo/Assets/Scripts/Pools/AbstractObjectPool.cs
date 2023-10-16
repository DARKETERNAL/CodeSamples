using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractObjectPool<T> : MonoBehaviour, IPool
    where T : Object
{
    [SerializeField]
    private int poolSize = 5;

    private List<T> pool = new List<T>();

    public abstract ObjectPool.EPoolType PoolType { get; }

    // Start is called before the first frame update
    private void Start()
    {
        if (FactoryFacade.Instance != null)
        {
            for (int i = 0; i < poolSize; i++)
            {
                CreateObjectInstance();
            }
        }
    }

    private void CreateObjectInstance()
    {
        T objInstance = FactoryFacade.Instance.CreateInstance(PoolType) as T;
        objInstance.Pool = this;
        Recycle(objInstance);
    }

    public T Retrieve()
    {
        T result = null;

        if (pool.Count < 1)
        {
            CreateObjectInstance();
        }

        result = pool[0];
        pool.RemoveAt(0);
        result.Reset(true);

        return result as T;
    }

    private void Recycle(T obj)
    {
        pool.Add(obj);
        obj.Reset(false, transform);
    }

    public void Recycle(Object obj)
    {
        Recycle(obj as T);
    }
}