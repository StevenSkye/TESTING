using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class MapLoader
{
    public static int targetSceneIndex;

    public enum Scene // Add the scene name here when adding more scenes on the Build Settings
    {
        MainMenuScene,
        MainScene,
        SceneSelect,
        CityScene,
        BikeSelectScene,
        SampleScene
    }

    public static void Load(Scene sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString());
    }

}
