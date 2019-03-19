using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShareOnTwitter : MonoBehaviour
{
    public Button shareTwitter;
    private string _twitterAddress = "http://twitter.com/intent/tweet";

    void Start(){
        shareTwitter.onClick.AddListener(OnClick);
    }


    void OnClick()
    {
        string status = "";
        if (Scoreboard.S.score > ScoreManager.HIGH_SCORE) {
            status = "I got a high score on Prospector Solitaire of " +Scoreboard.S.score + "!";
        }
        else
        {
            status = "I got a score of " + Scoreboard.S.score + " on Prospector Solitaire!";
        }

        Application.OpenURL(_twitterAddress +
            "?text=" + WWW.EscapeURL(status));

    }

}
