using UnityEngine;

public class EyeExperimentButtonOnClick : MonoBehaviour
{
    public Animator anim;
    public GameObject lightt;
    public void PlayLightAnimation()
    {
        lightt.SetActive(false);
        anim.Play("New State");
        anim.Play("Line");
    }
    public void StopLightOn()
    {
        lightt.SetActive(true);
    }
}
