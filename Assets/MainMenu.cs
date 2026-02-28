using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này để chuyển scene

public class MainMenu : MonoBehaviour
{
    // Hàm này sẽ được gọi khi bấm nút Play
    public void OnPlayButtonClicked()
    {
        // Tên scene phải khớp 100% với tên file Scene Battle của bạn
        SceneManager.LoadScene("Battle");
    }
}