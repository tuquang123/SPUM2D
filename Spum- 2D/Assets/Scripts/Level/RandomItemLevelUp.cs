using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomItemLevelUp : MonoBehaviour
{
    [SerializeField] private List<ItemDefine> m_listItemDefine;
    [SerializeField] private Button m_button;
    [SerializeField] private Image m_img;
    [SerializeField] private Text m_description;

    private void Start()
    {
        m_img.SetNativeSize();  
    }

    public void SetImg(Sprite sprite)
    {
        m_button.image.sprite = sprite;
    }

    public void SetDescription(String text)
    {
        m_description.text = text;
    }
}

