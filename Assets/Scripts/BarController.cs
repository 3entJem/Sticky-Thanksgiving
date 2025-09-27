using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class BarController : MonoBehaviour
{
    public Image Lvbarfill;
    public TextMeshProUGUI LvText;
    public TextMeshProUGUI LvUpText;
    public GameObject SideColliders;
    

    public int currentLv = 1;
    public float currentXP = 0f;
    public float targetXP = 20f;
    public float setamount = 2f;
    public float durationTime = 2f;
    void Start()
    {
        UpdateUI();
        if (LvUpText != null)
        {
            LvUpText.gameObject.SetActive(false);
        }
        
    }

    void AddXP(float amount)
    {
        currentXP += amount;
        CheckForlvup();
        UpdateUI();
    }

    void CheckForlvup()
    {
        while (currentXP >= targetXP)
        {
            currentXP -= targetXP;
            currentLv++;
            targetXP *= 2f;
            ShowImageTime();

        }
    }
   
    void UpdateUI()
    {
        Lvbarfill.fillAmount = currentXP / targetXP;
        LvText.text = currentLv.ToString("Lv." + currentLv);
    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SideColliders.CompareTag("Food"))
        {
            AddXP(setamount);
            Destroy(gameObject);

        }
    }
    
    public void ShowImageTime()
    {
        StartCoroutine(DisplayImageCoroutine());
    }

    IEnumerator DisplayImageCoroutine()
    {
        if (LvUpText != null)
        {
            LvUpText.gameObject.SetActive(true);
            yield return new WaitForSeconds(durationTime);
            LvUpText.gameObject.SetActive(false);
        }
    }
}
