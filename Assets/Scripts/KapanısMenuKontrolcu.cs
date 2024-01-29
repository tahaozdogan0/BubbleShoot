using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KapanisMenuKontrolcu : MonoBehaviour
{
    public Text balonSayacText; // Balon sayısını gösterecek metin alanı

    private void Start()
    {
        // Kapanış menüsünde balon sayısını göster
        int patlayanBalon = PlayerPrefs.GetInt("PatlayanBalon", 0); // Patlatılan balon sayısını al
        balonSayacText.text = "Skor: " + patlayanBalon.ToString(); // Metin alanını güncelle
    }

    public void MenuyeDon()
    {
        SceneManager.LoadScene("yeni sahne"); // Menü sahnesine dön
    }

    public void YenidenOyna()
    {
        SceneManager.LoadScene("Oyun"); // Oyun sahnesine dön
    }
}
