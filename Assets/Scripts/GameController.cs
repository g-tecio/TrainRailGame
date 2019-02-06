using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public enum GameState { Idle,Playing,Ended};
    public GameState gameState = GameState.Playing;
    public float parallaxSpeed = 0.06f;
    public float parallaxSpeed2 = 0.02f;
    public RawImage Background;
    public RawImage RoadCenter;
    public RawImage RoadLeft;
    public RawImage RoadRight;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if (gameState==GameState.Idle== Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameState = GameState.Playing;

        }*/
        if (gameState == GameState.Playing)
        {
            float finalSpeed = parallaxSpeed * Time.deltaTime;
            Background.uvRect = new Rect(0f, Background.uvRect.y + finalSpeed, 1f, 1f);
            float finalSpeed2 = parallaxSpeed2 * Time.deltaTime;
            RoadCenter.uvRect = new Rect(0f, (RoadCenter.uvRect.y + finalSpeed) * 1, 1f, 1f);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game Scene");
    }
}
