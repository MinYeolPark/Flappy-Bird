using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject Pause;
    public GameObject ReStart;
    public GameObject PopupMenu;
    //public GameObject toggleObj;
    //Toggle toggleSound;
    void Start()
    {
        PopupMenu.SetActive(false);
        //toggleSound = toggleObj.GetComponent<Toggle>();

    }

    void Update()
    {

    }

    public void GamePause()
    {
        Debug.Log("���� �Ͻ�����");
        
        if (Pause.activeSelf)
        {
            Time.timeScale = 0.0f;
        }
        else
        {            
            Time.timeScale = 1.0f;
        }
    }
    public void GameOption()
    {
        Debug.Log("�޴� �˾�!");
        //PopupMenu.SetActive(!PopupMenu.activeSelf);
        PopupMenu.SetActive(true);
        if (PopupMenu.activeSelf) Time.timeScale = 0.0f;
        else Time.timeScale = 1.0f;
    }

    public void GameRestart()
    {
        Debug.Log("Restart��ư ����!");
        ReStart.SetActive(true);
        if (ReStart.activeSelf) Time.timeScale = 1.0f;
        else Time.timeScale = 0.0f;
    }

    public void onOKButton()
    {
        Debug.Log("OK��ư ����!");
        PopupMenu.SetActive(false);
        if (PopupMenu.activeSelf) Time.timeScale = 0.0f;
        else Time.timeScale = 1.0f;
    }

    public void onToggleTest()
    {
        Debug.Log("���!");
    }
}
