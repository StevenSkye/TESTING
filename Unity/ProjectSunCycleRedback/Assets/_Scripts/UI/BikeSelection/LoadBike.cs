using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBike : MonoBehaviour
{
    public GameObject[] bikeSelected;
    public Transform spawnPoint;

    void Start()
    {
        int selectedBike = PlayerPrefs.GetInt("selectedBike");
        GameObject prefab = bikeSelected[selectedBike];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        //add scripts to component
        //clone.AddComponent<ScriptName>();
    }
}
