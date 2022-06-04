//========================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//========================================================
public class UIManager : MonoBehaviour
{
    //---------------------
    public Text _textTime;          //  경과시간을 연출하는 텍스트UI.
    public Text _textClear;         //  성공 텍스트.
    public Text _textFailed;        //  실패 텍스트.
    public Image _imageBG;          //  결과 텍스트의 배경으로 사용될 이미지.
    public Button _buttonReplay;    //  게임 종료후 리플레이 버튼.
    //---------------------
    private void Start()
    {
        //  처음 시작할때는 메시지를 보여줄 필요가 없다.
        _textClear.gameObject.SetActive(false);
        _textFailed.gameObject.SetActive(false);
        _imageBG.gameObject.SetActive(false);
        _buttonReplay.gameObject.SetActive(false);
    }
    //---------------------
    public void OnReplay()
    {
        //  현재 활성화된 씬 정보.
        Scene curScene = SceneManager.GetActiveScene();

        //  씬 로딩.
        SceneManager.LoadScene(curScene.name);
    }
    //---------------------

}