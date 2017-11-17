using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JourneyLight : MonoBehaviour{
    [Header("Light up material")]
    public Material LightMaterial;
    [Header("Level Texture maps")]
    public Texture[] AllColor;
    public Texture[] LightMaps;
    [Header("Light Up speed & current player cloak level")]
    public float speed;
    public float LightLevel;
    [SerializeField]
    private int CurrentLevel;
    [Header("Input key for player cloak level")]
    public KeyCode up;
    public KeyCode down;
    public KeyCode next;
    public KeyCode previous;

    [Header("Animation on cloth")]
    [SerializeField]
    private bool IsAnim;
    [SerializeField]
    private Texture[] AnimTex;
    [SerializeField]
    private int AnimNum;


    void Start()
    {
      
    }

    void Update()
    {
        LightMaterial.SetFloat("_Glow", LightLevel);

        if (Input.GetKeyDown(previous))
        {
            CurrentLevel -= 1;
            if (CurrentLevel < 0)
            {
                CurrentLevel = 3;
            }
            SetCurrentPlayerLevel();
        }

        if (Input.GetKeyDown(next))
        {
            CurrentLevel += 1;
            if (CurrentLevel > 3)
            {
                CurrentLevel = 0;
            }
            SetCurrentPlayerLevel();
        }



        if (Input.GetKey(up))
        {
            if (LightLevel < 3)
            {
                {
                    LightLevel += speed * Time.deltaTime;
                }
            }
        }

        if (Input.GetKey(down))
        {
            if (LightLevel > 0.1)
            {
                LightLevel -= speed * Time.deltaTime;
            }
        }

    }

    private void FixedUpdate()
    {
        if (IsAnim)
        {
            AnimNum++;
            if(AnimNum > 7)
            {
                AnimNum = 0;
            }
            LightMaterial.SetTexture("_ThirdTex", AnimTex[AnimNum]);
            //LightMaterial.SetTexture("_SecondTex", LightMaps[CurrentLevel]);
        }
    }

    void SetCurrentPlayerLevel()
    {
        LightMaterial.SetTexture("_ThirdTex", AllColor[CurrentLevel]);
        LightMaterial.SetTexture("_SecondTex", LightMaps[CurrentLevel]);
    }

}


