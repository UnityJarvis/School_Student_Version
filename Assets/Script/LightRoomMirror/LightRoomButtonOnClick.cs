using UnityEngine;

public class LightRoomButtonOnClick : MonoBehaviour
{
    public Transform mirrorWall;
    public GameObject spotLight1, spotLight2;

    bool lightStatus = true;
    private void Start()
    {
        ToggleLightStatus();
    }
    public void LightRoomBtnOnClick()
    {
        lightStatus = !lightStatus;
        ToggleLightStatus();
    }

    void ToggleLightStatus()
    {
        if (lightStatus == true)
        {
            spotLight1.SetActive(true);
            spotLight2.SetActive(false);
            mirrorWall.eulerAngles = new Vector3(0,0,90);
        }
        if (lightStatus == false)
        {
            spotLight1.SetActive(false);
            spotLight2.SetActive(true);
            mirrorWall.eulerAngles = new Vector3(0,180,90);
        }
    }
}
