using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int EntityType = 50;
            if (EntityType == 10)
            {
                Debug.Log("I am Enemy! My HP is 10!");
            }
            else if (EntityType == 50)
            {
                Debug.Log("I am Player! My HP is 50!");
            }
            else if (!(EntityType == 10 ||EntityType == 50))
            {
                Debug.Log("I have no idea what I am...");
            }
           /*
            else if (EntityType <10f && >10f && <50f && >50f)
            {
                Debug.Log("I'm neither Player or Enemy");
            }
            */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
