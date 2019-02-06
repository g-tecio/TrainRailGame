using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveRoad : MonoBehaviour {

    public float parallaxSpeed = 0.02f;
    public RawImage RoadCenter;
    public RawImage RoadLeft;
    public RawImage RoadRight;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float finalSpeed = parallaxSpeed * Time.deltaTime;
        RoadCenter.uvRect = new Rect(0f, (RoadCenter.uvRect.y + finalSpeed)*1, 1f, 1f);
        //RoadLeft.uvRect = new Rect(0f, (RoadLeft.uvRect.y + finalSpeed) * 1, 1f, 1f);
       // RoadRight.uvRect = new Rect(0f, (RoadRight.uvRect.y + finalSpeed) * 1, 1f, 1f);

    }
}
