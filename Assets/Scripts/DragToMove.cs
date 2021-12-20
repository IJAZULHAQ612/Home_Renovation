using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToMove : MonoBehaviour
{
    private Touch touch;
    private float speedModifier; // controls how fast model will move

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.001f; // increase this value yo make object move faster
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0) // when a fingeris touching the screen
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved) //when move gesture is performed
            {
                //changes position of the object in each frame assign new vector 3 values
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier, transform.position.y, transform.position.z + touch.deltaPosition.y * speedModifier);
                // orginal x value of car + how much our finger has moved for that frame in x * spped,keep origibal y ,same as first part exept for z value of car ,and y vslue of finger
            }
        }
        
    }
}
