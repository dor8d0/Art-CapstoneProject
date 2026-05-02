using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightExpanding : MonoBehaviour
{
    public Transform targetObject;   //The object
    public float triggerX = -3.5f;      //X position of Objecy
    public float targetAngle = 140f; //Final width
    public float expandSpeed = 40f;  //Expansion speed
    private bool pleaseExpand = false;
    private Light2D light2D;

    void Start()
    {
        light2D = GetComponent<Light2D>();
    }

    void Update()
    {
        if (!pleaseExpand && targetObject.position.x < triggerX)
        {
            pleaseExpand = true;
        }

        if (pleaseExpand && light2D.pointLightOuterAngle < targetAngle)
        {
            light2D.pointLightOuterAngle += expandSpeed * Time.deltaTime;
        }
    }
}
