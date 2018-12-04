using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

    void Start()
    {
        // Hämtar "TextMeshProUGUI" componenten från objektet med detta script och sätter den i variabeln "text" när spelet startar
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        //Skriver texten i spelet. "string.Format" är det för att "Point.score" variabeln är en int och måste converteras till en string.
        //String = text
        text.text = string.Format("Score: {0:00}", Point.score);
    }
}
