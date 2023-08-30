using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionWaypoint : MonoBehaviour
{
    public Image img;
    public Transform target;

    void Start()
    {
        
    }

    private void Update()
    {
        //keep x within the width of the screen
        float minX = img.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;
        //keep x within the height of the screen 
        float minY = img.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.width - minY;

        Vector2 pos = Camera.main.WorldToScreenPoint(target.position);

        //behind camera
/*        if(Vector3.Dot((target.position - transform.position), transform.forward) < 0)//if -1, target is behind player
        {
            if (pos.x < Screen.width / 2)
            {//if leftside
                pos.x = maxX;
            }
            else
            {//if rightside
                pos.x = minX;
            }
        }*/

        //consistantly change position
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        img.transform.position = pos;

    }


    // Start is called before the first frame update


}
