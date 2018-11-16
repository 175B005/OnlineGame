using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour {
    /// <summary>
    ///　プレイヤー位置操作
    ///　プレイヤーFaceアニメ
    ///　プレイヤーアニメ
    /// </summary>

    [SerializeField] GameObject _Player;//自身
    Vector3 Coordinate;
    float Speed = 0;
    [SerializeField] Animator _UniChan;//アニメ

    void Start () {
        _UniChan.SetFloat("VelWalkSpeed", Speed);
	}
	
	void Update () {
		
	}
}
