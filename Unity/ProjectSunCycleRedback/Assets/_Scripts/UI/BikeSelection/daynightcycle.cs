using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DayNightCycle : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;

    private void Start()
    {
        // Set the initial skybox to day
        RenderSettings.skybox = daySkybox;
    }

    // Add a method to toggle between day and night
    public void ToggleDayNight(bool isDay)
    {
        if (isDay)
        {
            RenderSettings.skybox = daySkybox;
        }
        else
        {
            RenderSettings.skybox = nightSkybox;
        }
    }
}
