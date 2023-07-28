using UnityEngine;

public class ShadowButtonOnClick : MonoBehaviour
{
    public Transform pot;
    public Light spotLight;

    bool lightTemperature;

    public void ShadowBtnOnClick()
    {
        lightTemperature = !lightTemperature;
        lightToggle();
    }
    void lightToggle()
    {
        if (lightTemperature == true)
        {
            spotLight.colorTemperature = 3000;
        }
        if (lightTemperature == false)
        {
            spotLight.colorTemperature = 15000;
        }
    }
    void Update()
    {
        pot.Rotate(0, 0.1f, 0);
    }
}
