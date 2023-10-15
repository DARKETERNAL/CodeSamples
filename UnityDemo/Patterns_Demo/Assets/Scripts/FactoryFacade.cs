using UnityEngine;

public class FactoryFacade : MonoBehaviour
{
    private static FactoryFacade instance;

    [SerializeField]
    private ObjectFactory[] factories;

    public static FactoryFacade Instance => instance;

    public Object CreateInstance(ObjectPool.EPoolType objType)
    {
        Object result = null;

        for (int i = 0; i < factories.Length; i++)
        {
            if (factories[i].ObjectType.Equals(objType))
            {
                result = factories[i].CreateInstance();
                break;
            }
        }

        return result;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}