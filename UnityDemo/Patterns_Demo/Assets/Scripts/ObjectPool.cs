using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public enum EPoolType
    {
        None,
        Cube,
        Sphere
    }

    [SerializeField]
    private int poolSize = 5;

    [SerializeField]
    private EPoolType poolType = EPoolType.None;

    private List<Object> pool = new List<Object>();

    public EPoolType PoolType => poolType;

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
        Object objInstance = FactoryFacade.Instance.CreateInstance(PoolType);
        //objInstance.Pool = this;
        Recycle(objInstance);
    }

    public Object Retrieve()
    {
        Object result = null;

        if (pool.Count < 1)
        {
            CreateObjectInstance();
        }

        result = pool[0];
        pool.RemoveAt(0);
        result.transform.parent = null;
        result.Reset(true);

        return result;
    }

    public void Recycle(Object obj)
    {
        obj.Reset(false);
        obj.transform.parent = transform;
        obj.transform.position = transform.position;
        obj.transform.rotation = transform.rotation;
        pool.Add(obj);
    }
}