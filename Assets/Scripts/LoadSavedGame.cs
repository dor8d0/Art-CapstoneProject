using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SavedGameData
{
    public int[] savedStates;
    public int[] savedColors;
}

public class LoadSavedGame : MonoBehaviour
{
    

    public void loadGame()
    {

        //loads the JSON data
        string jsonString = File.ReadAllText("Assets\\SavedGameTestJSON.txt");
        SavedGameData data = JsonUtility.FromJson<SavedGameData>(jsonString);

        //re-maps the array lists in the game data to the saved JSON data
        GameData.savedStates.Clear();
        GameData.savedColors.Clear();

        for (int i = 0; i < data.savedStates.Length; i++)
        {
            GameData.savedStates.Add(data.savedStates[i]);

            //appends a color based off the integer value
            switch (data.savedStates[i]) {
                
                case 1:
                    GameData.savedColors.Add(Color.red);
                    break;
                case 2:
                    GameData.savedColors.Add(Color.blue);
                    break;
                case 3:
                    GameData.savedColors.Add(Color.yellow);
                    break;
                default:
                    Debug.Log("Missing color at scene " + i);
                    break;

            }
        }

        //chooses which scene to go to based off how many choices have already been made
        if (data != null )
        {
            if (data.savedStates != null) {
                GameData.gameFinished = false;
                GameData.showingFullPlayback = false;
                SceneManager.LoadScene("Lil RedHood Scene");
            }
            else
            {
                Debug.Log("error loading saved states");
            }
        }
        else
        {
            Debug.Log("Error reading json");
        }
    }
}
