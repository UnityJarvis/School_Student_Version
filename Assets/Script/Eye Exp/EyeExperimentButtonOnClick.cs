using UnityEngine;

public class EyeExperimentButtonOnClick : MonoBehaviour
{
    public Animator anim;
    public Light lightt;
    public void PlayLightAnimation()
    {
        lightt.enabled = false;
        anim.Play("New State");
        anim.Play("Line");
    }
    public void StopLightOn()
    {
        lightt.enabled=true;
    }
}
