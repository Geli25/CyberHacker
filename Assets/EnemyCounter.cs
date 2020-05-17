using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour {
    private Playerscript playerscript;
    public GameObject Stage1;
    public GameObject spawn1;
    public GameObject Stage2;
    public GameObject spawn2;
    public GameObject stage3;
    public GameObject stage3_2;
    public GameObject spawn3;
    public GameObject stage4;
    public GameObject spawn4;
    public GameObject stage5;
    public GameObject stage5_2;
    public GameObject spawn5;
    public GameObject stage6;
    bool stage1clear;
    bool stage2clear;
    bool stage3clear;
    bool stage4clear;
    bool stage5clear;

	// Use this for initialization
	void Start () {
    }

    IEnumerator WaitandWin()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Win");
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectsWithTag("Enemy_stage1").Length==1)
        {
            Stage1.SetActive(false);
            spawn1.SetActive(true);

            print("level1 enemy killed");
        }

        if (GameObject.FindWithTag("Enemy_stage1") == null)
        {
            stage1clear = true;
            spawn1.SetActive(false);
            print("stage1clear");
        }

        if (stage1clear == true && GameObject.FindGameObjectsWithTag("Enemy_stage2").Length==1)
        {
            Stage2.SetActive(false);
            spawn2.SetActive(true);
        }

        if (GameObject.FindWithTag("Enemy_stage2") == null)
        {
            stage2clear = true;
            spawn2.SetActive(false);
            print("stage2clear");
        }

        if (stage2clear == true && GameObject.FindGameObjectsWithTag("Enemy_stage3").Length == 1)
        {
            stage3.SetActive(false);
            stage3_2.SetActive(false);
            spawn3.SetActive(true);
        }

        if (GameObject.FindWithTag("Enemy_stage3") == null)
        {
            stage3clear = true;
            spawn3.SetActive(false);
            print("stage3clear");
        }

        if (stage3clear==true&&GameObject.FindGameObjectsWithTag("Enemy_stage4").Length==1)
        {
            stage4.SetActive(false);
            spawn4.SetActive(true);
        }

        if (GameObject.FindWithTag("Enemy_stage4") == null)
        {
            stage4clear = true;
            spawn4.SetActive(false);
            print("stage4clear");
        }

        if (stage4clear ==true && GameObject.FindGameObjectsWithTag("Enemy_stage5").Length == 1)
        {
            stage5.SetActive(false);
            stage5_2.SetActive(false);
            spawn5.SetActive(true);
        }

        if (GameObject.FindWithTag("Enemy_stage5") == null)
        {
            stage5clear = true;
            spawn5.SetActive(false);
            print("stage5clear");
        }

        if (stage5clear == true && GameObject.FindGameObjectsWithTag("Enemy_stage6").Length == 1)
        {
            print("game finished");
            StartCoroutine(WaitandWin());
        }

    }
}
