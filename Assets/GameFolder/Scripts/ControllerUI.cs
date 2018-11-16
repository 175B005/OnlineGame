using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerUI : MonoBehaviour {
    /// <summary>
    /// ニムサイト　ブルガリアコントローラ
    /// コントローラ入力処理を送る
    /// カーソルも同様
    /// </summary>

    public bool buttonA;
    public bool buttonB;

    public static Vector2 GetControl;//Input用データ

    Vector2 cursorPos;
    Vector2 cursorCenter = new Vector2(200, 270);//変更なし
    GameObject cursor;//タップではなくカーソル操作

    void Start () {
        Set0false();
    }
	
	void Update () {

        cursorPos = Input.mousePosition;
        cursorPos.x -= cursorCenter.x;
        cursorPos.y -= cursorCenter.y;

        if (cursorPos.x > 200)
            cursorPos.x = 200;
        if (cursorPos.x < -200)
            cursorPos.x = -200;

        if (cursorPos.y > 200)
            cursorPos.y = 200;
        if (cursorPos.y < -200)
            cursorPos.y = -200;

        cursorPos.x = cursorPos.x / 200;
        cursorPos.y = cursorPos.y / 200;

        GetControl = cursorPos;
        Debug.Log(GetControl);
    }

    void Set0false()
    {
        GetControl = new Vector2(0,0);

    }
}
