using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public abstract class Object : MonoBehaviour
{
    public AbstractObjectPool<Object> Pool { get; set; }

    public void Reset(bool activate, Transform parent = null)
    {
        if (activate)
        {
            GetComponent<Rigidbody>().useGravity = true;
            parent = null;
        }
        else
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().useGravity = false;

            if (parent != null)
            {
                transform.parent = parent;
                transform.position = parent.position;
                transform.rotation = parent.rotation;
            }
        }

        gameObject.SetActive(activate);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Pool?.Recycle(this);
    }
}