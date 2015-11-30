using UnityEngine;
using System.Collections;

public class TurnColorScript : MonoBehaviour {

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }

    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }

    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        rend.material.color = col;
    }
}
