using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSceneManager : MonoBehaviour
{
    public void Quit()
    {
        //빌드된 애플리케이션 종료
        Application.Quit();
        Debug.Log("게임이 종료되었습니다."); // 에디터 테스트용
    }
}
