using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBCManager : MonoBehaviour
{
    public UIManager uiManager;
    public int fallBox = 0;
    public float currentTime = 30f;
    private GameObject[] arrageBox;
    bool IsEndGame = false;

    private void Start()
    {
        arrageBox = GameObject.FindGameObjectsWithTag("Check Target");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (IsEndGame == true)
            return;

        if (other.gameObject.CompareTag("Check Target"))
            ++fallBox;

        if (other.gameObject.CompareTag("Player"))
        {
            IsEndGame = true;
            uiManager.failedText.gameObject.SetActive(true);
            uiManager.backgroundImage.gameObject.SetActive(true);
            uiManager.replayButton.gameObject.SetActive(true);
        }

        if (fallBox >= arrageBox.Length)
        {
            IsEndGame = true;
            uiManager.clearText.gameObject.SetActive(true);
            uiManager.backgroundImage.gameObject.SetActive(true);
            uiManager.replayButton.gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        uiManager.timeText.text = currentTime.ToString();

        if (currentTime <= 0)
        {
            IsEndGame = true;
            uiManager.failedText.gameObject.SetActive(true);
            uiManager.backgroundImage.gameObject.SetActive(true);
            uiManager.replayButton.gameObject.SetActive(true);
            return;
        }

        if (IsEndGame == true)
            return;
    }
}