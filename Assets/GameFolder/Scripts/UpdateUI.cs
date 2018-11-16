using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour {
    /// <summary>
    /// 画面上部　ステータス
    /// 　　　　　タイム
    /// 　　　　　サブカメラ
    /// 　　　　　スキルカウント
    /// 　　　　　ポイントカウント
    /// </summary>

    public Text TimeCount;//ゲームタイム
    public Text PointCount;//ポイント
    public Text SkillCount;//スキルカウント
    public static int SetTime = 99;//セッティング　ゲームタイム　
    public static int SetPoint = 0;//セッティング　point　
    public static int SetSkill = 3;//セッティング　skill
    int TimCount = SetTime;


    int Tim = 0;
    void Start () {
        TimCount = SetTime;
        Tim = 0;
        TimeCount.text = TimCount.ToString("D2");
        PointCount.text = TimCount.ToString("D6");
        TimeCount.text = TimCount.ToString("D2");
    }

	void Update () {

        Tim++;
        if (Tim % 60 == 0)
        {
            TimCount = SetTime - Tim / 60;
            TimeCount.text = TimCount.ToString("D2");
            if (TimCount <= 0)
            {
                //ゲーム終了！
            }
        }
    }
}
