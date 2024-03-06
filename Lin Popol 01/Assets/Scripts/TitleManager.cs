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
        ///버튼 씬 변경
        ///0 타이틀, 1 로딩 , 2 게임
        btnNew.onClick.AddListener(() =>
        {
            //타이틀씬에서 플레이씬으로.            
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
            //게임을 빌드한 상태에서는 게임을 종료.
            //에디터 사용 중에는 에디터를 Stop으로.

            //전처리.
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;

#else
            Application.Quit();
#endif


        });

    }

    

private void loadSceneAction(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        Debug.Log("로드완료");
        UnityEngine.SceneManagement.SceneManager.sceneLoaded -= loadSceneAction;
    }

    void Update()
    {
        
    }
}
