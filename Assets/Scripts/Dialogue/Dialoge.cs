using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialoge : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    [SerializeField] private TMP_Text Text;
    [SerializeField, TextArea(2, 6)] private string[] lineasDialogo;

    private float typeTime = 0.2f;

    private bool dialogueStart;
    private int lineIndex;

    // Start is called before the first frame update
    void Start()
    {
        if (dialogueStart)
        {
            StartDialogue();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueStart)
        {
            StartDialogue();
        }
        if (Text.text == lineasDialogo[lineIndex] && Input.GetKeyDown("Jump"))
        {
            NextDialogueLine();
        }
        else if (Text.text != lineasDialogo[lineIndex] && Input.GetKeyDown("Jump"))
        {
            StopAllCoroutines();
            Text.text = lineasDialogo[lineIndex];
        }
    }

    private void StartDialogue()
    {
        dialogueStart = true;
        Panel.SetActive(true);
        lineIndex = 0;
        Time.timeScale = 0f;
        StartCoroutine(ShowLine());
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if (lineIndex < lineasDialogo.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {

            dialogueStart = false;
            Panel.SetActive(false);
            Time.timeScale = 1f;

        }
    }

    private IEnumerator ShowLine()
    {
        Text.text = string.Empty;

        foreach (char ch in lineasDialogo[lineIndex])
        {
            Text.text += ch;
            yield return new WaitForSecondsRealtime(typeTime);
        }
    }
}
