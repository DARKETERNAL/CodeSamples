using System.Collections.Generic;
using UnityEngine;

public class AbstractFactory<T> : MonoBehaviour
    where T : Object
{
    [SerializeField]
    private T obj;

    [SerializeField]
    private ObjectPool.EPoolType objectType = ObjectPool.EPoolType.None;

    private Renderer instanceRenderer;
    private List<Material> instancedMaterials = new List<Material>();

    public ObjectPool.EPoolType ObjectType => objectType;

    public T CreateInstance()
    {
        T result = Instantiate(obj);

        instanceRenderer = result.GetComponent<Renderer>();
        instanceRenderer.GetMaterials(instancedMaterials);
        instancedMaterials[0].SetColor(
            "_Color",
            new Color(
                Random.Range(0F, Random.Range(0F, 1F)),
                Random.Range(0F, Random.Range(0F, 1F)),
                Random.Range(0F, Random.Range(0F, 1F))));

        instancedMaterials.Clear();
        instanceRenderer = null;

        return result;
    }
}