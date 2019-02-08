using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour {
    public float velocity = 0.5f;
    private Rigidbody2D rb;
    public int cont;
    public static int aber;
    public string s;
    public Text CountText;
    private CarbonController carbonController;
    // Use this for initialization
    void Start()
    {
        
        CountText = GameObject.Find("CountText").GetComponent<Text>();

        aber = 0;
<<<<<<< HEAD
        CountText.text = "Points " + cont.ToString();
=======
        CountText.text = "Points: " + cont.ToString();
>>>>>>> origin/master


    }

    // Update is called once per frame
    void Update()
    {
        //print(cont);
        
<<<<<<< HEAD
        CountText.text = "Points " + aber;
=======
        CountText.text = "Points: " + aber;
>>>>>>> origin/master
    }
   public void sum(int point)
    {
        cont += point;


        //print(cont);

    }
    public void sds()
    {
        print(aber);

        cont += aber;
        print(cont);
    }
   

           
 
}
