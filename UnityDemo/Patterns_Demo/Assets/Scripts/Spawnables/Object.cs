using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class Object : MonoBehaviour
{
    public AbstractObjectPool<Object> Pool { get; set; }

    public void Reset(bool activate)
    {
        if (activate)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
        else
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().useGravity = false;
        }

        gameObject.SetActive(activate);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Pool?.Recycle(this);
    }
}