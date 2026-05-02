using UnityEngine;
using UnityEngine.Rendering.Universal;

public class lightingfollowandexpand : MonoBehaviour
{
    public Transform target;      
    public Light2D light2D;       

    public float followSpeed = 5f; 
    public float stopX = 10f;
    public float expandSpeed = 40f; 
    public float targetRadius = 10f; 
    private bool stopFollowing = false;

     public float xOffset = 7f;

     void Start()
    {
        light2D = GetComponent<Light2D>();
    }
    void Update()
    {
        if (!stopFollowing)
        {
            Vector3 pos = transform.position;
            pos.x = Mathf.Lerp(pos.x, target.position.x - xOffset, followSpeed * Time.deltaTime);
            transform.position = pos;

            if (target.position.x <= stopX)
            {
                stopFollowing = true;
            }
        }
        else
        {
           light2D.pointLightOuterAngle += expandSpeed * Time.deltaTime;
        }
    }
}
