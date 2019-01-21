using UnityEngine;

public static class LevelParameters {

	//Will happen? How often?
	private static int wordParameter;
	private static int timeParameter;
	private static int starParameter;
	private static int tornadoParameter;
	private static int flashParameter;
	//More parameters soon...

	public static int[] GetParameters (int level){

		setWordParameter (level);
		setTimeParameter (level);
		setStarParameter (level);
		setTornadoParameter (level);
		setFlashParameter (level);

		int[] parameters = new int[] { wordParameter, timeParameter, starParameter, tornadoParameter, flashParameter };

		return parameters; 

	}

	private static void setWordParameter (int level){
		float rng = Random.Range (0.00f, 1.00f);

		if (level == 1) {
			
			wordParameter = 4;

		}

		else if (level >= 2 && level <= 4) {
			
			if (rng <= 0.70f) wordParameter = 4;
			else if (rng > 0.70f) wordParameter = 6;

		}

		else if (level >= 5 && level <= 8) {

			if (rng <= 0.10f) wordParameter = 4;
			else if (rng > 0.10f && rng <= 0.70f) wordParameter = 6;
			else if (rng > 0.70f) wordParameter = 8;

		}

		else if (level >= 9 && level <= 13) {

			if (rng <= 0.10f) wordParameter = 6; 
			else if (rng > 0.10f && rng <= 0.70f) wordParameter = 8;
			else if (rng > 0.70f) wordParameter = 10;

		}

		else if (level >= 14 && level <= 18) {

			if (rng <= 0.10f) wordParameter = 6; 
			else if (rng > 0.10f && rng <= 0.70f) wordParameter = 10;
			else if (rng > 0.70f) wordParameter = 12;

		}

		else if (level >= 19 && level <= 25) {

			if (rng <= 0.10f) wordParameter = 8; 
			else if (rng > 0.10f && rng <= 0.70f) wordParameter = 12;
			else if (rng > 0.70f) wordParameter = 16;

        }

        else if (level >= 26) {

            if (rng <= 0.70f) wordParameter = 16;
            else if (rng > 0.70f) wordParameter = 12;

        }

    }

	private static void setTimeParameter (int level){ //TODO Time Parameter Tuning
		float rng = Random.Range (0.00f, 1.00f);

		if (level == 1) {

			timeParameter = 2*5+10; //2 x 5 + 10

		} 

		else if (level >= 2 && level <= 4) {

			timeParameter = 2*4+10; //2 x 4 + 10
			if (rng < 0.10f) timeParameter = 13;

		}

		else if (level >= 5 && level <= 8) {

			timeParameter = 3*4+10; //3 x 4 + 10
			if (rng < 0.10f) timeParameter = 15;

		}

		else if (level >= 9 && level <= 13) {

			timeParameter = 4*3+10; //4 x 3 + 10
			if (rng < 0.10f) timeParameter = 12;

		}

		else if (level >= 14 && level <= 18) {

			timeParameter = 5*3+10; //5 x 3 + 10
			if (rng < 0.10f) timeParameter = 15;

		}

		else if (level >= 19 && level <= 25) {

			timeParameter = 6*3+10; //6 x 3 + 10
			if (rng < 0.10f) timeParameter = 18;

		}

        else if (level >= 26 && level <= 32) //Último words
        {

            timeParameter = 5 * 3 + 10; //5 x 3 + 10
            if (rng < 0.20f) timeParameter = 18;

        }

        else if (level >= 33)
        {

            timeParameter = 4 * 3 + 10; //4 x 3 + 10
            if (rng < 0.20f) timeParameter = 15;

        }

    }

	private static void setStarParameter (int level){
		float rng = Random.Range (0.00f, 1.00f);

		starParameter = 0;

	}

	private static void setTornadoParameter (int level){
		float rng = Random.Range (0.00f, 1.00f);
        tornadoParameter = 0;

        if (level >= 1 && level <=10)
        {

            if (rng <= 0.25f) tornadoParameter = 1;

        }

        else if (level >= 11)
        {

            if (rng <= 0.25f) tornadoParameter = 2;

        }

        else if (level >= 21)
        {

            if (rng <= 0.25f) tornadoParameter = 3;

        }

        else if (level >= 31)
        {

            if (rng <= 0.25f) tornadoParameter = 5;

        }

    }

	private static void setFlashParameter (int level){
		float rng = Random.Range (0.00f, 1.00f);

		flashParameter = 0;

	}

}
