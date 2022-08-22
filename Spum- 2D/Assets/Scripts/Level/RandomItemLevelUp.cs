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

    private string name;

    public string GetName() => name;
    
    public System.Action<RandomItemLevelUp> OnClickItem;

    private void Start()
    {
        m_img.SetNativeSize();
        m_button.onClick.AddListener(ClickItemWhenLevelUp);
    }

    public void SetName(string name)
    {
        name = name;
    }

    public void SetImg(Sprite sprite)
    {
        m_img.sprite = sprite;
    }

    public void SetDescription(String text)
    {
        m_description.text = text;
    }

    public void ClickItemWhenLevelUp()
    {
        OnClickItem?.Invoke(this);
    }
}

