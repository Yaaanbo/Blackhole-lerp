using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button : MonoBehaviour
{
    public TMP_Text ScoreText;
    int score;

    public Material mat;
    public Material skyMat;
    public Material groundMat;

    public Color startColor, endColor;
    float time;
    private void Update()
    {
        time += Time.deltaTime;
        mat.color = Color.Lerp(startColor, endColor, Mathf.Lerp(0,1,time));
    }
    public void addScore()
    {
        score++;
        ScoreText.text = $"Score : {score}";
    }

    public void changeColor()
    {
        mat.color = Random.ColorHSV();
    }

    public void changeSkybox()
    {
        //skyMat.color = Random.ColorHSV();
        skyMat.SetColor("_SkyTint", Random.ColorHSV());
    }

    public void changeGround()
    {
        groundMat.SetColor("_GroundColor", Random.ColorHSV());
    }

    public void lerpYourBalls()
    {
        time = 0;
        startColor = mat.color;
        endColor = Random.ColorHSV();
    }
    
}
