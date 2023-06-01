using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacija : MonoBehaviour {
	public Objekti objektuSkripts;

	void Update () {
		if(objektuSkripts.pedejaisVilktais != null)
		{
			if (Input.GetKey(KeyCode.Z))
			{
				objektuSkripts.pedejaisVilktais.
				GetComponent<RectTransform>().
				transform.Rotate(0, 0, Time.deltaTime * 10f);
			}

            if (Input.GetKey(KeyCode.X))
            {
                objektuSkripts.pedejaisVilktais.
                GetComponent<RectTransform>().
                transform.Rotate(0, 0, -Time.deltaTime * 10f);
            }

			if(Input.GetKey(KeyCode.UpArrow)){
				if(objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().
					localScale.y <= 0.85f){
					objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale =
					new Vector2(objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale.x,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
					transform.localScale.y + 0.001f);
				}
			}


            if (Input.GetKey(KeyCode.DownArrow)){
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
                    localScale.y >= 0.3f){
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
                    transform.localScale.y - 0.001f);
                }
            }


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
                    localScale.x >= 0.3f)
                {
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x - 0.001f,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.y);
                }
            }


            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
                    localScale.x <= 0.85f)
                {
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x + 0.001f,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.y);
                }
            }
        }
	}
}
