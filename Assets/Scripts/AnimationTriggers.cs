using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggers : MonoBehaviour
{
    public ParticleSystem Hit;
    public ParticleSystem Splash;
    public GameObject Button;

    public void ActivateButton()
    {
        Button.SetActive(true);
        Button.GetComponent<Animator>().Play("ButtonAppear");
    }

    public void ChestHit()
    {
        Hit.Play();
    }


    public void ChestOpen()
    {
        Splash.Play();
    }
}
