using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GameDirector : MonoBehaviour
{
    public Sprite[] frames;   // �摜�̃t���[���z��
    public Image targetImage; // �Ώۂ�Image�R���|�[�l���g
    public float frameTime = 1f; // �t���[���Ԃ̎���

    private int currentFrameIndex = 0; // ���݂̃t���[���̃C���f�b�N�X
    private float timer = 0f; // �o�ߎ��Ԃ̃^�C�}�[

    GameObject Timer;

    // Start is called before the first frame update
    void Start()
    {
        this.Timer = GameObject.Find("Timer");
        timer = 0f; // �^�C�}�[���Z�b�g
    }
    public void DecreaseTime()
    {
        this.Timer.GetComponent<TextMeshProUGUI>().text += 0.1f;
    }
    void Update()
    {
        float timer = 0f;
        timer += Time.deltaTime;
        this.Timer.GetComponent<TextMeshProUGUI>().text =timer.ToString("F2")+"km";

        // �o�ߎ��Ԃ��t���[�����Ԃ𒴂����ꍇ�A���̃t���[���ɐi�߂�
        if (timer >= frameTime)
        {
            currentFrameIndex++;
            if (currentFrameIndex >= frames.Length)
            {
                currentFrameIndex = 0; // ���[�v�Đ�
            }

            // �Ώۂ�Image�R���|�[�l���g�̃X�v���C�g��؂�ւ���
            targetImage.sprite = frames[currentFrameIndex];

           
        }
    }
}