using UnityEngine;

public class ReflectionButtonOnClick : MonoBehaviour
{
    public LineRenderer lr;
    public Light spotlight;
    public Animator animator;
    public Vector3 pt1, pt2;
    public void ReflectionBtnOnClick()
    {
        spotlight.enabled = false;
        animator.Play("New State");
        animator.Play("Reflect");
    }

    public void SpotLightOn()
    {
        spotlight.enabled = true;
    }

    private void Update()
    {
        lr.SetPosition(1,pt1);
        lr.SetPosition(2,pt2);
    }

}
