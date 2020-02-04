using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float Scrolling_Speed = 0.2f;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 offset = meshRenderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y += Time.deltaTime *Scrolling_Speed;

        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex",offset);
    }
}
