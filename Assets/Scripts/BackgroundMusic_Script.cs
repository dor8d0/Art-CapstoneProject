using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundMusic_Script : MonoBehaviour
{
    public static BackgroundMusic_Script instance;

    private void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
