using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sintax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position fo my object
        /*hi there!
        * this is two lines!
        **/
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I am about to hit the ground!");
        }
    }

}
