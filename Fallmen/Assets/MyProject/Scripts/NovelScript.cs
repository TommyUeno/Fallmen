using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NovelScript : MonoBehaviour
{
    [SerializeField] List<string> messageList = new List<string>();
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] float novelSpeed;
    int novelListIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Novel());
    }

    private IEnumerator Novel()
    {
        int messageCount = 0;
        text.text = "";
        //textaudio.Play();

        while (messageList[novelListIndex].Length > messageCount)
        {
            text.text += messageList[novelListIndex][messageCount];
            messageCount++;

            yield return new WaitForSeconds(novelSpeed);

        }

        novelListIndex++;
        if(novelListIndex < messageList.Count)
        {
            yield return new WaitForSeconds(0.2f);
            yield return new WaitUntil(() => Input.GetKey(KeyCode.Space));
            //OVRInput.GetDown(OVRInput.RawButton.B));
            StartCoroutine(Novel());
        }
        else
        {
            yield return new WaitForSeconds(0.2f);
            yield return new WaitUntil(() => Input.GetKey(KeyCode.Space));
            //OVRInput.GetDown(OVRInput.RawButton.B));

            this.gameObject.SetActive(false);
        }

    }
}
