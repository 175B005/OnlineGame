using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    void Update()
    {
        if (isLocalPlayer)
        {
            // 左右キーでx方向に移動、上下キーでy方向に移動する
            Vector3 motion = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * Time.deltaTime;
            transform.Translate(motion);
        }
    }
}
