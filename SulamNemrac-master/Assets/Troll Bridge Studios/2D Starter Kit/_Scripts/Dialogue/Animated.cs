using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Animated : MonoBehaviour {
    public Text textArea;
    public string[] strings;
    public float speed = 0.1f;

    int stringIndex = 0;
    int characterIndex = 0;
 //   bool PasFini = true;

    // Use this for initialization
    void Start () {
        StartCoroutine(DisplayTimer());
	}
    IEnumerator DisplayTimer()
    {
        while(true)
        {
            yield return new WaitForSeconds(speed);
            if (characterIndex > strings[stringIndex].Length)
                continue;
            textArea.text = strings[stringIndex].Substring(0, characterIndex);
            characterIndex++;

          /*  if (stringIndex > strings.Length-1)
            {
                PasFini = false;
            } */
        }
    }
	
	// Update is called once per frame
	void Update () {
//        if (PasFini)
//       {
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (characterIndex < strings[stringIndex].Length)
                {
                    characterIndex = strings[stringIndex].Length;
                }
                else if (stringIndex < strings.Length)
                {
                    stringIndex++;
                    characterIndex = 0;
//                }
            }
        }
	}
}
