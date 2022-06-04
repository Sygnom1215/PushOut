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
    public Text _textTime;          //  ����ð��� �����ϴ� �ؽ�ƮUI.
    public Text _textClear;         //  ���� �ؽ�Ʈ.
    public Text _textFailed;        //  ���� �ؽ�Ʈ.
    public Image _imageBG;          //  ��� �ؽ�Ʈ�� ������� ���� �̹���.
    public Button _buttonReplay;    //  ���� ������ ���÷��� ��ư.
    //---------------------
    private void Start()
    {
        //  ó�� �����Ҷ��� �޽����� ������ �ʿ䰡 ����.
        _textClear.gameObject.SetActive(false);
        _textFailed.gameObject.SetActive(false);
        _imageBG.gameObject.SetActive(false);
        _buttonReplay.gameObject.SetActive(false);
    }
    //---------------------
    public void OnReplay()
    {
        //  ���� Ȱ��ȭ�� �� ����.
        Scene curScene = SceneManager.GetActiveScene();

        //  �� �ε�.
        SceneManager.LoadScene(curScene.name);
    }
    //---------------------

}