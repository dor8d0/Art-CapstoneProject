using UnityEngine;
using System.Collections.Generic;

public static class GameData
{
    public static int selectedColorState = 0;
    public static Color selectedColor = Color.black;
    public static float selectedIntensity = 0f;
    public static bool gameFinished = false;
    public static bool showingFullPlayback = false;

    public static List<int> savedStates = new List<int>();
    public static List<Color> savedColors = new List<Color>();
}
