using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    private int a = 0;
    private int b = 0;
    public Text[] Text1;
    // Start is called before the first frame update
    void Start()
    {
        Textchange();
    }

    void GG() {
        if (Text1[b].text == "U") {
            if (Input.GetKeyDown(KeyCode.UpArrow) == true) {
                Text1[b].text = " ";
                b++;
            }
        } else if (Text1[b].text == "D") {
            if (Input.GetKeyDown(KeyCode.DownArrow) == true) {
                Text1[b].text = " ";
                b++;
            }
        } else if (Text1[b].text == "R") {
            if (Input.GetKeyDown(KeyCode.RightArrow) == true) {
                Text1[b].text = " ";
                b++;
            }
        } else if (Text1[b].text == "L") {
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true) {
                Text1[b].text = " ";
                b++;
            }
        }

        if (b >= 4) {
            b = 0;
        }
    }

    void Update() {
        if (Text1[b].text == " ") {
            Textchange();
        }
        GG();
    }

    void Textchange() {
        for (int i = 0; i < 4; i++) {
            a = Random.Range(0, 4);
            if (a == 0) {
                Text1[i].text = "U";
            } else if (a == 1) {
                Text1[i].text = "D";
            } else if (a == 2) {
                Text1[i].text = "R";
            } else {
                Text1[i].text = "L";
            }
        }
    }
}
