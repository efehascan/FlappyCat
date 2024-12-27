using System;
using TMPro;
using UnityEngine;

public class Ending : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lastScoreText;
    CharacterManager _characterManager;

    private void Update()
    {
        lastScoreText.text = "Your Score: " + _characterManager.points.ToString();
    }
}
