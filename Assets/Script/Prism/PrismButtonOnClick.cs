using UnityEngine;

public class PrismButtonOnClick : MonoBehaviour
{
    public Animator animator;
    public void PlayPrismLightAnimatio()
    {
        animator.Play("New State");
        animator.Play("PrismClip");
    }
}
