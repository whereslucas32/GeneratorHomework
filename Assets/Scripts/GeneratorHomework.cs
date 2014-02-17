using UnityEngine;
using System.Collections;

public class GeneratorHomework : MonoBehaviour {
	
	public Transform skyscraperPrefab, truckPrefab, snowmanPrefab, bearPrefab, carPrefab;
		
	int buildingCount = 0;
	
	
	
	// Update is called once per frame
	void Update () {
		if ( buildingCount < 200 ){
			float randomNumber = Random.Range (0f, 100f);
			
			if ( randomNumber < 25.0f){

				// spawn a skyscraper
				Instantiate (skyscraperPrefab, new Vector3( Random.Range (-400f, 400f), 0f, Random.Range (-400f, 400f) ), Quaternion.identity );
			
			} else if(randomNumber < 50.0f && randomNumber > 26.0f) {
				Instantiate (carPrefab, new Vector3( Random.Range (-300f, 300f), 0f, Random.Range (-300f, 300f) ), Quaternion.identity );
			
			}else if(randomNumber < 70.0f && randomNumber > 51.0f) {
				Instantiate (truckPrefab, new Vector3( Random.Range (-300f, 300f), 0f, Random.Range (-300f, 300f) ), Quaternion.identity );

			}else if(randomNumber < 90.0f && randomNumber > 71.0f) {
				Instantiate (snowmanPrefab, new Vector3( Random.Range (-300f, 300f), 0f, Random.Range (-300f, 300f) ), Quaternion.identity );
			
			}else if(randomNumber < 100.0f && randomNumber > 91.0f) {
				Instantiate (bearPrefab, new Vector3( Random.Range (-300f, 300f), 8f, Random.Range (-300f, 300f) ), Quaternion.identity );
			}

			buildingCount = buildingCount + 1;
	
	}
}
}
