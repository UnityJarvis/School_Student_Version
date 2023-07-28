using UnityEngine;

public class WaterButtonOnClick : MonoBehaviour
{
    public Animator anim;
    public LineRenderer lr;
    public Vector3 pt1, pt2;
    // Update is called once per frame
    public void WaterBtnOnClick()
    {
        anim.Play("New State");
        anim.Play("Water");
    }
    void Update()
    {
        lr.SetPosition(1,pt1);
        lr.SetPosition(2,pt2);
    }
}
