using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor.Timeline.Actions;




public class TitleManager : MonoBehaviour
{
    [SerializeField] private Button btnNew;
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnOption;
    [SerializeField] private Button btnExit;



    void Awake()
    {
        ///��ư �� ����
        ///0 Ÿ��Ʋ, 1 �ε� , 2 ����
        btnNew.onClick.AddListener(() =>
        {
            //Ÿ��Ʋ������ �÷��̾�����.            
            //SceneManager.LoadSceneAsync(2);
            UnityEngine.SceneManagement.SceneManager.sceneLoaded += loadSceneAction;
        });

        btnContinue.onClick.AddListener(() =>
        {
            

        });

        btnOption.onClick.AddListener(() =>
        {
            

        });

        btnExit.onClick.AddListener(() =>
        {
            //������ ������ ���¿����� ������ ����.
            //������ ��� �߿��� �����͸� Stop����.

            //��ó��.
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;

#else
            Application.Quit();
#endif


        });

    }

    

private void loadSceneAction(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        Debug.Log("�ε�Ϸ�");
        UnityEngine.SceneManagement.SceneManager.sceneLoaded -= loadSceneAction;
    }

    void Update()
    {
        
    }
}
