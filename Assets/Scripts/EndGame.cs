using System;
using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lastScoreText;
    Character character;

    private void Update()
    {
        lastScoreText.text = "Your Score: " + character.points.ToString();
    }
}
