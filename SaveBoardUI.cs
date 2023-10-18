using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveBoardUI : MonoBehaviour
{
    // ���̺꺸�� ��ư ������

    PauseMenu pauseMenu;

    Button saveCloseButton;

    public Action updateData;

    private void Awake()
    {
        saveCloseButton = transform.GetChild(2).GetComponent<Button>();
        pauseMenu =FindObjectOfType<PauseMenu>();
    }

    private void Start()
    {
        saveCloseButton.onClick.AddListener(CloseSaveBoard);
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        pauseMenu.onSave += OpenSaveBoard;
    }

    private void OpenSaveBoard()
    {
        gameObject.SetActive(true);
        updateData?.Invoke();
    }

    // ��ư ��� �߰�
    private void CloseSaveBoard()
    {
        gameObject.SetActive(false);
    }
}
