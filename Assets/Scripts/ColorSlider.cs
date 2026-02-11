using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.Universal;

public class ColorSlider : MonoBehaviour
{

    public float CurrentValue;
    public Light2D light;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //changes the color based off the value of the slider it's connected too
    public void SetColorValue(float value)
    {

        //gets the integer value of the slider
        CurrentValue = value;

    }
}
