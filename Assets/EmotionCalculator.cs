using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionCalculator : MonoBehaviour
{

    public string emotion;
    public UDPReceive udpReceive;
    public Image emotionImage;
    public List<Sprite> emotionSprites = new List<Sprite>();
    public TMPro.TextMeshProUGUI emotionText;


    // Update is called once per frame
    void Update()
    {
        emotion = udpReceive.data;
        display_emotion(emotion);
        emotionText.text = emotion;
    }

    public void display_emotion(string emotion)
    {
        switch (emotion)
        {
            case "happy":
                emotionImage.sprite = emotionSprites[0];
                break;
            case "sad":
                emotionImage.sprite = emotionSprites[1];
                break;
            case "angry":
                emotionImage.sprite = emotionSprites[2];
                break;
            case "surprised":
                emotionImage.sprite = emotionSprites[3];
                break;
            case "disgusted":
                emotionImage.sprite = emotionSprites[4];
                break;
            case "fear":
                emotionImage.sprite = emotionSprites[5];
                break;
            case "neutral":
                emotionImage.sprite = emotionSprites[6];
                break;
            default:
                emotionImage.sprite = emotionSprites[7];
                break;
        }
    }
}
