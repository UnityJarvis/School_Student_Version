using UnityEngine;

public class PaintButtonOnClick : MonoBehaviour
{
    public GameObject sideLight, FrontLight;
    bool lightState;
    public Animator animator;
    
    public void PaintBtnOnClick()
    {
        lightState = !lightState;
        ToggleLight();
    }
    void ToggleLight()
    {
        if (lightState == true)
        {
            sideLight.SetActive(true);
            FrontLight.SetActive(false);
            animator.Play("EnableNormal");
        }
        if (lightState == false)
        {
            sideLight.SetActive(false);
            FrontLight.SetActive(true);
            animator.Play("DisableNormal");
        }
    }
}
