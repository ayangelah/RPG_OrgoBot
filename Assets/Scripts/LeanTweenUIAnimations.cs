using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeanTweenUIAnimations : MonoBehaviour
{
    public GameObject selectedUI;
    [SerializeField] GameObject neutral;
    [SerializeField] private bool isBlinking = false;
    [SerializeField] private bool isTalking = false;
    [SerializeField] HintRecharge hintRecharge;

    [SerializeField] private float duration = 1f;

    // Start is called before the first frame update
    void Start()
    {
        if (isBlinking == true)
        {
            Blinking();
        }
    }

    public void DelayedAction()
    {

        if (isTalking == true)
        {
            Talking();
        }
    }

    void Blinking()
    {
        LeanTween.scaleY(selectedUI, 0.1f, duration).setEaseInExpo().setLoopPingPong();
    }


    void Talking()
    {
        if (hintRecharge.hintReady)
        {
            neutral.SetActive(false);
            selectedUI.SetActive(true);
            LeanTween.scaleY(selectedUI, 0.1f, duration).setEaseInBounce().setLoopPingPong(30);

            //hint is given.
        }
        else
        {
            return;
        }
    }
}
