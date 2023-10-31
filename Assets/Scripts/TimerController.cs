using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private float currentTime;
    private bool isRacing;
    [SerializeField] private Text textTime;
    [SerializeField] private UI_Controller controller_ui;

    private void Start()
    {
        isRacing = false;
        textTime.enabled = false;
    }
    void Update()
    {
        if (isRacing)
        {
            currentTime += Time.deltaTime;
            textTime.text = currentTime.ToString("F2") + " s";
        }
    }

    public void startTimer()
    {
        isRacing = true;
        textTime.enabled = true;
    }

    public void stopTimer()
    {
        isRacing = false;
        controller_ui.finishTrace(currentTime);
        textTime.enabled = false;
    }
}
