using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BikeSelection : MonoBehaviour
{
    public GameObject[] bikes;
    public int selectedBike = 0;

    //buttons
    [SerializeField] private Button nextButton;
    [SerializeField] private Button testButton;
    [SerializeField] private Button playButton;

    void Start()
    {
        nextButton.onClick.AddListener(NextChar);

        //this is the "select button"
        playButton.onClick.AddListener(LevelSelect);

        testButton.onClick.AddListener(testGame);
        //hide all bikes other than the first one
        for (int i = 1; i < bikes.Length; i++)
        {
            bikes[i].SetActive(false);
        }
    }

    private void NextChar()//go to next bike
    {
        bikes[selectedBike].SetActive(false);
        selectedBike = (selectedBike + 1) % bikes.Length;
        Debug.Log("next character, " + selectedBike);
        bikes[selectedBike].SetActive(true);
    }

    private void PrevChar()//goes to previous bike
    {
        bikes[selectedBike].SetActive(false);
        selectedBike--;
        Debug.Log("next character, " + selectedBike);
        if (selectedBike < 0)
        {
            selectedBike += bikes.Length;
        }
        bikes[selectedBike].SetActive(true);
    }

    //when select button is clicked
    public void LevelSelect()
    {
        PlayerPrefs.SetInt("SelectedBike", selectedBike);
        MapLoader.Load(MapLoader.Scene.LevelSelection);
    }



    private void testGame()
    {
        PlayerPrefs.SetInt("SelectedBike", selectedBike);
        Debug.Log("Bike now selected: " + selectedBike);
        //SceneManager.LoadScene();
        MapLoader.Load(MapLoader.Scene.SampleScene);
    }

}
