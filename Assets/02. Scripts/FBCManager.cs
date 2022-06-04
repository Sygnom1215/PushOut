using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBCManager : MonoBehaviour
{
    public UIManager uiManager;
    public int fallBox = 0;
    public float currentTime = 30f;
    bool endGame = false;

    private void OnTriggerEnter(Collider other)
    {
        if (endGame == true)
            return;

        if (other.gameObject.CompareTag("Check Target"))
            ++fallBox;

        if (other.gameObject.CompareTag("Player"))
        {
            endGame = true;
            uiManager.failedText.gameObject.SetActive(true);
            uiManager.backgroundImage.gameObject.SetActive(true);
            uiManager.replayButton.gameObject.SetActive(true);
        }

        if (fallBox >= 16)
        {
            endGame = true;
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
            endGame = true;
            uiManager.failedText.gameObject.SetActive(true);
            uiManager.backgroundImage.gameObject.SetActive(true);
            uiManager.replayButton.gameObject.SetActive(true);
            return;
        }

        if (endGame == true)
            return;
    }
}