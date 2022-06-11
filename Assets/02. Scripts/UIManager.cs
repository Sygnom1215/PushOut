using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text timeText;
    public Text clearText;
    public Text failedText;
    public Image backgroundImage;
    public Button replayButton;
    public Button nextStageButton;

    private void Start()
    {
        clearText.gameObject.SetActive(false);
        failedText.gameObject.SetActive(false);
        backgroundImage.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);
        nextStageButton.gameObject.SetActive(false);
    }
    public void OnReplay()
    {
        Scene curScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(curScene.name);
    }
    public void NextStage()
    {
        
    }
}