using UnityEngine;

public class ImageDisabler : MonoBehaviour
{

    public GameObject redhood;
    public GameObject wolf;
    public GameObject wolfjaw;
    public GameObject house;
    public GameObject grandma;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //gets references for all the sprites
        

        //makes all of the sprites invisible by disabling them
        redhood.GetComponent<SpriteRenderer>().enabled = false;
        wolf.GetComponent<SpriteRenderer>().enabled = false;
        house.GetComponent<SpriteRenderer>().enabled = false;
        grandma.GetComponent<SpriteRenderer>().enabled = false;
        wolfjaw.GetComponent<SpriteRenderer>().enabled = false;

        //re-enables certain sprites depending on which scene you're in

        if (GameData.savedStates.Count == 0) //in the first scene
        {
            redhood.GetComponent<SpriteRenderer>().enabled = true; //re-enables the red riding hood sprite
        }
        else if (GameData.savedStates.Count == 1)
        {
            wolf.GetComponent<SpriteRenderer>().enabled = true; //re-enables wolf sprite
            house.GetComponent<SpriteRenderer>().enabled = true;
            wolfjaw.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (GameData.savedStates.Count == 2)
        {
            wolf.GetComponent<SpriteRenderer>().enabled = true; //re-enables wolf sprite
            house.GetComponent<SpriteRenderer>().enabled = true;
            wolfjaw.GetComponent<SpriteRenderer>().enabled = true;
            
            if (GameData.savedStates[0] != 1)
            {
                grandma.GetComponent<SpriteRenderer>().enabled = true; //re-enables the grandma sprite if she wasn't eaten
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
