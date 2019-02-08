using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    public float toRight;
    public float pos;
    public float fallMultiplier = 1.0f;



    // Use this for initialization
    void Start()
    {

        Time.timeScale = 2f;

    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position.x;
        print(pos);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x == 0)
        {

            JumpCenterLeft(true);

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x == 0)
        {

            JumpCenterRight(true);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x <= -1.14)
        {
            print("es");
            JumpCenter(true);

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x >= 1.14)
        {
            print("es");
            JumpCenter(true);

        }


        /* if(this.transform.position.x >=3.8){
             Vector3 position = this.transform.position;
             position.x--;
             this.transform.position = position;

         }

          if (this.transform.position.x == 1.15)
         {

         }
          */

    }

    void JumpCenterRight(bool CenterRight)
    {
        if (CenterRight)
        {
            Vector3 position = this.transform.position;
            position.x = 1.15f;
            this.transform.position = position;

        }
    }

    void JumpCenterLeft(bool CenterLeft)
    {
        if (CenterLeft)
        {
            Vector3 position = this.transform.position;
            position.x = -1.15f;
            this.transform.position = position;
            print(position.x);
        }
    }

    void JumpCenter(bool Center)
    {
        if (Center)
        {
            Vector3 position = this.transform.position;
            position.x = 0f;
            this.transform.position = position;


        }
    }




}

