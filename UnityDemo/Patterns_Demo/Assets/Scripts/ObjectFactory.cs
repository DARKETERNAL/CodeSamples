using UnityEngine;

public class ObjectFactory : MonoBehaviour
{
    [SerializeField]
    private Object obj;

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