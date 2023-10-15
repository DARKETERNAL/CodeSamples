using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory<T> : MonoBehaviour, IFactory
    where T : Object
{
    [SerializeField]
    private T obj;

    private Renderer instanceRenderer;
    private List<Material> instancedMaterials = new List<Material>();

    public abstract ObjectPool.EPoolType ObjectType { get; }

    public Object CreateInstance()
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