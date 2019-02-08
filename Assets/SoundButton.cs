using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour {

    public AudioSource myBtn;
    public AudioClip hoverBtn;
    public AudioClip ClickBtn;

    public void HoverSound()
    {
        myBtn.PlayOneShot(hoverBtn);
    }

    public void ClickSound()
    {
        myBtn.PlayOneShot(ClickBtn);
    }


}
