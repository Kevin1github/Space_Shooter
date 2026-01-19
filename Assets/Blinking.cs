using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public float speed = 10f;

    public float minAlpha = 0.5f;

    public float maxAlpha = 1f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (spriteRenderer != null)
        {
         
            float t = Mathf.PingPong(Time.time * speed, 1f);

            float newAlpha = Mathf.Lerp(minAlpha, maxAlpha, t);

            Color color = spriteRenderer.color;
            color.a = newAlpha;
            spriteRenderer.color = color;
        }
    }
}