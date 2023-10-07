using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public static ObjectSpawner Instance { get; private set; }

    [SerializeField]
    private ObjectPool objPool;

    [SerializeField]
    private float spawnFrequency;

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

    // Start is called before the first frame update
    private void Start()
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
}