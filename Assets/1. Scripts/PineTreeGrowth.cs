using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PineTreeGrowth : MonoBehaviour
{
    public Image treeImage;            // UI 이미지에 연결
    public Sprite[] pineTreeStages;    // 4단계 소나무 스프라이트 배열
    private int clickCount = 0;        // 클릭 횟수
    private int currentStage = 0;      // 현재 나무 단계

    void Start()
    {
        treeImage.sprite = pineTreeStages[currentStage];
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            clickCount++;
            CheckGrowthStage();
        }
    }

    void CheckGrowthStage()
    {
        if (clickCount >= 20 && currentStage == 0)
        {
            currentStage = 1;
            treeImage.sprite = pineTreeStages[currentStage];
        }
        else if (clickCount >= 50 && currentStage == 1)
        {
            currentStage = 2;
            treeImage.sprite = pineTreeStages[currentStage];
        }
        else if (clickCount >= 80 && currentStage == 2)
        {
            currentStage = 3;
            treeImage.sprite = pineTreeStages[currentStage];
        }
        else if (clickCount >= 100 && currentStage == 3)
        {
            currentStage = 4;
            treeImage.sprite = pineTreeStages[currentStage];
        }
    }
}