using UnityEngine;

public class ObjectFactory : MonoBehaviour
{
    [SerializeField]
    private Object obj;

    [SerializeField]
    private ObjectPool.EPoolType objectType = ObjectPool.EPoolType.None;

    public ObjectPool.EPoolType ObjectType => objectType;

    public Object CreateInstance()
    {
        Object result = Instantiate(obj);

        obj.GetComponent<Renderer>().sharedMaterial.color = new Color(
            Random.Range(0F, 255F),
            Random.Range(0F, 255F),
            Random.Range(0F, 255F));

        return result;
    }
}