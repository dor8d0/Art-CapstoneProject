using UnityEngine;

public class DetachOnStart : MonoBehaviour
{
    void Start()
    {
        transform.SetParent(null, true);
    }

    void LateUpdate()
{
    transform.SetParent(null, true);
    enabled = false; 
}
}
