using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{
//public class Renderer : 

   string color = "";
    // Start is called before the first frame update
    void Start()
    {
        
            
        
    }
    void SetColor(string NewColor)
    {
        color=NewColor;
        Debug.Log(color);
    }

    // Update is called once per frame
    void Update()
    {
        
    // Debug.Log(Time.time);
       
        if (Time.time <= 3)
        {
            if (color !="red")
            {
                SetColor("red");
            }
        
        }
        else if (Time.time >3 && Time.time <= 5)
        {
            if (color !="yellow")
            {
                SetColor("yellow");
            }
        }
        else
        {
            if (color !="green")
            {
                SetColor("green");
            }
        }

    //Debug.Log($"the color is {color}");
    //gameObject.GetComponent<Renderer>().material.color =
    //tällä saat sen 3d objektin vaihtaan väriä kuhan keksit mitä oot tekemässä


    }
}
