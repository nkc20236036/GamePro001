using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static UnityEditor.Experimental.GraphView.GraphView;

public class TimeDirector : MonoBehaviour
{
    public Sprite[] frames;   // 画像のフレーム配列
    public Image targetImage; // 対象のImageコンポーネント
    public float frameTime = 1f; // フレーム間の時間

    private int currentFrameIndex = 0; // 現在のフレームのインデックス
    private float timer = 0f; // 経過時間のタイマー

    GameObject TimeG;

    // Start is called before the first frame update
    void Start()
    {
        this.TimeG = GameObject.Find("TimeG");
    }
    public void DecreaseTime()
    {
        this.TimeG.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        float timer = 0f;
        timer += Time.deltaTime;
        this.TimeG.GetComponent<Image>().fillAmount -= timer*0.020f;

        // 経過時間がフレーム時間を超えた場合、次のフレームに進める
        if (timer >= frameTime)
        {
            currentFrameIndex++;
            if (currentFrameIndex >= frames.Length)
            {
                currentFrameIndex = 0; // ループ再生
            }

            // 対象のImageコンポーネントのスプライトを切り替える
            targetImage.sprite = frames[currentFrameIndex];

            timer = 0f; // タイマーリセット
        }
    }
}
