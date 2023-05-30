using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static UnityEditor.Experimental.GraphView.GraphView;

public class TimeDirector : MonoBehaviour
{
    public Sprite[] frames;   // �摜�̃t���[���z��
    public Image targetImage; // �Ώۂ�Image�R���|�[�l���g
    public float frameTime = 1f; // �t���[���Ԃ̎���

    private int currentFrameIndex = 0; // ���݂̃t���[���̃C���f�b�N�X
    private float timer = 0f; // �o�ߎ��Ԃ̃^�C�}�[

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

            timer = 0f; // �^�C�}�[���Z�b�g
        }
    }
}
