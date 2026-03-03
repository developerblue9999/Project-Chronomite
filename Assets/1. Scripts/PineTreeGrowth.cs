using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PineTreeGrowth : MonoBehaviour
{
    public Image treeImage;            // UI 이미지에 연결
    public Sprite[] pineTreeStages;    // 4단계 소나무 스프라이트 배열
    private int clickCount = 0;        // 클릭 횟수
    private int currentStage = 0;      // 현재 나무 단계
    public TextMeshProUGUI TMP;

    void Start()
    {
        treeImage.sprite = pineTreeStages[currentStage];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
            TMP.text = clickCount.ToString();
            CheckGrowthStage();
        }
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("1. StartScene");
        }
    }

    void CheckGrowthStage()
    {
        if (clickCount >= 100 && currentStage == 0)
        {
            currentStage = 1;
            treeImage.sprite = pineTreeStages[currentStage];
        }
        else if (clickCount >= 200 && currentStage == 1)
        {
            currentStage = 2;
            treeImage.sprite = pineTreeStages[currentStage];
        }
        else if (clickCount >= 300 && currentStage == 2)
        {
            currentStage = 3;
            treeImage.sprite = pineTreeStages[currentStage];
        }
        else if (clickCount >= 400 && currentStage == 3)
        {
            currentStage = 4;
            treeImage.sprite = pineTreeStages[currentStage];
        }
    }
}