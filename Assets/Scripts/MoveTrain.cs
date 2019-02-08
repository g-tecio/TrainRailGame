using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTrain : MonoBehaviour {
    public Animator anim;
    public GameObject game;
    public GameObject enemyGenerator1;
    public GameObject enemyGenerator2;
    public GameObject enemyGenerator3;
    public GameObject prizeGenerator1;
    public GameObject prizeGenerator2;
    public GameObject prizeGenerator3;
    public GameObject enemyGeneratorUp;

    public GameObject buttonShootFront;

    public GameObject buttonShootBehind;
    public float toRight;
    public float pos;
    public float fallMultiplier = 1.0f;
    public Text LooseText;
    public GameObject txt;
    public GameObject btnPause;
  



    // Use this for initialization
    void Start()
    {
      //LooseText= GameObject.Find("LooseText").GetComponent<Text>();
        anim = GetComponent<Animator>();
    
        
        Time.timeScale = 2f;

    }

    public void movementLeft()
    {
        bool gamePlaying = game.GetComponent<GameController>().gameState == GameController.GameState.Playing;
        pos = this.transform.position.x;
        print(pos);
        if (gamePlaying)
        {
            if (this.transform.position.x <= 0.42)
            {

                JumpCenterLeft(true);
                print(pos);

            }



            else if (this.transform.position.x >= 1.55)
            {
                print("entro izquierddo");
                JumpCenter(true);
                print(pos);

            }
        }

    }

    public void movementRight()
    {
        bool gamePlaying = game.GetComponent<GameController>().gameState == GameController.GameState.Playing;
        pos = this.transform.position.x;
        print(pos);
        if (gamePlaying)
        {
            if (this.transform.position.x >= 0.41)
            {

                print("entro 0.42");


                JumpCenterRight(true);
                print(pos);
            }

            else if (this.transform.position.x <= -0.67)
            {
                print("entro aqui");
                JumpCenterRight(false);
                JumpCenter(true);

                print(pos);

            }


        }



    }



    // Update is called once per frame
    void Update()
    {
        bool gamePlaying = game.GetComponent<GameController>().gameState == GameController.GameState.Playing;
        pos = this.transform.position.x;
        print(pos);
        if (gamePlaying)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x <= 0.42)
            {

                JumpCenterLeft(true);
                print(pos);

            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x >= 0.41)
            {

                print("entro 0.42");


                JumpCenterRight(true);
                print(pos);
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x <= -0.67)
            {
                print("entro aqui");
                JumpCenterRight(false);
                JumpCenter(true);

                print(pos);

            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x >= 1.55)
            {
                print("entro izquierddo");
                JumpCenter(true);
                print(pos);

            }
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
            position.x = 1.56f;
            this.transform.position = position;

        }
    }

    void JumpCenterLeft(bool CenterLeft)
    {
        if (CenterLeft)
        {
            Vector3 position = this.transform.position;
            position.x = -0.68f;
            this.transform.position = position;
            print(position.x);
        }
    }

    void JumpCenter(bool Center)
    {
        if (Center)
        {
            Vector3 position = this.transform.position;
            position.x = 0.42f;
                this.transform.position = position;


        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("Me muero");

            updateState("Die");
            game.GetComponent<GameController>().gameState=GameController.GameState.Ended;
            txt.SetActive(true);
            btnPause.SetActive(false);
            buttonShootFront.SetActive(false);
            buttonShootBehind.SetActive(false);
            enemyGenerator1.SendMessage("CancelGenerator1", true);
            enemyGenerator2.SendMessage("CancelGenerator2", true);
            enemyGenerator3.SendMessage("CancelGenerator3", true);
            prizeGenerator1.SendMessage("CancelPrizeGenerator1", true);
            prizeGenerator2.SendMessage("CancelPrizeGenerator2", true);
            prizeGenerator3.SendMessage("CancelPrizeGenerator1", true);
             enemyGeneratorUp.SendMessage("CancelGeneratorYeti", true);

        }
        
    }
    public void updateState(string state=null)
    {
        if (state != null)
        {
            anim.Play(state);
        }
    }


}
